using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlondeHeaven.Model;
using BlondeHeaven.Models;
using BlondeHeaven.Models.Interface;
using BlondeHeaven.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlondeHeaven.Controllers
{
    public class CommodityController : Controller
    {
        private ICommodityRepository _db;
        private IShopKeeperRepository _shop;
        private UserManager<ApplicationUser> _userManager;
        public CommodityController(ICommodityRepository db, IShopKeeperRepository shop, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _shop = shop;
            _userManager = userManager;
        }
        // GET: CommodityController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CommodityController/Details/5
        public ActionResult Details(int id)
        {
            CommodityViewModel model = new CommodityViewModel();
            var com = _db.GetCommodityById(id);
            ComData(model, com);
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
            _db.Add(com);

            return RedirectToAction("index", "shop");
        }

        // GET: CommodityController/Edit/5
        public ActionResult Edit(int id)
        {
            CommodityViewModel model = new CommodityViewModel();
            var com = _db.GetCommodityById(id);
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
            _db.Edit(com);
            return RedirectToAction("index", "shop");
        }
        // POST: CommodityController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            _db.Remo(id);
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
