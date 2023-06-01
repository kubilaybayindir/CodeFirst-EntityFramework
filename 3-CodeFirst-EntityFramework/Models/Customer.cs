using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3_CodeFirst_EntityFramework.Models
{
    [Table("Customers")]
    public class Customer
    {
        public Customer()
        {
            Orders = new List<Order>();
        }

        [Key]
        public int Id { get; set; }
        [Required,StringLength(50)]
        public string? FirstName  { get; set; }
        [Required, StringLength(50)]
        public string? LastName { get; set; }
        [EmailAddress, StringLength(60)]
        public string Email { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }

        [NotMapped]
        public string FullName 
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public virtual List<Order> Orders { get; set; }


    }


}
