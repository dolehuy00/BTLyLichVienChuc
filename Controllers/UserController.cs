using LyLichVienChuc.Models;
using System.Web.Mvc;

namespace LyLichVienChuc.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            return View();
        }
    }
}