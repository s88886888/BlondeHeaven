using System.Collections.Generic;
using System.Threading.Tasks;
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
    [Authorize]
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

        /// <summary>
        /// 用户订单显示
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// 用户确认完成订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult FinishOrder(int id)
        {
            var order = _or.GetOrderById(id);
            var com = _com.GetCommodityById(order.CommodityId);
            var shop = _shop.GetShopKeeperleById(order.ShopKeeperId);
            shop.Sales = +1;
            com.Sales = +1;
            order.IsRemo = true;
            _or.Edit(order);
            _shop.EditAsync(shop);
            return RedirectToAction("EndOrder");
        }
        /// <summary>
        /// 添加评价订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Comment(int id)
        {

            var model = new OrderViewModel();
            var order = _or.GetEndOrderById(id);
            model.Id = order.Id;
            model.Name = order.Name;
            model.Phone = order.Phone;
            model.Price = order.Price;
            model.Remarks = order.Remarks;
            model.ShopKeeperName = order.ShopKeeperName;
            model.Email = order.Name;
            model.CommodityName = order.CommodityName;
            model.Address = order.Address;
            model.CreateCommodity = order.CreateCommodity;
            return View(model);
        }
        [HttpPost]
        public ActionResult Comment(OrderViewModel model)
        {

            var order = _or.GetEndOrderById(model.Id);
            if (order.Comment == null)
            {
                order.Comment = model.Comment;
                _or.Edit(order);
                return RedirectToAction("MyComment");
            }
            return RedirectToAction("order");

        }
        /// <summary>
        /// 我的所有评价
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<ActionResult> MyComment()
        {
            var res = await _userManager.GetUserAsync(HttpContext.User);
            var model = new OrderModelView();
            model.Orders = _or.GetOrderByComment(res.Id);
            return View(model);
        }





        /// <summary>
        /// 显示已完成订单
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> EndOrder()
        {

            var res = await _userManager.GetUserAsync(HttpContext.User);

            if (res != null)
            {
                var UserOR = new OrderModelView()
                {
                    Orders = _or.GetEndOrderByUserId(res.Id)
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
        public async Task<ActionResult> UserEndShop()
        {
            //获取当前登入 用户
            var res = await _userManager.GetUserAsync(HttpContext.User);
            //查询登入用户 创建的商品
            var com = _com.GetCommodityByUserId(res.Id);

            var lsmodel = new List<OrderViewModel>();

            foreach (var item in com)
            {
                var commodel = _or.GetEndOrderByCommodityId(item.Id);
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
    }
}



