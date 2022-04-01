using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstraction
{
   public  interface IUnitOfWork
    {
        IAuthenticateRepository AuthenticateRepository { get; }
        IRepository<Category> CategoryRepository { get; }
        IRepository<Product> ProductRepository { get; }

        IRepository<Roles> RolesRepository { get; }
    }
}
