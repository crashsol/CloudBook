

using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using CloudBook.Books;


namespace CloudBook.Books.DomainService
{
    public interface IBookTagManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitBookTag();



		 
      
         

    }
}
