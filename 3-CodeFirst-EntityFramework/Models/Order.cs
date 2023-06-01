using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _3_CodeFirst_EntityFramework.Models.Order;

namespace _3_CodeFirst_EntityFramework.Models
{
    [Table("Orders")]
    public class Order
    {
        public Order()
        {
            Products = new List<Product>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderState State { get; set; }
        public int CustomerId { get; set; }

        [NotMapped]
        public string OrderInfo
        {
            get
            {
                return $"{Name} - {OrderDate.ToShortDateString()} ({GetOrderStateString()})";
            }
        }
        public virtual List<Product> Products { get; set; }
        public virtual Customer Customer { get; set; }

        public string GetOrderStateString()
        {
            switch (State)
            {
                case OrderState.All:
                    return "";
                case OrderState.Reserved:
                    return "Reserved";
                case OrderState.Shipped:
                    return "Shipped";
                case OrderState.Delivered:
                    return "Delivered";
                default:
                    return "";
            }
        }
        public enum OrderState
        {
            All=-1,
            Reserved=0,
            Shipped=1,
            Delivered=2
        }

    }


}
