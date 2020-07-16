using BlondeHeaven.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text;

namespace BlondeHeaven.Model
{
    public class Commodity : BaseEntity
    {
        /// <summary>
        /// 商品表
        /// </summary>

        
        ///地址
        public string Address { get; set; }
        ///创建预约时间
        public DateTime CreateCommodity { get; set; }
        /// <summary>
        /// 商品价格
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 照片
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// 商店Id
        /// </summary>
        [ForeignKey(nameof(ShopKeeper))]       
        public int ShopKeeperId { get; set; }
        /// <summary>
        /// 店铺名字
        /// </summary>
        public string ShopKeeperName { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public string ApplicationUserId { get; set; }



    }
}
