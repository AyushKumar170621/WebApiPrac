using AutoMapper;
using WebApiPractice.Dto;
using WebApiPractice.Modals;

namespace WebApiPractice.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() { 
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoriesDto>();
            CreateMap<CategoriesDto, Category>();
            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();
            CreateMap<Owner,OwnerDto>();
            CreateMap<OwnerDto, Owner>();
            CreateMap<Review,ReviewDto>();
            CreateMap<ReviewDto, Review>();
            CreateMap<Reviewer,ReviewerDto>();
            CreateMap<ReviewerDto,Reviewer>();
        }
    }
}
