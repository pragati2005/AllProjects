using Entities;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstraction
{
   public interface IAuthenticateRepository : IRepository<Users>
    {
       UserViewModel ValidateUser(LoginViewModel logindetails);
    }
}
