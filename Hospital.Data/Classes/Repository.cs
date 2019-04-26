using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hospital
{
    class Repository<T> : IRepository<T> where T : IEntity
    {
        private readonly IList<T> _set = new List<T>();
        public void Create (T entity)
        {
            _set.Add(entity);
        }
        public void Delete(T entity)
        {
            _set.Remove(entity);
        }
        public void GetById(long id)
        {
            return _set.FirstOrDefault(e => e.Id == id);
        }
        public void Update(T entity)
        {
        }

        private IEnumerable<T> GetAll()
        {
            return _set;
        }
    }
}
