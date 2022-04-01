using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
   public class LoginViewModel
    {
        [Required (ErrorMessage="Enter Username")]
        public String Username { get; set; }
        [Required (ErrorMessage ="Enter Password")]
        public String Password { get; set; }

        public String Roles { get; set; }
    }
}
