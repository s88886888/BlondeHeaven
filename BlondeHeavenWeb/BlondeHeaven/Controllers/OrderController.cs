using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlondeHeaven.Models;
using BlondeHeaven.Models.Interface;
using BlondeHeaven.ViewModels;
using BlondeHeaven.ViewModels.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NPOI.SS.Formula.Functions;

namespace BlondeHeaven.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository _db;
        private ICommodityRepository _com;
        private UserManager<ApplicationUser> _userManager;
        public OrderController(IOrderRepository db, ICommodityRepository com, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _com = com;
            _userManager = userManager;
        }
        // GET: OrderController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            var model = new OrderModelView();
            model.Orders = _db.GetOrderByListId(id);
            return View(model);
        }


        // GET: OrderController/Create
        public ActionResult Create(int Id, OrderViewModel model)
        {
            model.Id = Id;
            var com = _com.GetCommodityById(Id);
            model.ShopKeeperName = com.ShopKeeperName;
            model.CommodityName = com.ShopKeeperName;
            model.Address = com.Address;
            model.CreateCommodity = com.CreateCommodity;
            return View(model);
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(OrderViewModel model)
        {
            Order order = new Order();
            var res = await _userManager.GetUserAsync(HttpContext.User);
            var com = _com.GetCommodityById(model.Id);
            order.ApplicationUserId = res.Id;
            order.ShopKeeperId = com.ShopKeeperId;
            order.CommodityId = com.Id;
            order.CommodityName = com.Name;
            order.ShopKeeperName = com.ShopKeeperName;
            order.Address = com.Address;
            order.Price = com.Price;
            order.Address = com.Address;
            order.CreateCommodity = com.CreateCommodity;
            //---------------------------------------------//
            order.Remarks = model.Remarks;
            order.Phone = model.Phone;
            order.Name = model.Name;
            order.Email = res.Email;
            _db.Add(order);
            return View();
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
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

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {



            return View();
        }

        // POST: OrderController/Delete/5
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
