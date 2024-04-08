using LyLichVienChuc.Data;
using System.Data.Entity;
using System.Linq;
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

        public ActionResult ViewList()
        {
            var list = _LLVCContext.VienChucs.ToList();
            return View(list);
        }

        [Route("/Home/Details/{id}")]
        public ActionResult Details(int id)
        {
            var vienChuc = _LLVCContext.VienChucs
                .Where(v => v.Id == id)
                .Include(v => v.DsQuanHeGiaDinh)
                .Include(v => v.DsQuaTrinhCongTac)
                .Include(v => v.DsQuaTrinhLuong)
                .Include(v => v.DsThongTinDaoTaoBoiDuong)
                .FirstOrDefault();
            return View(vienChuc);
        }

        [Route("/Home/Update/{id}")]
        public ActionResult Update(int id)
        {
            var vienChuc = _LLVCContext.VienChucs
                .Where(v => v.Id == id)
                .Include(v => v.DsQuanHeGiaDinh)
                .Include(v => v.DsQuaTrinhCongTac)
                .Include(v => v.DsQuaTrinhLuong)
                .Include(v => v.DsThongTinDaoTaoBoiDuong)
                .FirstOrDefault();
            if (vienChuc == null)
            {
                return RedirectToAction("Index");
            }
            return View(vienChuc);
        }

        [Route("/Home/Delete/{id}")]
        public ActionResult Delete(int id)
        {
            var vienChuc = _LLVCContext.VienChucs.Where(v => v.Id == id).FirstOrDefault();
            _LLVCContext.VienChucs.Remove(vienChuc);
            _LLVCContext.SaveChanges();
            return RedirectToAction("ViewList");
        }
    }
}