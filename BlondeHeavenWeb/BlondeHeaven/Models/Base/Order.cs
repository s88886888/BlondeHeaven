using BlondeHeaven.Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace BlondeHeaven.Models
{
    public class Order : BaseEntity
    {

        public string Address { get; set; }
        public double Price { get; set; }

        public string Phone { get; set; }


        public DateTime CreateCommodity { get; set; }
        public string Remarks { get; set; }

        public string ShopKeeperName { get; set; }

        public string CommodityName { get; set; }

        [ForeignKey(nameof(ShopKeeper))]
        public int ShopKeeperId { get; set; }

        public int CommodityId { get; set; }

        public string ApplicationUserId { get; set; }
    }
}
