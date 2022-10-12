using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShooping.ProductAPI.Model;
using AutoMapper;

namespace GeekShopping.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<ProductVO, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
