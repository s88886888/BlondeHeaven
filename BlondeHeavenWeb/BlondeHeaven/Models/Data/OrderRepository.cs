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
        private readonly AppDbContext _db;

        public OrderRepository(AppDbContext m_context)
        {
            _db = m_context;
        }

        public Order Add(Order model)
        {
            _db.Orders.Add(model);
            _db.SaveChanges();
            return model;
        }

        public Order Edit(Order model)
        {
            _db.Entry(model).State = EntityState.Modified;
            _db.SaveChanges();
            return model;
        }

        public List<Order> GetAllOrder()
        {
            var Orders = _db.Orders.Where(m => m.IsRemo == false).ToList();
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
        public Order GetEndOrderById(int id)
        {

            return _db.Orders.FirstOrDefault(m => m.Id == id && m.IsRemo == true);
        }

        public List<Order> GetOrderByUserId(string id)
        {

            var shop = GetAllOrder().Where(m => m.ApplicationUserId == id).ToList();
            return shop;
        }
        public List<Order> GetEndOrderByUserId(string id)
        {

            return _db.Orders.Where(m => m.ApplicationUserId == id && m.IsRemo == true).ToList();
        }
        public List<Order> GetOrderByCommodityId(int id)
        {

            var shop = GetAllOrder().Where(m => m.CommodityId == id).ToList();
            return shop;
        }
        public List<Order> GetEndOrderByCommodityId(int id)
        {

            return _db.Orders.Where(m => m.CommodityId == id && m.IsRemo == true).ToList();

        }

        public List<Order> GetOrderByListId(int id)
        {
            var shop = GetAllOrder().Where(m => m.Id == id).ToList();
            return shop;
        }
        public List<Order> GetEndOrderByListId(int id)
        {
            return _db.Orders.Where(m => m.Id == id && m.IsRemo == true).ToList();

        }

        public void Remo(int id)
        {
            var shop = GetOrderById(id);
            shop.IsRemo = true;
            _db.Entry(shop).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
