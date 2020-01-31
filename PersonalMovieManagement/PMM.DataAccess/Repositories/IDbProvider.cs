using System.Data;
using Dapper;

namespace PMM.DataAccess.Repositories
{
    public interface IDbProvider
    {
        void OpenConnection(IDbConnection connection);
        void CloseConnection(IDbConnection connection);
        T GetById<T>(string sql, int id);
        void Create<T>(string sql, object param);
        void Remove<T>(string sql, int id);
    }

    public class DbProvider : IDbProvider
    {
        private IDbConnection _dbConnection;

        public DbProvider(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void OpenConnection(IDbConnection connection)
        {
            if (null != connection && connection.State != ConnectionState.Open)
                connection.Open();
        }

        public void CloseConnection(IDbConnection connection)
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public T GetById<T>(string sql, int id)
        {
            OpenConnection(_dbConnection);
            var result = _dbConnection.QueryFirst<T>(sql, new { id = id });
            CloseConnection(_dbConnection);
            return result;
        }

        public void Create<T>(string sql, object param)
        {
            OpenConnection(_dbConnection);
            _dbConnection.Query(sql, param);
            CloseConnection(_dbConnection);
        }

        public void Remove<T>(string sql, int id)
        {
            OpenConnection(_dbConnection);
            _dbConnection.Query(sql, new{id = id});
            CloseConnection(_dbConnection);
        }
    }
}