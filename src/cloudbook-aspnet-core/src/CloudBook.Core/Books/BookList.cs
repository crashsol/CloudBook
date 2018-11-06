using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities.Auditing;

namespace CloudBook.Books
{
    /// <summary>
    /// 书单
    /// </summary>
    public class BookList:CreationAuditedEntity<long>
    {
        /// <summary>
        /// 书单名称
        /// </summary>
        public string Name { get; set; }

        public string Intro { get; set; } 
    }
}
