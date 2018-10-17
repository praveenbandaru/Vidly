using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public static void Run()
        {
            Mapper.Initialize(a => a.AddProfile<MappingProfile>());
        }

        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap().ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<Movie, MovieDto>().ReverseMap().ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<MembershipType, MembershipTypeDto>().ReverseMap().ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<Genre, GenreDto>().ReverseMap().ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}