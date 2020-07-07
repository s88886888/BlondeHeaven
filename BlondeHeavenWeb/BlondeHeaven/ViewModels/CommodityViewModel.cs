using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.ViewModels
{
    public class CommodityViewModel
    {
        public DateTime CreateCommodity { get; set; }
        /// <summary>
        /// 商品价格
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 照片
        /// </summary>
        public string Photo { get; set; }

        public string Name { get; set; }

        public int Id { get; set; }

        public int ShopKeeperId { get; set; }
        public string ShopKeeperName { get; set; }
        public string Address { get; set; }
        public string ApplicationUserId { get; set; }

    }
}
