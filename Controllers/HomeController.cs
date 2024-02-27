using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            // ViewBag.selamlama = saat < 10 ? "Günaydın" : "İyi Günler";
            // ViewBag.UserName = "Emine";
            // ViewData["UserName"] = "Emine";


            ViewData["Selamlama"] = saat < 10 ? "Günaydın" : "İyi Günler";
            int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();

            var meetinginfo = new Meetinginfo()
            {
                Id = 1,
                Location = "İstanbul, ABC Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = UserCount

            };
            return View(meetinginfo);
        }
    }
}