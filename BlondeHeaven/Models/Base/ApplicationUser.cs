using BlondeHeaven.Model;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlondeHeaven.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Comment> Comments { get; set; }
        public List<Commodity> Commoditys { get; set; }

        public List<ShopKeeper> shopKeepers { get; set; }
        public List<Order> Orders { get; set; }
    }
}
