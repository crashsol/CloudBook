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

namespace CloudBook.Books
{
    public class BooksAppService : IBooksAppService
    {

        private readonly IRepository<Book, long> _bookRepository;
        public BooksAppService(IRepository<Book, long> repository)
        {
            _bookRepository = repository;
        }

        public async Task BatchDeleteAsync(List<long> input)
        {
           await _bookRepository.DeleteAsync(a => input.Contains(a.Id));
        }

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

        private async Task<BookEditDto> CreateBookAsync(BookEditDto book)
        {
            var entity = book.MapTo<Book>();
            await _bookRepository.InsertAsync(entity);
            var dto = entity.MapTo<BookEditDto>();
            return dto;
        }

        private async Task UpdateAsync(BookEditDto book)
        {
            var entity = await _bookRepository.GetAsync(book.Id.Value);
            book.MapTo(entity);
            await _bookRepository.UpdateAsync(entity);
        }

        public async Task DeleteBookAsync(EntityDto<long> input)
        {

            var entity =await _bookRepository.GetAsync(input.Id);
            if (entity != null) await _bookRepository.DeleteAsync(input.Id);
           
        }

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
