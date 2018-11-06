using AutoMapper;
using CloudBook.Books.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBook.Books.Mapper
{
    /// <summary>
    /// 添加对象映射关系
    /// </summary>
    internal class BookMapper
    {

        public static void CreateMappers(IMapperConfigurationExpression mapperConfiguration)
        {
            mapperConfiguration.CreateMap<Book, BookListDto>();

        }
    }
}
