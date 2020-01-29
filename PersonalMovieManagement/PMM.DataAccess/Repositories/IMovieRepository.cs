using System.Collections.Generic;
using PMM.DTO.Movies;
using PMM.ORM.Models;

namespace PMM.DataAccess.Repositories
{
    public interface IMovieRepository : IRepository
    {
        MovieDto GetMovieInfo(int id);
        IEnumerable<MovieDto> GetMoviesInfo();
        void RemoveMovie(int id);
        void UpdateMovie(MovieDto movie);
    }

    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        private string sql = "SELECT * FROM Movie WHERE MovieId = @id";
        private IDbProvider _db;

        public MovieRepository(IDbProvider db) : base(db)
        {
            _db = db;
        }

        public MovieDto GetMovieInfo(int id)
        {
            return _db.GetById<MovieDto>(id, sql);
        }

        public IEnumerable<MovieDto> GetMoviesInfo()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveMovie(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateMovie(MovieDto movie)
        {
            throw new System.NotImplementedException();
        }
    }
}