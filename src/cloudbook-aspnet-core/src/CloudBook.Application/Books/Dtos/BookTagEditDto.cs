
using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using CloudBook.Books;

namespace  CloudBook.Books.Dtos
{
    public class BookTagEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public long? Id { get; set; }         


        
		/// <summary>
		/// 标签名称
		/// </summary>
		[MaxLength(50, ErrorMessage="标签名称超出最大长度")]
		[MinLength(3, ErrorMessage="标签名称小于最小长度")]
		[Required(ErrorMessage="标签名称不能为空")]
		public string Name { get; set; }




    }
}