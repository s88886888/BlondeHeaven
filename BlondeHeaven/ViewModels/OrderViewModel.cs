using BlondeHeaven.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ShopKeepeid { get; set; }
        public int UserId { get; set; }

        public int CommodityId { get; set; }


    }
}
