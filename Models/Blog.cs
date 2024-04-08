using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LyLichVienChuc.Models
{
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public BlogHeader Header { get; set; }
        public List<BlogTag> PostTags { get; set; }
        public List<Tag> Tags { get; set; }
    }
}