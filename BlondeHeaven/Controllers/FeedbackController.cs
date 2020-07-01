using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using BlondeHeaven.Models;

namespace LanZhouBeefNoodles.Controllers
{
    /// <summary>
    /// 客户评价控制器
    /// </summary>
    [Authorize]
    public class FeedbackController : Controller
    {

        private IFeedbackRepository m_feedbackRepository;
        private UserManager<IdentityUser> m_userManager;
        public FeedbackController(IFeedbackRepository feedbackRepository, UserManager<IdentityUser> userManager)
        {
            m_feedbackRepository = feedbackRepository;
            m_userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await m_userManager.GetUserAsync(HttpContext.User);
            Feedback feedback = new Feedback()
            {
                Email = user.Email
            };
            return View(feedback);
        }

        /// <summary>
        /// 用户评价编辑
        /// </summary>
        /// <param name="feedback"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            //Tag Helper
            if (ModelState.IsValid)
            {
                m_feedbackRepository.AddFeedback(feedback);
                return RedirectToAction("FeedbackComplete");
            }
            return View();
        }

        /// <summary>
        /// 用户评价成功
        /// </summary>
        /// <returns></returns>
        public IActionResult FeedbackComplete()
        {
            return View();
        }
    }
}