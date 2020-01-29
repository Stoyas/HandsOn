using System.Collections.Generic;
using PMM.DTO.Movies;

namespace PMM.Service.Services
{
    public interface IMovieService
    {
        MovieDto GetMovieInfo(int id);
        IEnumerable<MovieDto> GetMovies();
        void CreateMovie(MovieDto movie);
        void UpdateMovieInfo(MovieDto movie);
        void DeleteMovie(int id);
        StaffDto GetStaff();
        IEnumerable<StaffDto> GetStaffs();
    }
}