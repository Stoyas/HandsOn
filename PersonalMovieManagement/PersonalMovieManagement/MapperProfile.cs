using AutoMapper;
using PMM.DTO.Movies;
using PMM.ORM.Models;

namespace PersonalMovieManagement
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<Movie, MovieDto>().ReverseMap();
        }
    }
}