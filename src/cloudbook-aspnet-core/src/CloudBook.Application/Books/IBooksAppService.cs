using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CloudBook.Books.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CloudBook.Books
{
    /// <summary>
    /// 书籍的应用服务
    /// </summary>
    public interface IBooksAppService:IApplicationService
    {
        /// <summary>
        /// 分页查询获取书籍
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<PagedResultDto<BookListDto>> GetPagedBooksAsync(GetBooksInputDto dto);
    }
}
