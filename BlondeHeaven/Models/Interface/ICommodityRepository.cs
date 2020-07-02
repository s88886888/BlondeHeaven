using BlondeHeaven.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models.Interface
{
    public interface ICommodityRepository
    {
        List<Commodity> GetAllCommodity();

        Commodity GetCommodityById(int id);
        List<Commodity> GetCommodityByoneId(int id);
        Commodity Add(Commodity model);
        Commodity Edit(Commodity model);
        void Remo(int id);
    }
}
