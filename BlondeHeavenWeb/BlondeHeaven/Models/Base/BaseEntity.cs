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
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsRemo { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;


    }
}
