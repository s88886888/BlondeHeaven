using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models.Interface
{
    public interface IShopKeeperRepository
    {
        List<ShopKeeper> GetAllShopKeepers();

        ShopKeeper GetShopKeeperleById(int id);
        List<ShopKeeper> GetShopKeeperleByIdall(int id);
        ShopKeeper AddAsync(ShopKeeper model);
        ShopKeeper EditAsync(ShopKeeper model);
        void Remo(int id);
    }
}
