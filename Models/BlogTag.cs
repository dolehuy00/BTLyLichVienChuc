using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LyLichVienChuc.Models
{
    public class BlogTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CreateBy { get; set; }
        public int BlogId { get; set; }
        public int TagId { get; set; }
        public Blog Blog { get; set; }
        public Tag Tag { get; set; }
    }
}