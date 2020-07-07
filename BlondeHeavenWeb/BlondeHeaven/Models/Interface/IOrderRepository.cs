﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models.Interface
{
  public  interface IOrderRepository
    {
        List<Order> GetAllShopKeepers();

        Order GetOrderById(int id);
        List<Order> GetOrderByUserId(int id);
        List<Order> GetOrderByShopId(int id);
        List<Order> GetOrderByondeId(string id);
        Order Add(Order model);
        Order Edit(Order model);
        void Remo(int id);



    }
}
