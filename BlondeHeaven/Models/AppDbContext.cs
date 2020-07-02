using BlondeHeaven.Model;
using BlondeHeaven.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<ShopKeeper> ShopKeepers { get; set; }

        public DbSet<User> Uesrs { get; set; }
        public DbSet<UserShop> UserShops { get; set; }
        public DbSet<Waiter> Waiters { get; set; }
        public DbSet<Ranking> Rankings { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Commodity> Commoditys { get; set; }



    }
}
