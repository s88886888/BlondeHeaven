using BlondeHeaven.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlondeHeaven.Models
{
    public class ShopKeeper : BaseEntity
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
        /// 销量
        /// </summary>
        public int Sales { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        [ForeignKey(nameof(ApplicationUser))]
        public string ApplicationUserId { get; set; }


        public List<Comment> Comments { get; set; }
        public List<Commodity> Commoditys { get; set; }
        public List<Order> Orders { get; set; }
    }
}
