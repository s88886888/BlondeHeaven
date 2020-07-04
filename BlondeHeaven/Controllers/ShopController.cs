using BlondeHeaven.Models;
using BlondeHeaven.Models.Interface;
using BlondeHeaven.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlondeHeaven.Controllers
{
    [Authorize]
    public class ShopController : Controller
    {
        private IShopKeeperRepository _db;
        private ICommodityRepository _com;
        public ShopController(IShopKeeperRepository db, ICommodityRepository com)
        {
            _db = db;
            _com = com;
        }
        public ActionResult Index()
        {
            var viewModel = new ShopModelView()
            {
                ShopKeepers = _db.GetAllShopKeepers(),

            };
            return View(viewModel);
        }
         [Authorize(Roles ="Admin")]
        // GET: ShopController1/Details/5
        public ActionResult Details(int id, ShopViewModel shopViewModel)
        {
            var viewModel = new ShopModelView()
            {
                ShopKeepers = _db.GetShopKeeperleByIdall(id),
                Commoditys = _com.GetCommodityByoneId(id)
            };


            return View(viewModel);
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
            ShopViewModel.Name = shop.Name;
            ShopViewModel.Phone = shop.Phone;
            ShopViewModel.Photo = shop.Photo;
            ShopViewModel.Sales = shop.Sales;
            ShopViewModel.Address = shop.Address;
            ShopViewModel.UserId = 1;
            _db.AddAsync(shop);
            return View(ShopViewModel);
        }

        // GET: ShopController1/Edit/5
        public ActionResult Edit(int id)
        {
            var edit = new ShopViewModel();
            edit.Id = id;
            edit.UserId = 1;
            var shop = _db.GetShopKeeperleById(id);
            edit.Name = shop.Name;
            edit.Phone = shop.Phone;
            edit.Sales = shop.Sales;
            edit.Sales = shop.Sales;
            edit.Address = shop.Address;
            return View(edit);
        }

        // POST: ShopController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ShopViewModel ShopViewModel)
        {

            ShopKeeper shop = new ShopKeeper();
            shop.Id = ShopViewModel.Id;
            shop.UserId = 1;
            shop.Name = ShopViewModel.Name;
            shop.Phone = ShopViewModel.Phone;
            shop.Photo = ShopViewModel.Photo;
            shop.Sales = ShopViewModel.Sales;
            shop.Address = ShopViewModel.Address;
            _db.EditAsync(shop);
            return View();
        }


        // GET: ShopController1/Delete/5
        public ActionResult Delete(int id, ShopViewModel shopViewModel)
        {
            var shop = _db.GetShopKeeperleById(id);
            shopViewModel.Name = shop.Name;
            shopViewModel.Phone = shop.Phone;
            shopViewModel.Sales = shop.Sales;
            shopViewModel.UserId = shop.UserId;
            shopViewModel.Id = shop.Id;
            shopViewModel.Sales = shop.Sales;
            shopViewModel.Address = shop.Address;
            return View(shopViewModel);
        }

        // POST: ShopController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            _db.Remo(id);
            return RedirectToAction("index", "shop");
        }
    }
}
