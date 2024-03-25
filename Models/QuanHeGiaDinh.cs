using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LyLichVienChuc.Models
{
    public class QuanHeGiaDinh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int VienChucId { get; set; }
        public virtual VienChuc VienChuc { get; set; }
        public bool LaTTQHGDCuaBanThan { get; set; }
        public string MoiQuanHe { get; set; }
        public string HoVaTen { get; set; }
        public string NamSinh { get; set; }
        public string ThongTinKhac { get; set; }
    }
}