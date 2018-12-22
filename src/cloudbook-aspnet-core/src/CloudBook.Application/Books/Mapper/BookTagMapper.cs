
using AutoMapper;
using CloudBook.Books;
using CloudBook.Books.Dtos;

namespace CloudBook.Books.Mapper
{

	/// <summary>
    /// 配置BookTag的AutoMapper
    /// </summary>
	internal static class BookTagMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <BookTag,BookTagListDto>();
            configuration.CreateMap <BookTagListDto,BookTag>();

            configuration.CreateMap <BookTagEditDto,BookTag>();
            configuration.CreateMap <BookTag,BookTagEditDto>();

        }
	}
}
