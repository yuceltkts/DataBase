using MyDataBase.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataBase.DAL.ORM.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server = 317.database.windows.net;Database = MyDataBase; uid=sa;pwd =1234";
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Kisiler> Kisilers { get; set; }
       // public DbSet<Order> Orders { get; set; }
    }   //public DbSet<Customer> Customers { get; set; }
       // public DbSet <Shipper> Shippers { get; set; }
       // public DbSet<OrderDetail> OrderDetails { get; set; }

    
}


