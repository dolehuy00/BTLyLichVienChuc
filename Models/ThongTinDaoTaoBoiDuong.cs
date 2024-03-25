using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LyLichVienChuc.Models
{
    public class ThongTinDaoTaoBoiDuong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int VienChucId { get; set; }
        public virtual VienChuc VienChuc { get; set; }
        public string TenTruong { get; set; }
        public string ChuyenNganh { get; set; }
        public string KhoangThoiGian { get; set; }
        public string HinhThucDaoTao { get; set; }
        public string VanBangChungChi { get; set; }
    }
}