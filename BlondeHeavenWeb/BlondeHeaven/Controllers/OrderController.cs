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
            model.Orders = _db.GetOrderByUserId(id);
            return View(model);
        }


        // GET: OrderController/Create
        public async Task<ActionResult> Create(int Id, OrderViewModel order)
        {

            var res = await _userManager.GetUserAsync(HttpContext.User);

            if (res == null)
            {
                return View();
            }

            var com = _com.GetCommodityById(Id);

            order.UserId = res.Id;
            order.ShopKeepeid = com.ShopKeeperId;
            order.CommodityId = com.Id;
            order.CommodityName = com.Name;
            order.ShopKeeperName = com.ShopKeeperName;
            order.Address = com.Address;
            order.Price = com.Price;
            order.Address = com.Address;
            order.CreateCommodity = com.CreateCommodity;
            return View(order);
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderViewModel orderViewModel)
        {
            Order order = new Order();
            order.Address = orderViewModel.Address;
            order.Price = orderViewModel.Price;
            order.Remarks = orderViewModel.Remarks;
            order.Phone = orderViewModel.Phone;



            order.CreateCommodity = orderViewModel.CreateCommodity;
            order.ShopKeeperName = orderViewModel.ShopKeeperName;
            order.CommodityName = orderViewModel.CommodityName;
            order.Name = orderViewModel.Name;
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
