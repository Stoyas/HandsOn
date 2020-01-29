using System.Collections.Generic;
using PMM.DataAccess.Repositories;
using PMM.DTO.Movies;

namespace PMM.Service.Services
{
    public class MovieService : IMovieService
    {
        private IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public MovieDto GetMovieInfo(int id)
        {
            return _movieRepository.GetMovieInfo(id);
        }

        public IEnumerable<MovieDto> GetMovies()
        {
            throw new System.NotImplementedException();
        }

        public void CreateMovie(MovieDto movie)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateMovieInfo(MovieDto movie)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteMovie(int id)
        {
            throw new System.NotImplementedException();
        }

        public StaffDto GetStaff()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<StaffDto> GetStaffs()
        {
            throw new System.NotImplementedException();
        }
    }
}