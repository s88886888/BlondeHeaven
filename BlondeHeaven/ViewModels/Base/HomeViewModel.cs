using BlondeHeaven.Models;
using System;
using System.Collections.Generic;


namespace BlondeHeaven.ViewModels
{
    public class HomeViewModel
    {
        public List<Noodle> Noodles { get; set; }

        public List<Feedback> Feedbacks { get; set; }
        public List<ShopKeeper> ShopKeepers { get; set; }
    }
}
