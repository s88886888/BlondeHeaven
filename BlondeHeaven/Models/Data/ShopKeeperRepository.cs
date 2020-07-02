using BlondeHeaven.Models.Interface;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models
{
    public class ShopKeeperRepository : IShopKeeperRepository
    {
        private readonly AppDbContext _m_context;

        public ShopKeeperRepository(AppDbContext m_context)
        {
            _m_context = m_context;
        }

        public ShopKeeper AddAsync(ShopKeeper model)
        {
            _m_context.ShopKeepers.Add(model);
            _m_context.SaveChanges();
            return model;
        }

        public ShopKeeper EditAsync(ShopKeeper model)
        {
            _m_context.Entry(model).State = EntityState.Modified;
            _m_context.SaveChanges();
            return model;
        }

        public List<ShopKeeper> GetAllShopKeepers()
        {
            var shop = _m_context.ShopKeepers.Where(m => m.IsRemo == false).ToList();
            return shop;
        }

        public ShopKeeper GetShopKeeperleById(int id)
        {

            var shop = GetAllShopKeepers().FirstOrDefault(m => m.Id == id);
            return shop;
        }
        public List<ShopKeeper> GetShopKeeperleByIdall(int id)
        {

            var shop = GetAllShopKeepers().Where(m => m.Id == id).ToList();
            return shop;
        }

        public void Remo(int id)
        {
            var shop = GetShopKeeperleById(id);
            shop.IsRemo = true;
            _m_context.Entry(shop).State = EntityState.Modified;
            _m_context.SaveChanges();
        }
    }
}
