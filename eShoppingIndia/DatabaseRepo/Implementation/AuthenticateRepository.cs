using Entities;
using Entities.ViewModels;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
  public  class AuthenticateRepository : Repository<Users>, IAuthenticateRepository
    {
       
        public AuthenticateRepository(AppDbContext _context) : base(_context)
        {
        }
        private AppDbContext context
        {
            get
            {
                return db as AppDbContext;
            }
        }

        public UserViewModel ValidateUser(LoginViewModel logindetails)
        {
            Users data = context.Users.Where(u => u.UserName == logindetails.Username && u.Password == logindetails.Password).FirstOrDefault();
            if(data != null)
            {
                var obj = new UserViewModel
                {
                    UserId = data.UserId,
                    UserName = data.UserName,
                    password = data.Password,
                    contactno = data.contactno,
                    Roles = data.Roles.Select(r => r.Name).ToArray()

                };
            return obj;
            }
            else
            {
                return null;
            }
        }
    }
}
