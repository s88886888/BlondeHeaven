using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models
{
    /// <summary>
    /// 面条实体
    /// </summary>
    public class Noodle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        private decimal m_price;
        public decimal Price
        {
            get { return Math.Round(m_price, 2); }
            set { m_price = value; }
        }

        public string ImageURL { get; set; }
        public bool IsInStock { get; set; }
    }
}
