using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CloudBook.Books.Dtos
{
    public class CreateOrUpdateBookInput
    {

        [Required]
        public BookEditDto Book { get; set; }
    }
}
