using AutoMapper;
using WebApiPractice.Dto;
using WebApiPractice.Modals;

namespace WebApiPractice.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() { 
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}
