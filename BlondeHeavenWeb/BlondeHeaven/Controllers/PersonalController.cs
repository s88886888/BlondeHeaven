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
using Microsoft.AspNetCore.Rewrite.Internal.IISUrlRewrite;
using NPOI.SS.Formula.Functions;

namespace BlondeHeaven.Controllers
{
    public class PersonalController : Controller
    {
        private readonly IOrderRepository _or;
        private readonly ICommodityRepository _com;
        private readonly IShopKeeperRepository _shop;
        private UserManager<ApplicationUser> _userManager;
        public PersonalController(IOrderRepository or, ICommodityRepository com, UserManager<ApplicationUser> userManager, IShopKeeperRepository shop)
        {
            _or = or;
            _com = com;
            _shop = shop;
            _userManager = userManager;
        }
        // GET: PersonalController
        public ActionResult Index()
        {


            return View();
        }

        // GET: PersonalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonalController/Create
        public async Task<ActionResult> Order()
        {

            var res = await _userManager.GetUserAsync(HttpContext.User);
            if (res != null)
            {
                var UserOR = new OrderModelView()
                {
                    Orders = _or.GetOrderByUserId(res.Id)
                };
                return View(UserOR);
            }
            else
            {
                return RedirectToAction("index", "shop");
            }
        }
        // GET: PersonalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonalController/Edit/5
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

        // GET: PersonalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonalController/Delete/5
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

        /// <summary>
        /// 商家订单中心
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> UserShop()
        {
            //获取当前登入 用户
            var res = await _userManager.GetUserAsync(HttpContext.User);
            //查询登入用户 创建的商品
            var com = _com.GetCommodityByUserId(res.Id);

            var lsmodel = new List<OrderViewModel>();

            foreach (var item in com)
            {
                var commodel = _or.GetOrderByCommodityId(item.Id);
                foreach (var order in commodel)
                {
                    var ordermodel = new OrderViewModel();
                    ordermodel.Email = order.Email;
                    ordermodel.Address = order.Address;
                    ordermodel.CommodityName = order.CommodityName;
                    ordermodel.Id = order.Id;
                    ordermodel.Price = order.Price;
                    ordermodel.Name = order.Name;
                    ordermodel.Remarks = order.Remarks;
                    ordermodel.ShopKeeperName = order.ShopKeeperName;
                    ordermodel.Phone = order.Phone;
                    ordermodel.CreateCommodity = order.CreateCommodity;

                    lsmodel.Add(ordermodel);
                }
            }

            return View(lsmodel);
        }
        /// <summary>
        /// 商家店铺中心
        /// </summary>
        /// <returns></returns>
        /// 
        public ActionResult MyShop()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> AdminShop()
        {
            var res = await _userManager.GetUserAsync(HttpContext.User);
            if (res == null)
            {
                return RedirectToAction("index", "shop");
            }
            else
            {
                var viewModel = new ShopModelView()
                {
                    ShopKeepers = _shop.GetUserByShopKeepers(res.Id)
                };
                return View(viewModel);
            };
        }
    }
}



