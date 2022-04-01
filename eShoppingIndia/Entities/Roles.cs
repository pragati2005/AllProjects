using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }
        [Column(TypeName="varchar")]
        [StringLength(50)]
        [Required]
        public String Name { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(250)]
        [Required]

        
        public String Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
        public virtual ICollection<Users> Users { get; set; }
        public Roles()
        {
            CreatedDate = DateTime.Now;
            Users = new HashSet<Users>();
        }
    }
}
