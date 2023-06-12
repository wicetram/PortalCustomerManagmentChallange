using Microsoft.EntityFrameworkCore;
using PortalCustomerManagmentChallangeEntity.Concrete;

namespace PortalCustomerManagmentChallangeDataAccess.Concrete.EntityFramework.Context
{
    public class SimpleContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=TestDb;Integrated Security=True");
        }

        public DbSet<User>? Users { get; set; }
    }
}
