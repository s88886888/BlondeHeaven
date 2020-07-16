using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.ViewModels
{
    public class ShopViewModel
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public string Name { get; set; }
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
    }
}
