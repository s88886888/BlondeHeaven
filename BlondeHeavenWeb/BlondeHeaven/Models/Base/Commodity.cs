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
        /// 详细信息
        /// </summary>
        public string Details { get; set; }
        /// <summary>
        /// 销量
        /// </summary>
        public int Sales { get; set; }



        [ForeignKey(nameof(ShopKeeper))]
        public int ShopKeeperId { get; set; }

        public string ShopKeeperName { get; set; }
        public string ApplicationUserId { get; set; }



    }
}
