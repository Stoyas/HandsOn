using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMM.DataAccess.Repositories
{
    public interface IBaseRepository<T>: IDisposable
    {
        int Add(T entity);
        int Add(IEnumerable<T> entities);
        void Remove(T entity);
        void Update(T entity);
        T GetById(int it, string sql);
    }

    public class BaseRepository<T> : IBaseRepository<T>
    {
        private IDbProvider _db;
        public BaseRepository(IDbProvider db)
        {
            _db = db;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Add(T entity)
        {
            throw new NotImplementedException();
        }

        public int Add(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id, string sql)
        {
            return _db.GetById<T>(sql, id);
        }
    }
    
}