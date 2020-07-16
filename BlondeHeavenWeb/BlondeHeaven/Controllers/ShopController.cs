using BlondeHeaven.Models;
using BlondeHeaven.Models.Interface;
using BlondeHeaven.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace BlondeHeaven.Controllers
{
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
        [HttpGet]
        public ActionResult Index()
        {
            var viewModel = new ShopModelView()
            {
                ShopKeepers = _db.GetAllShopKeepers(),
            };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Index(string SearchString)
        {
            if (SearchString == null)
            {
                ModelState.AddModelError("", "值不能为空");
            }
            var viewModel = new ShopModelView()
            {
                ShopKeepers = _db.GetNameByShopKeepers(SearchString),
            };
            return View(viewModel);
        }
        // GET: ShopController1/Details/5
        public ActionResult Details(int id, ShopViewModel shopViewModel)
        {
            var viewModel = new ShopModelView()
            {
                ShopKeepers = _db.GetShopKeeperleByIdall(id),
                Commoditys = _com.GetCommodityBListId(id)
            };


            return View(viewModel);
        }
        [Authorize(Roles = "AdminShop")]
        // GET: ShopController1/Create
        public ActionResult Create()
        {
            var model = new ShopViewModel();

            return View();
        }

        // POST: ShopController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ShopViewModel model, IFormFile image)
        {
            //动态获取当前登入用户信息
            var res = await _userManager.GetUserAsync(HttpContext.User);
            ShopKeeper shop = new ShopKeeper();
            ShopData(model, res, shop);

            if (image != null && image.Length > 0)
            {
                var fileName = Path.GetFileName(image.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\", fileName);
                using (var fileSteam = new FileStream(filePath, FileMode.Create))
                {
                    await image.CopyToAsync(fileSteam);
                }
                shop.Photo = fileName;
            }

            _db.AddAsync(shop);
            return View(model);
        }

        [Authorize(Roles = "AdminShop")]
        // GET: ShopController1/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var model = new ShopViewModel();
            var shop = _db.GetShopKeeperleById(id);
            var res = await _userManager.GetUserAsync(HttpContext.User);
            ModelData(id, model, shop, res);

            return View(model);
        }



        [Authorize(Roles = "AdminShop")]
        // POST: ShopController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ShopViewModel model)
        {
            var res = await _userManager.GetUserAsync(HttpContext.User);
            ShopKeeper shop = new ShopKeeper();
            ShopData(model, res, shop);
            shop.Id = model.Id;
            _db.EditAsync(shop);
            return View();
        }

        [Authorize(Roles = "AdminShop")]
        // GET: ShopController1/Delete/5
        public async Task<ActionResult> Delete(int id, ShopViewModel model)
        {
            //动态获取当前登入用户信息
            var res = await _userManager.GetUserAsync(HttpContext.User);
            var shop = _db.GetShopKeeperleById(id);
            ModelData(id, model, shop, res);
            model.Id = id;
            return View(model);
        }

        // POST: ShopController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {

            _db.RemoAsync(id);
            return RedirectToAction("index", "shop");
        }






        private static void ShopData(ShopViewModel Model, ApplicationUser res, ShopKeeper shop)
        {
            shop.Name = Model.Name;
            shop.Phone = Model.Phone;
            shop.Sales = Model.Sales;
            shop.Address = Model.Address;
            shop.ApplicationUserId = res.Id;
        }

        private static void ModelData(int id, ShopViewModel model, ShopKeeper shop, ApplicationUser res)
        {

            model.Id = id;
            model.ApplicationUserId = res.Id;
            model.Name = shop.Name;
            model.Phone = shop.Phone;
            model.Sales = shop.Sales;
            model.Sales = shop.Sales;
            model.Address = shop.Address;
        }
    }
}
