using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [ForeignKey("Roles")]
        public int RoleId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public String UserName { get; set; }

        [Column(TypeName="varchar")]
        [StringLength(50)]
        public String Password { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public String Name { get; set; }
        [Required(ErrorMessage="Please enter contactno ")]
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public String contactno { get; set; }

        [Column(TypeName ="varchar")]
        [StringLength(250)]
        public String Address { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

     

        public virtual ICollection<Roles> Roles { get; set; }
        public Users()
        {
            CreatedDate = DateTime.Now;
            Roles = new HashSet<Roles>();
        }

    }
}
