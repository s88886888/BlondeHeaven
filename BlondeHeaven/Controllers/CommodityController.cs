﻿using System;
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
            return View();
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
            com.ShopKeeperId = model.Id;
            _db.Add(com);
          return  RedirectToAction("index", "shop");
        }

        // GET: CommodityController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CommodityController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CommodityController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CommodityController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
