

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using CloudBook.Books;

namespace CloudBook.Books.Dtos
{
    public class BookTagListDto : CreationAuditedEntityDto<long> 
    {

        
		/// <summary>
		/// 标签名称
		/// </summary>
		[MaxLength(50, ErrorMessage="标签名称超出最大长度")]
		[MinLength(3, ErrorMessage="标签名称小于最小长度")]
		[Required(ErrorMessage="标签名称不能为空")]
		public string Name { get; set; }




    }
}