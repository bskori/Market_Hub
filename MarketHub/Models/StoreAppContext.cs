using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    public class StoreAppContext:DbContext
    {
        public StoreAppContext(DbContextOptions<StoreAppContext> opt):base(opt)
        { }

        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<DispatchAgency> DispatchAgencies { get; set; }
        public DbSet<UserOrder> UserOrders { get; set; }
        public DbSet<UserOrderDet> UserOrderDets { get; set; }
        public DbSet<UserOrderdDispatch> UserOrderdDispatches { get; set; }
        public DbSet<Cart> Carts { get; set; }
    }
}
