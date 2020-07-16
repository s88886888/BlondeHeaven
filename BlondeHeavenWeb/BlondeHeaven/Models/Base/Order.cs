using BlondeHeaven.Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace BlondeHeaven.Models
{
    public class Order : BaseEntity
    {
        /// <summary>
        ///地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 预约时间
        /// </summary>
        public DateTime CreateCommodity { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// 店铺名字
        /// </summary>
        public string ShopKeeperName { get; set; }
        /// <summary>
        /// 商品名字
        /// </summary>
        public string CommodityName { get; set; }
        /// <summary>
        /// 店铺Id
        /// </summary>
        [ForeignKey(nameof(ShopKeeper))]
        public int ShopKeeperId { get; set; }
        /// <summary>
        /// 商品Id
        /// </summary>
        public int CommodityId { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public string ApplicationUserId { get; set; }
    }
}
