using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3_CodeFirst_EntityFramework.Models
{
    [Table("Categories")]
    public class Category
    {
        public Category()
        {
            Products =new List<Product>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
