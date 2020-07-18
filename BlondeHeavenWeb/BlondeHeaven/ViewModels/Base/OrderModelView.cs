using BlondeHeaven.Model;
using BlondeHeaven.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.ViewModels.Base
{
    public class OrderModelView
    {
        public List<Order> Orders { get; set; }
        public List<Commodity> Commoditys { get; set; }

        //public List<OrderModelView> Model = new List<OrderModelView>();

    }
}
