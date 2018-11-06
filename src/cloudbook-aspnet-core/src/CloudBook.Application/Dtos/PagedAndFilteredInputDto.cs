using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBook.Dtos
{

    /// <summary>
    /// 带过滤器的全局输入Dto基类
    /// </summary>
    public class PagedAndFilteredInputDto : PagedAndSortedResultRequestDto
    {

        public string FilterText { get; set; } 
       
    }
}
