using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlondeHeaven.Models.Interface;
using BlondeHeaven.ViewModels;
using BlondeHeaven.ViewModels.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlondeHeaven.Controllers
{
    public class PersonalController : Controller
    {
        private IOrderRepository _or;
        private ICommodityRepository _com;

        public PersonalController(IOrderRepository or, ICommodityRepository com)
        {
            _or = or;
            _com = com;
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
        public ActionResult Order()
        {
            var id = 1;

            var UserOR = new OrderModelView()
            {
                Orders = _or.GetOrderByondeId(id)
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

    }
}
