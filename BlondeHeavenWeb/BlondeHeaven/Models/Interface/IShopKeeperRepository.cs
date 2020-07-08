using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models.Interface
{
    public interface IShopKeeperRepository
    {
        /// <summary>
        /// 查询所有商店
        /// </summary>
        /// <returns></returns>
        List<ShopKeeper> GetAllShopKeepers();

        ShopKeeper GetShopKeeperleById(int id);
        List<ShopKeeper> GetShopKeeperleByIdall(int id);
        ShopKeeper AddAsync(ShopKeeper model);
        ShopKeeper EditAsync(ShopKeeper model);
        void Remo(int id);
    }
}
