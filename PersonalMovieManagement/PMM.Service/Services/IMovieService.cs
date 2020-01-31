using System.Collections.Generic;
using PMM.DTO.Movies;
using PMM.ORM.Models;

namespace PMM.Service.Services
{
    public interface IMovieService
    {
        Movie GetMovieInfo(int id);
        IEnumerable<Movie> GetMovies();
        void CreateMovie(Movie movie);
        void UpdateMovieInfo(Movie movie);
        void DeleteMovie(int id);
        StaffDto GetStaff();
        IEnumerable<Staff> GetStaffs();
    }
}