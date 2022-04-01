using Entities;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        AppDbContext db;
        //public UnitOfWork()
        //{ }
        public UnitOfWork(AppDbContext _db)
        {
            this.db = _db;
        }
        public IAuthenticateRepository _AuthenticateRepository;
        public IRepository<Category> _CategoryRepository;
        public IRepository<Product> _ProductRepository;
        public IRepository<Roles> _RolesRepos;


        public IRepository<Category> CategoryRepository
        {
            get
            {
                if (_CategoryRepository == null)
                    _CategoryRepository = new Repository<Category>(db);
                return _CategoryRepository;

            }
        }

        public IRepository<Roles> RolesRepository
        {
            get
            {
                if (_RolesRepos == null)
                    _RolesRepos = new Repository<Roles>(db);
                return _RolesRepos;

            }
        }

        public IRepository<Product> ProductRepository
        {
            get
            {
                if (_ProductRepository == null)
                    _ProductRepository = new Repository<Product>(db);
                return _ProductRepository;

            }
        }

        public IAuthenticateRepository AuthenticateRepository
        {
            get
            {
                if (_AuthenticateRepository == null)
                    _AuthenticateRepository = new AuthenticateRepository(db);
                return _AuthenticateRepository;
            }
        }
    }
}
