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
            CreateMap<Review,ReviewDto>();
            CreateMap<Reviewer,ReviewerDto>();
        }
    }
}
