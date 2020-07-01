using BlondeHeaven.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models.Interface
{
    public interface ICommodityRepository
    {
        List<Commodity> GetAllShopKeepers();

        Commodity GetShopKeeperleById(int id);
        List<Commodity> GetShopKeeperleByIdall(int id);
        Commodity AddAsync(Commodity model);
        Commodity EditAsync(Commodity model);
        void Remo(int id);
    }
}
