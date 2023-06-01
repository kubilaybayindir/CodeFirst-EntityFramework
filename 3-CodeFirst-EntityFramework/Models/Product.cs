using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3_CodeFirst_EntityFramework.Models
{
    [Table("Products")]
    public class Product
    {
        public Product()
        {
            Orders = new List<Order>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }
        public bool IsSale { get; set; }
        public int CategoryId { get; set; } //Foreign Hey

        public virtual Category Category { get; set; } //Navigation property

        public virtual List<Order> Orders { get; set; }

    }
}
