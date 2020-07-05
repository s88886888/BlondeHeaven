using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlondeHeaven.Model;
using BlondeHeaven.Models.Interface;
using BlondeHeaven.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlondeHeaven.Controllers
{
    public class CommodityController : Controller
    {
        private ICommodityRepository _db;
        public CommodityController(ICommodityRepository db)
        {
            _db = db;
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
            model.Name = com.Name;
            model.Photo = com.Photo;
            model.Price = com.Price;
            model.CreateCommodity = com.CreateCommodity;
            model.ShopKeeperId = com.ShopKeeperId;
            return View(model);
        }

        // GET: CommodityController/Create
        public ActionResult Create(int id, CommodityViewModel model)
        {
            model.Id = id;
            return View(model);
        }

        // POST: CommodityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CommodityViewModel model)
        {

            Commodity com = new Commodity();
            com.Name = model.Name;
            com.Photo = model.Photo;
            com.Price = model.Price;
            com.CreateCommodity = model.CreateCommodity;
            com.ShopKeeperId = model.Id;
            _db.Add(com);
            return RedirectToAction("index", "shop");
        }

        // GET: CommodityController/Edit/5
        public ActionResult Edit(int id)
        {
            CommodityViewModel model = new CommodityViewModel();
            var com = _db.GetCommodityById(id);
            model.Name = com.Name;
            model.Photo = com.Photo;
            model.Price = com.Price;
            model.CreateCommodity = com.CreateCommodity;
            model.ShopKeeperId = com.ShopKeeperId;
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
    }
}
