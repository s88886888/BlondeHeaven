using BlondeHeaven.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.ViewModels
{
    public class OrderViewModel
    {

        public string Address { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ShopKeepeid { get; set; }
        public string UserId { get; set; }

        public string Phone { get; set; }
        public int CommodityId { get; set; }

        public string Remarks { get; set; }

        public string ShopKeeperName { get; set; }

        public string CommodityName { get; set; }

        public DateTime CreateCommodity { get; set; }

    }
}
