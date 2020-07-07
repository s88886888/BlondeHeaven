using BlondeHeaven.Model;
using BlondeHeaven.Models.Interface;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
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

        public Commodity Add(Commodity model)
        {
            _m_context.Commoditys.Add(model);
            _m_context.SaveChanges();
            return model;
        }

        public Commodity Edit(Commodity model)
        {
            _m_context.Entry(model).State = EntityState.Modified;
            return model;
        }

        public List<Commodity> GetAllCommodity()
        {
            var shop = _m_context.Commoditys.Where(m => m.IsRemo == false).ToList();
            return shop;
        }

        public Commodity GetCommodityById(int id)
        {

            return GetAllCommodity().FirstOrDefault(m => m.Id == id);
        }
        public List<Commodity> GetCommodityByUserId(string id)
        {

            var com = GetAllCommodity().Where(m => m.ApplicationUserId == id).ToList();
            return com;
        }

        public List<Commodity> GetCommodityByoneId(int id)
        {

            var shop = GetAllCommodity().Where(m => m.ShopKeeperId == id).ToList();
            return shop;
        }

        public void Remo(int id)
        {
            var shop = GetCommodityById(id);
            shop.IsRemo = true;
            _m_context.Entry(shop).State = EntityState.Modified;
            _m_context.SaveChanges();
        }
    }
}
