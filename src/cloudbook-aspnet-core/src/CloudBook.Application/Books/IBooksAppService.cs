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

        /// <summary>
        /// 添加或则修改书籍
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdateBookAsync(CreateOrUpdateBookInput input);

        /// <summary>
        /// 删除书籍
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task DeleteBookAsync(EntityDto<long> input);

        /// <summary>
        /// 批量删除书籍
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task BatchDeleteAsync(List<long> input);

        /// <summary>
        /// 获取编辑状态下的BOOK实体
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetBookForEditOutput> GetBookForEditOutputAsync(NullableIdDto<long> input);

    }
}
