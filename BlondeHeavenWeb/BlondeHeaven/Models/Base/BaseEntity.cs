using System;
using System.Collections.Generic;
using System.Text;

namespace BlondeHeaven.Models
{
    public class BaseEntity
    {
        /// <summary>
        /// 基础数据
        /// </summary>
        /// 
        public int Id { get; set; }
        /// <summary>
        /// 基础名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 阴影属性
        /// </summary>
        public bool IsRemo { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime DateTime { get; set; } = DateTime.Now;


    }
}
