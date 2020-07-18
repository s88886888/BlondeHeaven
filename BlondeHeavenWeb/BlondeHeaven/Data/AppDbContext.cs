using BlondeHeaven.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlondeHeaven.ViewModels;

namespace BlondeHeaven.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<ShopKeeper> ShopKeepers { get; set; }

        public DbSet<ApplicationUser> Uesrs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Commodity> Commoditys { get; set; }
        public DbSet<BlondeHeaven.ViewModels.CommodityViewModel> CommodityViewModel { get; set; }
    }
}
