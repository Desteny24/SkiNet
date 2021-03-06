using API.Dto;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Product, ProductResponseDto>()
                .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
                .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.Name))
                .ForMember(d => d.PictureUrl, o => o.MapFrom<ProductUrlResolver>());
        }
    }
}