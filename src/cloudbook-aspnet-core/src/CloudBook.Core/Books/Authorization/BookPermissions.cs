using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBook.Books.Authorization
{
    /// <summary>
    /// 书籍管理权限定义
    /// </summary>
    public static class BookPermissions
    {

        public const string BookManager = "Pages.BookManager";
        public const string Query = "Pages.Book.Query";
        public const string Create = "Pages.Book.Create";
        public const string Edit = "Pages.Book.Edit";
        public const string Delete = "Pages.Book.Delete";
        public const string BatchDelete = "Pages.Book.BatchDelete";
      
    }
}
