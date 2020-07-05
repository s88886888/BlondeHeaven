using BlondeHeaven.Models.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _m_context;

        public OrderRepository(AppDbContext m_context)
        {
            _m_context = m_context;
        }

        public Order Add(Order model)
        {
            _m_context.Orders.Add(model);
            _m_context.SaveChanges();
            return model;
        }

        public Order Edit(Order model)
        {
            _m_context.Entry(model).State = EntityState.Modified;
            return model;
        }

        public List<Order> GetAllOrder()
        {
            var Orders = _m_context.Orders.Where(m => m.IsRemo == false).ToList();
            return Orders;
        }

        public List<Order> GetAllShopKeepers()
        {
            throw new NotImplementedException();
        }

        public Order GetOrderById(int id)
        {

            return GetAllOrder().FirstOrDefault(m => m.Id == id);
        }

        public List<Order> GetOrderByondeId(string id)
        {

            var shop = GetAllOrder().Where(m => m.ApplicationUserId == id).ToList();
            return shop;
        }

        public void Remo(int id)
        {
            var shop = GetOrderById(id);
            shop.IsRemo = true; 
            _m_context.Entry(shop).State = EntityState.Modified;
            _m_context.SaveChanges();
        }
    }
}
