using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstraction
{
    public interface IRepository<TEntity> where TEntity:class
    {
        public Task<IEnumerable<TEntity>> GetAll();
        public Task<TEntity> GetById(object Id);
        public Task<int> Add(TEntity entity);

        public Task<int> Update(TEntity entity);
        public Task DeleteById(object Id);
    }
}
