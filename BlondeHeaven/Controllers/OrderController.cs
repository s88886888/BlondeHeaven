using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlondeHeaven.Models;
using BlondeHeaven.Models.Interface;
using BlondeHeaven.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }


        // GET: OrderController/Create
        public async Task<ActionResult> Create(int Id, OrderViewModel order)
        {

            var res = await _userManager.GetUserAsync(HttpContext.User);
            var com = _com.GetCommodityById(Id);
            order.UserId = res.Id;
            order.ShopKeepeid = com.ShopKeeperId;
            order.CommodityId = com.Id;
            order.Price = com.Price;
            return View(order);
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderViewModel orderViewModel)
        {
            Order order = new Order();
            order.Name = orderViewModel.Name;
            order.Price = orderViewModel.Price;
            order.Name = orderViewModel.Name;
            order.ShopKeeperId = orderViewModel.ShopKeepeid;
            order.CommodityId = orderViewModel.CommodityId;
            order.ApplicationUserId = orderViewModel.UserId;
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
