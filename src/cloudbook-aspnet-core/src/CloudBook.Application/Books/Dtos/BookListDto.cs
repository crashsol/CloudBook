using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBook.Books.Dtos
{
    /// <summary>
    /// 书籍列表显示Dto
    /// </summary>
    public class BookListDto:Entity<long>
    {
        /// <summary>
        /// 书名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Intro { get; set; }

        /// <summary>
        /// 购买链接
        /// </summary>
        public string PriceUrl { get; set; }
    }
}
