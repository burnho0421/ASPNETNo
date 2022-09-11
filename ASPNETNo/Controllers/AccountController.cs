using Microsoft.AspNetCore.Mvc;

namespace AspnetNo.Controllers
{
    public class AccountController : Controller
    {

        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {
            return View();
        }


        /// <summary>
        /// 회원가입
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }


    }
}
