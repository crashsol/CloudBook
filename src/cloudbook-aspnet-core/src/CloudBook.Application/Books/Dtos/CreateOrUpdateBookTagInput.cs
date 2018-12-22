

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CloudBook.Books;

namespace CloudBook.Books.Dtos
{
    public class CreateOrUpdateBookTagInput
    {
        [Required]
        public BookTagEditDto BookTag { get; set; }

    }
}