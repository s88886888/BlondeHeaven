using BlondeHeaven.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models.Interface
{
    public interface ICommodityRepository
    {




        /// <summary>
        /// 根据Id查询所有列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Commodity> GetCommodityByListshopId(int id);
        /// <summary>
        /// 查询所有的商品
        /// </summary>
        /// <returns></returns>
        List<Commodity> GetAllCommodity();
        /// <summary>
        /// 根据商品Id查询商品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Commodity GetCommodityById(int id);

        /// <summary>
        /// 查询根据id 查询商品List
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Commodity> GetCommodityByListId(int id);
        /// <summary>
        /// 根据用户id查询 查询所有商品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Commodity> GetCommodityByUserId(string id);
        Commodity Add(Commodity model);
        Commodity Edit(Commodity model);
        void Remo(int id);
    }
}
