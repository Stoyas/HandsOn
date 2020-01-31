using System.Collections.Generic;
using PMM.DataAccess.Repositories;
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
    public class MovieService : IMovieService
    {
        private IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie GetMovieInfo(int id)
        {
            return _movieRepository.GetMovieInfo(id);
        }

        public IEnumerable<Movie> GetMovies()
        {
            throw new System.NotImplementedException();
        }

        public void CreateMovie(Movie movie)
        {
            _movieRepository.CreatedMovie(movie);
        }

        public void UpdateMovieInfo(Movie movie)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteMovie(int id)
        {
            _movieRepository.RemoveMovie(id);
        }

        public StaffDto GetStaff()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Staff> GetStaffs()
        {
            throw new System.NotImplementedException();
        }
    }
}