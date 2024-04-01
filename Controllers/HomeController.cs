using LyLichVienChuc.Data;
using System.Web.Mvc;

namespace LyLichVienChuc.Controllers
{
    public class HomeController : Controller
    {
        LLVCContext _LLVCContext = new LLVCContext();

        public ActionResult Index()
        {
            return View();
        }
    }
}