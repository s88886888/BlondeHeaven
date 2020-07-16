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
                    new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/01.jpg",ApplicationUserId = "b0d88785-7947-4c64-a92c-af4a8dae5b4b" },
                     new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/02.jpg", ApplicationUserId = "b0d88785-7947-4c64-a92c-af4a8dae5b4b" },
                      new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/03.jpg", ApplicationUserId = "b0d88785-7947-4c64-a92c-af4a8dae5b4b" },
                       new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/04.jpg", ApplicationUserId = "b0d88785-7947-4c64-a92c-af4a8dae5b4b" },
                        new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/05.jpg", ApplicationUserId = "b0d88785-7947-4c64-a92c-af4a8dae5b4b" },
                         new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/06.jpg", ApplicationUserId = "b0d88785-7947-4c64-a92c-af4a8dae5b4b" },
                          new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/07.jpg", ApplicationUserId = "b0d88785-7947-4c64-a92c-af4a8dae5b4b" },
                          new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/08.jpg", ApplicationUserId = "b0d88785-7947-4c64-a92c-af4a8dae5b4b" },
                          new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "楼下", Sales = 108, Photo = "/images/09.jpg", ApplicationUserId = "b0d88785-7947-4c64-a92c-af4a8dae5b4b" },
                           new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "你家楼下", Sales = 108, Photo = "/images/10.jpg", ApplicationUserId = "b0d88785-7947-4c64-a92c-af4a8dae5b4b" },
                            new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "你家楼下", Sales = 108, Photo = "/images/11.jpg", ApplicationUserId = "b0d88785-7947-4c64-a92c-af4a8dae5b4b" },
                             new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "你家楼下", Sales = 108, Photo = "/images/12.jpg", ApplicationUserId = "b0d88785-7947-4c64-a92c-af4a8dae5b4b" },
                             new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "你家楼下", Sales = 108, Photo = "/images/13.jpg", ApplicationUserId = "b0d88785-7947-4c64-a92c-af4a8dae5b4b" },
                             new ShopKeeper { Name = "三千烦恼丝", Phone = "110", Address = "你家楼下", Sales = 108, Photo = "/images/14.jpg", ApplicationUserId = "b0d88785-7947-4c64-a92c-af4a8dae5b4b" }
                );
                context.SaveChanges();
            }
        }
    }
}
