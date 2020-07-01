using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlondeHeaven.Models;
using BlondeHeaven.ViewModels;
using Microsoft.AspNetCore.Authorization;
using BlondeHeaven.Models.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace BlondeHeaven.Controllers
{
    /// <summary>
    /// 主页控制器
    /// </summary>
    /// 
    [Authorize]
    public class HomeController : Controller
    {
        private IShopKeeperRepository _shop;
        private IFeedbackRepository _feed;
        private INoodleRepository _nood;
        private UserManager<IdentityUser> _userManager;
        public HomeController(IShopKeeperRepository shop, IFeedbackRepository feed, INoodleRepository nood, UserManager<IdentityUser> userManager)
        {
            _shop = shop;
            _feed = feed;
            _nood = nood;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            //var noodleList = m_noodleRepository.GetAllNoodles();
            var viewModel = new HomeViewModel()
            {
                Noodles = _nood.GetAllNoodles(),
                ShopKeepers = _shop.GetAllShopKeepers(),
                Feedbacks = _feed.GetAllFeedbacks()
            };
            var res = await _userManager.GetUserAsync(HttpContext.User);

            return View(viewModel);

        }

        public IActionResult Detail(int id)
        {
            var shop = _shop.GetShopKeeperleById(id);
            return View(shop);
        }

        // GET: ShopController1/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: ShopController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ShopViewModel ShopViewModel)
        {


            ShopKeeper shop = new ShopKeeper();
            shop.Name = ShopViewModel.Name;
            shop.Phone = ShopViewModel.Phone;
            shop.Photo = ShopViewModel.Photo;
            shop.Sales = ShopViewModel.Sales;
            shop.Address = ShopViewModel.Address;
            shop.UserShopId = 1;
            _shop.AddAsync(shop);
            return View();

        }

        // GET: ShopController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShopController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ShopViewModel ShopViewModel)
        {

            ShopKeeper shop = new ShopKeeper();
            shop.Id = ShopViewModel.Id;
            shop.Name = ShopViewModel.Name;
            shop.Phone = ShopViewModel.Phone;
            shop.Photo = ShopViewModel.Photo;
            shop.Sales = ShopViewModel.Sales;
            shop.Address = ShopViewModel.Address;
            _shop.EditAsync(shop);
            return View();
        }

        // GET: ShopController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShopController1/Delete/5
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