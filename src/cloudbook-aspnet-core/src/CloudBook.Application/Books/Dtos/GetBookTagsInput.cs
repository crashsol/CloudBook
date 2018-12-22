
using Abp.Runtime.Validation;
using CloudBook.Dtos;
using CloudBook.Books;

namespace CloudBook.Books.Dtos
{
    public class GetBookTagsInput : PagedSortedAndFilteredInputDto, IShouldNormalize
    {

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

    }
}
