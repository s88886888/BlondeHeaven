using BlondeHeaven.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models
{
    /// <summary>
    /// 假数据生成工具
    /// </summary>
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {



            if (!context.UserShops.Any())
            {
                context.AddRange
                (
                  new UserShop { Name = "土豪", Phone = "88888888", PassWrod = "88888888", IsRemo = false, DateTime = DateTime.Now }
                );
                context.SaveChanges();
            }


            if (!context.ShopKeepers.Any())
            {
                context.AddRange
                (
                    new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/01.jpg", UserShopId = 1 },
                     new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/02.jpg", UserShopId = 1 },
                      new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/03.jpg", UserShopId = 1 },
                       new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/04.jpg", UserShopId = 1 },
                        new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/05.jpg", UserShopId = 1 },
                         new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/06.jpg", UserShopId = 1 },
                          new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/07.jpg", UserShopId = 1 },
                          new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/08.jpg", UserShopId = 1 },
                          new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/09.jpg", UserShopId = 1 },
                           new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "你家楼下", Sales = 108, Photo = "/images/10.jpg", UserShopId = 1 },
                            new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "你家楼下", Sales = 108, Photo = "/images/11.jpg", UserShopId = 1 },
                             new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "你家楼下", Sales = 108, Photo = "/images/12.jpg", UserShopId = 1 },
                             new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "你家楼下", Sales = 108, Photo = "/images/13.jpg", UserShopId = 1 },
                             new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "你家楼下", Sales = 108, Photo = "/images/14.jpg", UserShopId = 1 }
                );
                context.SaveChanges();
            }


        }
    }
}
