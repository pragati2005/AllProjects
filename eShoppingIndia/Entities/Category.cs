using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category
    {
        [Key]
        public int PARENTID { get; set; }
        [Column(TypeName="varchar")]
        [StringLength(50)]
        [Required]
        public String NAME { get; set; }
        public DateTime CREATEDDATE { get; set; }

        public DateTime? UPDATEDDATE { get; set; }

        //[DataType(DataType.Upload)]
        //[Display(Name = "Upload File")]
        //[Required(ErrorMessage = "Please choose file to upload.")]
        //public string IMAGE { get; set; }

        public String IMAGEURL { get; set; }

        public int CHILDID { get; set; }
        String strr;
       
        public virtual ICollection<Product> products { get; set; }
        public Category()
        {
            CREATEDDATE = DateTime.Now;
            products = new HashSet<Product>();
            
           

        }
       
    }
}
