using System.Collections.Generic;
using PMM.DTO.Movies;
using PMM.ORM.Models;

namespace PMM.DataAccess.Repositories
{
    public interface IMovieRepository : IRepository
    {
        Movie GetMovieInfo(int id);
        IEnumerable<Movie> GetMoviesInfo();
        void RemoveMovie(int id);
        void UpdateMovie(MovieDto movie);
        void CreatedMovie(Movie movie);
    }

    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        private string getSql = "SELECT * FROM Movie WHERE MovieId = @id";
        private string removeSql = "REMOVE From Movie WHERE MovieId = @id";

        private string createSql =
            "INSERT INTO Movie ([MovieName], [FileLocation], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate]) VALUES(@MovieName, @FileLocation, 1,GETDATE(),1, GETDATE())";

        private IDbProvider _db;

        public MovieRepository(IDbProvider db) : base(db)
        {
            _db = db;
        }

        public Movie GetMovieInfo(int id)
        {
            return _db.GetById<Movie>(getSql, id);
        }

        public IEnumerable<Movie> GetMoviesInfo()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveMovie(int id)
        {
            _db.Remove<Movie>(removeSql, id);
        }

        public void UpdateMovie(MovieDto movie)
        {
            throw new System.NotImplementedException();
        }

        public void CreatedMovie(Movie movie)
        {
            _db.Create<Movie>(createSql, new {MovieName = movie.MovieName, FileLocation = movie.FileLocation});
        }
    }
}