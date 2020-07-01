using BlondeHeaven.Model;
using BlondeHeaven.Models.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models
{
    public class CommodityRepository : ICommodityRepository
    {
        private readonly AppDbContext _m_context;

        public CommodityRepository(AppDbContext m_context)
        {
            _m_context = m_context;
        }

        public Commodity AddAsync(Commodity model)
        {
            _m_context.Commoditys.Add(model);
            _m_context.SaveChanges();
            return model;
        }

        public Commodity EditAsync(Commodity model)
        {
            _m_context.Entry(model).State = EntityState.Modified;
            return model;
        }

        public List<Commodity> GetAllShopKeepers()
        {
            var shop = _m_context.Commoditys.Where(m => m.IsRemo == false).ToList();
            return shop;
        }

        public Commodity GetShopKeeperleById(int id)
        {

            return GetAllShopKeepers().FirstOrDefault(m => m.Id == id);
        }
        public List<Commodity> GetShopKeeperleByIdall(int id)
        {

            var shop = GetAllShopKeepers().Where(m => m.ShopKeeperId == id).ToList();
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
