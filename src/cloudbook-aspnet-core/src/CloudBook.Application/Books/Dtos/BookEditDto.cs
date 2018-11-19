using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBook.Books.Dtos
{
    /// <summary>
    /// 书籍编辑Dto
    /// </summary>
    public class BookEditDto
    {

        /// <summary>
        /// 
        /// </summary>
        public long? Id { get; set; }

        /// <summary>
        /// 书名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Intro { get; set; }

        /// <summary>
        /// 购买链接
        /// </summary>
        public string PriceUrl { get; set; }

        /// <summary>
        /// 书籍封面图片
        /// </summary>
        public string ImgUrl { get; set; }

    }
}
