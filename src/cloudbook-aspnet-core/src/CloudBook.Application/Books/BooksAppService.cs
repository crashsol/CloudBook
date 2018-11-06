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
