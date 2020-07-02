using BlondeHeaven.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlondeHeaven.Models
{
    public class ShopKeeper:BaseEntity
    {
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 照片
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public int Sales { get; set; }

        [ForeignKey(nameof(UserShop))]
        public int UserShopId { get; set; }


        public List<Comment>  Comments { get; set; }
        public List<Commodity> Commoditys { get; set; }
        public List<Ranking> Rankings { get; set; }
        public List<Order> Orders { get; set; }
    }
}
