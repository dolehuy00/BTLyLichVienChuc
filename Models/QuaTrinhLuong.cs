using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LyLichVienChuc.Models
{
    public class QuaTrinhLuong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int VienChucId { get; set; }
        public virtual VienChuc VienChuc { get; set; }
        public string ThangNam { get; set; }
        public string MaSo { get; set; }
        public string BacLuong { get; set; }
        public string HeSoLuong { get; set; }

    }
}