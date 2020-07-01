using BlondeHeaven.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlondeHeaven.Models
{
   public class User: BaseEntity
    { 
        public int Age { get; set; }

        public bool Sex { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        [Required, StringLength(40)]
        public string Phone { get; set; }
        /// <summary>
        /// 照片
        /// </summary>
       [StringLength(5000)]
        public string Photo { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        [Required, StringLength(50)]
        public string PassWrod { get; set; }
        public List<Comment>  Comments { get; set; }
        public List<Commodity> Commoditys { get; set; }
        public List<Order> Orders { get; set; }
    }
}
