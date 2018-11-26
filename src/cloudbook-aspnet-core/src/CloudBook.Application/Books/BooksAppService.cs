using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using CloudBook.Books.Dtos;
using Microsoft.EntityFrameworkCore;
using Abp.Linq.Extensions;
using Abp.AutoMapper;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using CloudBook.Books.Authorization;

namespace CloudBook.Books
{
    [AbpAuthorize(BookPermissions.BookManager)]
    public class BooksAppService : IBooksAppService
    {

        private readonly IRepository<Book, long> _bookRepository;
        public BooksAppService(IRepository<Book, long> repository)
        {
            _bookRepository = repository;
        }

        [AbpAuthorize(BookPermissions.BatchDelete)]
        public async Task BatchDeleteAsync(List<long> input)
        {
           await _bookRepository.DeleteAsync(a => input.Contains(a.Id));
        }

       [AbpAuthorize(BookPermissions.Create,BookPermissions.Edit)]
        public async Task CreateOrUpdateBookAsync(CreateOrUpdateBookInput input)
        {
            if(input.Book.Id.HasValue)
            {
                await UpdateAsync(input.Book);
            }
            else
            {
                await CreateBookAsync(input.Book);
            }
        }

        [AbpAuthorize(BookPermissions.Edit)]
        private async Task<BookEditDto> CreateBookAsync(BookEditDto book)
        {
            var entity = book.MapTo<Book>();
            await _bookRepository.InsertAsync(entity);
            var dto = entity.MapTo<BookEditDto>();
            return dto;
        }

        [AbpAuthorize(BookPermissions.Create)]
        private async Task UpdateAsync(BookEditDto book)
        {
            var entity = await _bookRepository.GetAsync(book.Id.Value);
            book.MapTo(entity);
            await _bookRepository.UpdateAsync(entity);
        }


        [AbpAuthorize(BookPermissions.Delete)]
        public async Task DeleteBookAsync(EntityDto<long> input)
        {

            var entity =await _bookRepository.GetAsync(input.Id);
            if (entity != null) await _bookRepository.DeleteAsync(input.Id);
           
        }

        [AbpAuthorize(BookPermissions.Edit)]
        public async Task<GetBookForEditOutput> GetBookForEditOutputAsync(NullableIdDto<long> input)
        {
            var output = new GetBookForEditOutput();
            BookEditDto dto;
            if(input.Id.HasValue)
            {
                var entity = await _bookRepository.GetAsync(input.Id.Value);
                dto = entity.MapTo<BookEditDto>();
            }
            else
            {
                dto = new  BookEditDto();
            }
            output.Book = dto;
            return output;
        }

        [AbpAuthorize(BookPermissions.Query)]
        public async Task<PagedResultDto<BookListDto>> GetPagedBooksAsync(GetBooksInputDto dto)
        {
            var query = _bookRepository.GetAll().AsNoTracking()
                .WhereIf(!dto.FilterText.IsNullOrWhiteSpace(), b => b.Name.Contains(dto.FilterText)).AsQueryable() ;
            var count = await query.CountAsync();
            var entityList = await query.OrderBy(dto.Sorting).PageBy(dto).ToListAsync();
            var entityDtos = entityList.MapTo<List<BookListDto>>();
            return new PagedResultDto<BookListDto>(count,entityDtos);
        }
    }
}
