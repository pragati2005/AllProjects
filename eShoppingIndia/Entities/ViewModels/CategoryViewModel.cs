using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
   public class CategoryViewModel
    {
       
        
        public String NAME { get; set; }
        public DateTime CREATEDDATE { get; set; }

        public DateTime? UPDATEDDATE { get; set; }

      public IFormFile File { get; set; }

        public String CHILDID { get; set; }
    

        public virtual ICollection<Product> products { get; set; }
        public CategoryViewModel()
        {
            CREATEDDATE = DateTime.Now;
            products = new HashSet<Product>();



        }

    }
}
