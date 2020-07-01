using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LanZhouBeefNoodles.Controllers
{
    /// <summary>
    /// 用户控制器
    /// </summary>
    public class UserController : Controller
    {
        [Route("admin/[controller]/[action]")]
        public List<string> Index()
        {
            return new List<string>() { "阿斯蒂芬", "阿斯顿", "阿斯", "阿" };
        }
    }
}