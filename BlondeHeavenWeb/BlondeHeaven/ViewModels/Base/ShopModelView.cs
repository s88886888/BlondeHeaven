using BlondeHeaven.Model;
using BlondeHeaven.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.ViewModels
{
    public class ShopModelView
    {
        public List<ShopKeeper> ShopKeepers { get; set; }

        public List<Commodity> Commoditys { get; set; }
    }
}
