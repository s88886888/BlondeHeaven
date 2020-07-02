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
        /// 

        /////商品名字
        //public string Name { get; set; }

        ///创建商品时间
        public DateTime CreateCommodity { get; set; }
        /// <summary>
        /// 商品价格
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 照片
        /// </summary>
        public string Photo { get; set; }


        [ForeignKey(nameof(ShopKeeper))]
        public int ShopKeeperId { get; set; }

    }
}
