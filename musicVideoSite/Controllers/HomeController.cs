using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using musicVideoSite.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace musicVideoSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

         public static List<MusicModel> music = new List<MusicModel>
          {
                new MusicModel { MusicNo=1, MusicName="Sergio Valentino - Drive Forever", Genre="pop" },
                new MusicModel { MusicNo=2, MusicName="Miyagi & Эндшпиль feat. Рем Дигга - I Got Love",  Genre="Hip hop" },
                new MusicModel { MusicNo=3, MusicName="Wagakki Band - 焔 (Homura) + 暁ノ糸 (Akatsuki no Ito) / 1st JAPAN Tour 2015 Hibiya Yagai Ongakudo",  Genre="Metal" }
          };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MusicList()
        {


            ViewData.Model = music;

            return View(music);


        }

        [HttpGet]
        public ActionResult Details(int id)
        {

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
