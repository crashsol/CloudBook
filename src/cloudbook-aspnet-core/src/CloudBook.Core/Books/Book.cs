using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBook.Books
{
    /// <summary>
    /// 书籍类
    /// </summary>
    public class Book:CreationAuditedEntity<long>
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
