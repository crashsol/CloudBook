using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities.Auditing;

namespace CloudBook.Books
{
   public  class BookTag:CreationAuditedEntity<long>
    {
        public string Name { get; set; }
    }
}
