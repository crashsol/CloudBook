

using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using CloudBook.Books;


namespace CloudBook.Books.DomainService
{
    public interface IBookManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitBook();



		 
      
         

    }
}
