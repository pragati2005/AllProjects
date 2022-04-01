using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public String UserName { get; set; }
        public String password { get; set; }

        public String ConfirmPassword { get; set; }

        public String contactno { get; set; }
        public String[] Roles { get; set; }
    }
}
