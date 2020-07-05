using BlondeHeaven.Models;
using BlondeHeaven.Models.Interface;
using BlondeHeaven.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlondeHeaven.Controllers
{
    [Authorize]
    public class ShopController : Controller
    {
        private IShopKeeperRepository _db;
        private ICommodityRepository _com;
        private UserManager<ApplicationUser> _userManager;
        public ShopController(IShopKeeperRepository db, ICommodityRepository com, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _com = com;
            _userManager = userManager;
        }
        public ActionResult Index()
        {
            var viewModel = new ShopModelView()
            {
                ShopKeepers = _db.GetAllShopKeepers(),

            };
            return View(viewModel);
        }
        [Authorize(Roles = "Admin")]
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
        public async Task<ActionResult> Create(ShopViewModel ShopViewModel)
        {

            //动态获取当前登入用户信息
            var res = await _userManager.GetUserAsync(HttpContext.User);

            ShopKeeper shop = new ShopKeeper();

            







            shop.Name = ShopViewModel.Name;
            shop.Phone = ShopViewModel.Phone;
            shop.Photo = ShopViewModel.Photo;
            shop.Sales = ShopViewModel.Sales;
            shop.Address = ShopViewModel.Address;
            shop.ApplicationUserId = res.Id;
            _db.AddAsync(shop);
            return View(ShopViewModel);
        }

        // GET: ShopController1/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var edit = new ShopViewModel();
            var res = await _userManager.GetUserAsync(HttpContext.User);
            edit.Id = id;
            edit.UserId = res.Id;
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
        public async Task<ActionResult> Edit(int id, ShopViewModel ShopViewModel)
        {
            var res = await _userManager.GetUserAsync(HttpContext.User);

            ShopKeeper shop = new ShopKeeper();

            shop.Id = ShopViewModel.Id;
            shop.ApplicationUserId = res.Id;
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
            shopViewModel.UserId = shop.ApplicationUserId;
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
