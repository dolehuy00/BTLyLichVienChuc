using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LyLichVienChuc.Models
{
    public class QuaTrinhCongTac
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int VienChucId { get; set; }
        public virtual VienChuc VienChuc { get; set; }
        public string KhoangThoiGian { get; set; }
        public string ChucDanh { get; set; }
    }
}