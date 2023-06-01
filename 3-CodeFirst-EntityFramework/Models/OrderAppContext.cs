using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst_EntityFramework.Models
{
    public class OrderAppContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        //Connnection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Ayarlar yapılmamışsa
            if (optionsBuilder.IsConfigured  == false)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=OrderAppDB;Trusted_Connection=True");
                optionsBuilder.UseLazyLoadingProxies();
            }
        }
    }
}
