using Microsoft.EntityFrameworkCore;
using PortalCustomerManagmentChallangeEntity.Concrete;

namespace PortalCustomerManagmentChallangeDataAccess.Concrete.EntityFramework.Context
{
    public class SimpleContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=TestDb;Integrated Security=True");
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-F554KA6\SQLEXPRESS;Database=DemoDb;Integrated Security=true");
            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Database=TestDatabase;Integrated Security=true");
        }

        public DbSet<User>? Users { get; set; }
    }
}
