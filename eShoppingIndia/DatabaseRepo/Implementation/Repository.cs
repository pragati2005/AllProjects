using Microsoft.EntityFrameworkCore;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected AppDbContext db;
        public Repository(AppDbContext _db)
        {
            db = _db;
        }
        public async Task<int> Add(TEntity entity)
        {
          await  db.Set<TEntity>().AddAsync(entity);
           var result= await db.SaveChangesAsync();
            return result;
        }

        public async  Task DeleteById(object Id)
        {
            var entity = await db.Set<TEntity>().FindAsync(Id);
            if(entity!=null)
            {
                db.Set<TEntity>().Remove(entity);
            }
            
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            
             return await db.Set<TEntity>().ToListAsync();
            
        }

        public async Task<TEntity> GetById(object Id)
        {
            var entity = await db.Set<TEntity>().FindAsync(Id);
            return entity;
        }

        public async Task<int> Update(TEntity entity)
        {
            db.Set<TEntity>().Update(entity);
            return await db.SaveChangesAsync();
        }
    }
}
