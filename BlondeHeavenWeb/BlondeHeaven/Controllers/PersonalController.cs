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

namespace BlondeHeaven.Controllers
{
    public class PersonalController : Controller
    {
        private IOrderRepository _or;
        private ICommodityRepository _com;
        private UserManager<ApplicationUser> _userManager;
        public PersonalController(IOrderRepository or, ICommodityRepository com, UserManager<ApplicationUser> userManager)
        {
            _or = or;
            _com = com;
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
            var UserOR = new OrderModelView()
            {
                Orders = _or.GetOrderByondeId(res.Id)
            };
            return View(UserOR);
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

        public async Task<ActionResult> UserShop()
        {
            var res = await _userManager.GetUserAsync(HttpContext.User);
            var com = _com.GetCommodityByUserId(res.Id);

            foreach (var item in com)
            {
                var id = item.Id;

                var model = new OrderModelView()
                {
                    Orders = _or.GetOrderByUserId(id)
                };
                return View(model);
            }
            return View();
        }

    }
}
