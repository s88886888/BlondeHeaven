using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlondeHeaven.Model;
using BlondeHeaven.Models.Interface;
using BlondeHeaven.ViewModels.Base;
using BlondeHeaven.ViewModels.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlondeHeaven.Controllers
{
    public class CommentController : Controller
    {
        private ICommentRepository _com;

        public CommentController(ICommentRepository com)
        {
            _com = com;
        }
        public IActionResult Index()
        {
            CommentModelView model = new CommentModelView()
            {
                Comments = _com.GetListCommentAll(),
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(CommentViewModel model)
        {

            var com = new Comment();

            com.Name = model.Name;
            com.Content = model.Content;
            _com.Add(com);

            return RedirectToAction("index");
        }



    }
}
