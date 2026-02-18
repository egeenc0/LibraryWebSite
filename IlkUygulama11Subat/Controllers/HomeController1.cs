using Microsoft.AspNetCore.Mvc;

namespace IlkUygulama11Subat.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MyPage(int param)
        {
            // ViewBag, içine her şeyi atabileceğin sihirli bir torba gibidir.
            // "GelenSayi" isminde bir kutu açıp param'ı içine koyuyoruz.
            ViewBag.GelenSayi = param;

            return View();
        }
    }
}
