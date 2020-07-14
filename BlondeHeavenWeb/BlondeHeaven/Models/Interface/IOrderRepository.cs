using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models.Interface
{
  public  interface IOrderRepository
    {

        /// <summary>
        /// 查询所有的订单
        /// </summary>
        /// <returns></returns>
        List<Order> GetAllOrder();

        /// <summary>
        /// 根据订单Id进行查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Order GetOrderById(int id);
        /// <summary>
        /// 根据订单id进行查询（集合）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Order> GetOrderByListId(int id);
        List<Order> GetEndOrderByListId(int id);
        /// <summary>
        /// 根据商品Id进行查询订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Order> GetOrderByCommodityId(int id);
        List<Order> GetEndOrderByCommodityId(int id);
        /// <summary>
        /// 根据用户Id进行查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Order> GetOrderByUserId(string id);
        /// <summary>
        /// 根据用户Id查询已完成的订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Order> GetEndOrderByUserId(string id);

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Order Add(Order model);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Order Edit(Order model);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        void Remo(int id);



    }
}
