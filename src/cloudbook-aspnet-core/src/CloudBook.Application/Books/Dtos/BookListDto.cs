

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using CloudBook.Books;

namespace CloudBook.Books.Dtos
{
    public class BookListDto : CreationAuditedEntityDto<long> 
    {

        
		/// <summary>
		/// 书名
		/// </summary>
		[MaxLength(50, ErrorMessage="书名超出最大长度")]
		[MinLength(1, ErrorMessage="书名小于最小长度")]
		[Required(ErrorMessage="书名不能为空")]
		public string Name { get; set; }



		/// <summary>
		/// 作者
		/// </summary>
		[MaxLength(50, ErrorMessage="作者超出最大长度")]
		[MinLength(1, ErrorMessage="作者小于最小长度")]
		[Required(ErrorMessage="作者不能为空")]
		public string Author { get; set; }



		/// <summary>
		/// 简介
		/// </summary>
		[MaxLength(50, ErrorMessage="简介超出最大长度")]
		[MinLength(1, ErrorMessage="简介小于最小长度")]
		[Required(ErrorMessage="简介不能为空")]
		public string Intro { get; set; }



		/// <summary>
		/// 购买链接
		/// </summary>
		public string PriceUrl { get; set; }



		/// <summary>
		/// 图片
		/// </summary>
		public string ImgUrl { get; set; }




    }
}