

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CloudBook.Books;

namespace CloudBook.Books.Dtos
{
    public class CreateOrUpdateBookInput
    {
        [Required]
        public BookEditDto Book { get; set; }

    }
}