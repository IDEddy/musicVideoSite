using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace musicVideoSite.Controllers
{

    public class MusicController : Controller
    {
        public IActionResult MusicList()
        {

            List<MusicModel> music = new List<MusicModel>
            {
                new MusicModel { MusicNo=1, MusicName="Sergio Valentino - Drive Forever", Genre="pop" },
                new MusicModel { MusicNo=2, MusicName="Sergio Valentino - Drive Forever",  Genre="test" }
            };

            ViewData.Model = music;

            return View();


        }

    }

}