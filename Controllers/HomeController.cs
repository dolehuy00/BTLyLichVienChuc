using LyLichVienChuc.Data;
using LyLichVienChuc.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LyLichVienChuc.Controllers
{
    public class HomeController : Controller
    {
        LLVCContext _LLVCContext;

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(VienChuc vienChuc)
        {
            //return Json(vienChuc);
            using (_LLVCContext = new LLVCContext())
            {
                try
                {
                    vienChuc.DsQuanHeGiaDinh.Select(h => h.VienChuc = vienChuc);
                    vienChuc.DsQuaTrinhCongTac.Select(h => h.VienChuc = vienChuc);
                    vienChuc.DsQuaTrinhLuong.Select(h => h.VienChuc = vienChuc);
                    vienChuc.DsThongTinDaoTaoBoiDuong.Select(h => h.VienChuc = vienChuc);
                    // _LLVCContext.VienChucs.Add(vienChuc);
                    //await _LLVCContext.SaveChangesAsync();
                    return Json(vienChuc);
                }
                catch (Exception e)
                {
                    return Json(e.Message);
                }
            }
        }
    }
}