using LyLichVienChuc.App_Start;
using LyLichVienChuc.Data;
using LyLichVienChuc.Models;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace LyLichVienChuc.Controllers
{
    [Route("api/VienChucApi")]
    public class VienChucApiController : ApiController
    {
        private LLVCContext db = new LLVCContext();

        // GET: api/VienChucApi
        public IQueryable<VienChuc> GetVienChucs()
        {
            return db.VienChucs;
        }

        // GET: api/VienChucApi/5
        [Route("api/VienChucApi/{id}")]
        [ResponseType(typeof(VienChuc))]
        public IHttpActionResult GetVienChuc(int id)
        {
            VienChuc vienChuc = db.VienChucs.Find(id);
            if (vienChuc == null)
            {
                return NotFound();
            }

            return Ok(vienChuc);
        }

        // PUT: api/VienChucApi/5
        [ResponseType(typeof(void))]
        [HttpPut]
        [Route("api/VienChucApi/{id}")]
        public IHttpActionResult PutVienChuc(int id, VienChuc vienChuc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vienChuc.Id)
            {
                return BadRequest();
            }


            var oldVienChuc = db.VienChucs.Find(id);

            AutoMapperConfig.Mapper.Map(vienChuc, oldVienChuc);

            db.QuaTrinhLuongs.RemoveRange(db.QuaTrinhLuongs.Where(q => q.VienChucId == id));
            db.QuaTrinhLuongs.AddRange(vienChuc.DsQuaTrinhLuong);

            db.QuanHeGiaDinhs.RemoveRange(db.QuanHeGiaDinhs.Where(q => q.VienChucId == id));
            db.QuanHeGiaDinhs.AddRange(vienChuc.DsQuanHeGiaDinh);

            db.QuaTrinhCongTacs.RemoveRange(db.QuaTrinhCongTacs.Where(q => q.VienChucId == id));
            db.QuaTrinhCongTacs.AddRange(vienChuc.DsQuaTrinhCongTac);

            db.ThongTinDaoTaoBoiDuongs.RemoveRange(db.ThongTinDaoTaoBoiDuongs.Where(q => q.VienChucId == id));
            db.ThongTinDaoTaoBoiDuongs.AddRange(vienChuc.DsThongTinDaoTaoBoiDuong);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VienChucExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/VienChucApi
        [ResponseType(typeof(VienChuc))]
        public async Task<IHttpActionResult> PostVienChuc(VienChuc vienChuc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VienChucs.Add(vienChuc);
            await db.SaveChangesAsync();

            return Ok(vienChuc);
        }

        // DELETE: api/VienChucApi/5
        [ResponseType(typeof(VienChuc))]
        public IHttpActionResult DeleteVienChuc(int id)
        {
            VienChuc vienChuc = db.VienChucs.Find(id);
            if (vienChuc == null)
            {
                return NotFound();
            }

            db.VienChucs.Remove(vienChuc);
            db.SaveChanges();

            return Ok(vienChuc);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VienChucExists(int id)
        {
            return db.VienChucs.Count(e => e.Id == id) > 0;
        }
    }
}