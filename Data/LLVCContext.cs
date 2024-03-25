using LyLichVienChuc.Models;
using System.Data.Entity;

namespace LyLichVienChuc.Data
{
    public class LLVCContext : DbContext
    {
        public DbSet<VienChuc> VienChucs { get; set; }
        public DbSet<ThongTinDaoTaoBoiDuong> ThongTinDaoTaoBoiDuongs { get; set; }
        public DbSet<QuaTrinhCongTac> QuaTrinhCongTacs { get; set; }
        public DbSet<QuaTrinhLuong> QuaTrinhLuongs { get; set; }
        public DbSet<QuanHeGiaDinh> QuanHeGiaDinhs { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ThongTinDaoTaoBoiDuong>()
                .HasRequired(t => t.VienChuc)
                .WithMany(v => v.DsThongTinDaoTaoBoiDuong)
                .HasForeignKey(t => t.VienChucId);

            modelBuilder.Entity<QuaTrinhCongTac>()
                .HasRequired(t => t.VienChuc)
                .WithMany(v => v.DsQuaTrinhCongTac)
                .HasForeignKey(t => t.VienChucId);

            modelBuilder.Entity<QuanHeGiaDinh>()
                .HasRequired(t => t.VienChuc)
                .WithMany(v => v.DsQuanHeGiaDinh)
                .HasForeignKey(t => t.VienChucId);

            modelBuilder.Entity<QuaTrinhLuong>()
                .HasRequired(t => t.VienChuc)
                .WithMany(v => v.DsQuaTrinhLuong)
                .HasForeignKey(t => t.VienChucId);
        }
    }
}