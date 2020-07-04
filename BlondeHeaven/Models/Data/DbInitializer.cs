using BlondeHeaven.Models;
using NPOI.SS.Formula.Functions;
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


            if (!context.ShopKeepers.Any())
            {
                context.AddRange
                (
                    new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/01.jpg", UserId = 1 },
                     new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/02.jpg", UserId = 1 },
                      new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/03.jpg", UserId = 1 },
                       new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/04.jpg", UserId = 1 },
                        new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/05.jpg", UserId = 1 },
                         new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/06.jpg", UserId = 1 },
                          new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/07.jpg", UserId = 1 },
                          new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/08.jpg", UserId = 1 },
                          new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/09.jpg", UserId = 1 },
                           new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "你家楼下", Sales = 108, Photo = "/images/10.jpg", UserId = 1 },
                            new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "你家楼下", Sales = 108, Photo = "/images/11.jpg", UserId = 1 },
                             new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "你家楼下", Sales = 108, Photo = "/images/12.jpg", UserId = 1 },
                             new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "你家楼下", Sales = 108, Photo = "/images/13.jpg", UserId = 1 },
                             new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "你家楼下", Sales = 108, Photo = "/images/14.jpg", UserId = 1 }
                );
                context.SaveChanges();
            }
        }
    }
}
