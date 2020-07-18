using System.Threading.Tasks;
using BlondeHeaven.Model;
using BlondeHeaven.Models;
using BlondeHeaven.Models.Interface;
using BlondeHeaven.ViewModels;
using BlondeHeaven.ViewModels.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlondeHeaven.Controllers
{
    [Authorize(Roles = "AdminShop,Admin")]
    public class CommodityController : Controller
    {
        private int comid { get; set; } = 0;
        private ICommodityRepository _com;
        private IOrderRepository _or;
        private IShopKeeperRepository _shop;
        private UserManager<ApplicationUser> _userManager;
        public CommodityController(ICommodityRepository db, IOrderRepository or, IShopKeeperRepository shop, UserManager<ApplicationUser> userManager)
        {
            _or = or;
            _com = db;
            _shop = shop;
            _userManager = userManager;
        }
        // GET: CommodityController
        public ActionResult Index(int id)
        {
            if (id == 0)
            {
                return View();
            }
            var model = new ShopModelView()
            {
                Commoditys = _com.GetCommodityByListshopId(id)
            };
            return View(model);

        }

        // GET: CommodityController/Details/5
        public ActionResult Details(int id)
        {
            var model = new OrderModelView();
            model.Commoditys = _com.GetCommodityByListId(id);
            foreach (var item in model.Commoditys)
            {
                comid = item.Id;
            }
            model.Orders = _or.GetEndOrderByCommodityId(comid);
            return View(model);
        }



        // GET: CommodityController/Create
        public ActionResult Create(int id, CommodityViewModel model)
        {
            model.ShopKeeperId = id;
            return View(model);
        }

        // POST: CommodityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CommodityViewModel model)
        {
            Commodity com = new Commodity();
            var res = await _userManager.GetUserAsync(HttpContext.User);
            var shop = _shop.GetShopKeeperleById(model.Id);
            model.Address = shop.Address;
            model.ShopKeeperName = shop.Name;
            model.ShopKeeperId = shop.Id;
            model.ApplicationUserId = res.Id;
            //model.Id = 0;
            ComData(model, com);
            _com.Add(com);

            return RedirectToAction("index", "shop");
        }

        // GET: CommodityController/Edit/5
        public ActionResult Edit(int id)
        {
            CommodityViewModel model = new CommodityViewModel();
            var com = _com.GetCommodityById(id);
            ComData(model, com);
            return View(model);
        }

        // POST: CommodityController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CommodityViewModel model)
        {
            var com = new Commodity();
            com.Name = model.Name;
            com.Photo = model.Photo;
            com.Price = model.Price;
            com.CreateCommodity = model.CreateCommodity;
            com.ShopKeeperId = model.Id;
            com.ShopKeeperName = model.ShopKeeperName;
            com.Address = model.Address;
            _com.Edit(com);
            return RedirectToAction("index", "shop");
        }
        // POST: CommodityController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            _com.Remo(id);
            return RedirectToAction("index", "shop");
        }

        private static void ComData(CommodityViewModel model, Commodity com)
        {
            com.Name = model.Name;
            com.Photo = model.Photo;
            com.Price = model.Price;
            com.CreateCommodity = model.CreateCommodity;
            com.ShopKeeperName = model.ShopKeeperName;
            com.ShopKeeperId = model.ShopKeeperId;
            com.Address = model.Address;
            com.ApplicationUserId = model.ApplicationUserId;
        }
    }
}
