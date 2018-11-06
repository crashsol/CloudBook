using System;
using System.Collections.Generic;
using System.Text;
using Abp.Runtime.Validation;
using CloudBook.Dtos;

namespace CloudBook.Books.Dtos
{
    public class GetBooksInputDto : PagedAndFilteredInputDto,IShouldNormalize
    {
        public void Normalize()
        {
            if(string.IsNullOrWhiteSpace(FilterText))
            {
                Sorting = "id";
            }
        }
    }
}
