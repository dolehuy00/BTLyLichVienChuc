namespace LyLichVienChuc.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class myMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuanHeGiaDinhs",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    VienChucId = c.Int(nullable: false),
                    LaTTQHGDCuaBanThan = c.Boolean(nullable: false),
                    MoiQuanHe = c.String(),
                    HoVaTen = c.String(),
                    NamSinh = c.String(),
                    ThongTinKhac = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VienChucs", t => t.VienChucId, cascadeDelete: true)
                .Index(t => t.VienChucId);

            CreateTable(
                "dbo.VienChucs",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    CoQuanQuanLy = c.String(),
                    CoQuanSuDung = c.String(),
                    SoHieuVienChuc = c.String(),
                    AnhThe = c.String(),
                    HoVaTen = c.String(),
                    TenGoiKhac = c.String(),
                    NgaySinh = c.DateTime(nullable: false),
                    GioiTinh = c.Boolean(nullable: false),
                    XaNoiSinh = c.String(),
                    HuyenNoiSinh = c.String(),
                    TinhNoiSinh = c.String(),
                    XaQueQuan = c.String(),
                    HuyenQueQuan = c.String(),
                    TinhQueQuan = c.String(),
                    DanToc = c.String(),
                    TonGiao = c.String(),
                    HoKhauThuongTru = c.String(),
                    NoiOHienNay = c.String(),
                    NgheNghiepKhiDuocTuyen = c.String(),
                    NgayTuyenDung = c.DateTime(nullable: false),
                    CoQuanTuyenDung = c.String(),
                    ChucDanhHienTai = c.String(),
                    ChucDanhKiemNhiem = c.String(),
                    CongViecChinhDuocGiao = c.String(),
                    ChucDanhNgheNghiep = c.String(),
                    MaSoChucDanhNgheNghiep = c.String(),
                    BacLuong = c.String(),
                    HeSoLuong = c.String(),
                    NgayHuongBacLuong = c.DateTime(nullable: false),
                    PhuCapChucDanh = c.String(),
                    PhuCapKhac = c.String(),
                    TrinhDoGiaoDucPhoThong = c.String(),
                    TrinhDoChuyenMonCaoNhat = c.String(),
                    TrinhDoLyLuanChinhTri = c.String(),
                    TrinhDoQuanLyNhaNuoc = c.String(),
                    TrinhDoNghiepVuChuyenNganh = c.String(),
                    TrinhDoNgoaiNgu = c.String(),
                    TrinhDoTinHoc = c.String(),
                    NgayVaoDang = c.DateTime(nullable: false),
                    NgayChinhThucVaoDang = c.DateTime(nullable: false),
                    ThamGiaToChucCTXH = c.String(),
                    NgayNhapNgu = c.DateTime(nullable: false),
                    NgayXuatNgu = c.DateTime(nullable: false),
                    QuanHamCaoNhat = c.String(),
                    DanhHieuDuocPhongTangCaoNhat = c.String(),
                    HocHamDuocPhong = c.String(),
                    NamPhongHocHam = c.Int(nullable: false),
                    SoTruongCongTac = c.String(),
                    KhenThuongCaoNhat = c.String(),
                    KyLuat = c.String(),
                    TinhTrangSucKhoe = c.String(),
                    ChieuCao = c.String(),
                    CanNang = c.String(),
                    NhomMau = c.String(),
                    LaThuongBinhHang = c.String(),
                    ConGiaDinhChinhSach = c.String(),
                    SoCCCD = c.String(),
                    NgayCapCCCD = c.DateTime(nullable: false),
                    SoBHXH = c.String(),
                    LichSuBanThan = c.String(),
                    LichSuThamGiaCacCoQuanNuocNgoai = c.String(),
                    ThanNhanONuocNgoai = c.String(),
                    NhanXet = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.QuaTrinhCongTacs",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    VienChucId = c.Int(nullable: false),
                    KhoangThoiGian = c.String(),
                    ChucDanh = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VienChucs", t => t.VienChucId, cascadeDelete: true)
                .Index(t => t.VienChucId);

            CreateTable(
                "dbo.QuaTrinhLuongs",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    VienChucId = c.Int(nullable: false),
                    ThangNam = c.String(),
                    MaSo = c.String(),
                    BacLuong = c.String(),
                    HeSoLuong = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VienChucs", t => t.VienChucId, cascadeDelete: true)
                .Index(t => t.VienChucId);

            CreateTable(
                "dbo.ThongTinDaoTaoBoiDuongs",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    VienChucId = c.Int(nullable: false),
                    TenTruong = c.String(),
                    ChuyenNganh = c.String(),
                    KhoangThoiGian = c.String(),
                    HinhThucDaoTao = c.String(),
                    VanBangChungChi = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VienChucs", t => t.VienChucId, cascadeDelete: true)
                .Index(t => t.VienChucId);

            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Blogs",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.BlogHeaders",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    BlogId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blogs", t => t.BlogId)
                .Index(t => t.BlogId);

            CreateTable(
                "dbo.BlogTags",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    CreateBy = c.String(),
                    BlogId = c.Int(nullable: false),
                    TagId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagId, cascadeDelete: true)
                .Index(t => t.BlogId)
                .Index(t => t.TagId);

            CreateTable(
                "dbo.Tags",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.TagBlogs",
                c => new
                {
                    Tag_Id = c.Int(nullable: false),
                    Blog_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Tag_Id, t.Blog_Id })
                .ForeignKey("dbo.Tags", t => t.Tag_Id, cascadeDelete: true)
                .ForeignKey("dbo.Blogs", t => t.Blog_Id, cascadeDelete: true)
                .Index(t => t.Tag_Id)
                .Index(t => t.Blog_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.BlogTags", "TagId", "dbo.Tags");
            DropForeignKey("dbo.TagBlogs", "Blog_Id", "dbo.Blogs");
            DropForeignKey("dbo.TagBlogs", "Tag_Id", "dbo.Tags");
            DropForeignKey("dbo.BlogTags", "BlogId", "dbo.Blogs");
            DropForeignKey("dbo.BlogHeaders", "BlogId", "dbo.Blogs");
            DropForeignKey("dbo.QuanHeGiaDinhs", "VienChucId", "dbo.VienChucs");
            DropForeignKey("dbo.ThongTinDaoTaoBoiDuongs", "VienChucId", "dbo.VienChucs");
            DropForeignKey("dbo.QuaTrinhLuongs", "VienChucId", "dbo.VienChucs");
            DropForeignKey("dbo.QuaTrinhCongTacs", "VienChucId", "dbo.VienChucs");
            DropIndex("dbo.TagBlogs", new[] { "Blog_Id" });
            DropIndex("dbo.TagBlogs", new[] { "Tag_Id" });
            DropIndex("dbo.BlogTags", new[] { "TagId" });
            DropIndex("dbo.BlogTags", new[] { "BlogId" });
            DropIndex("dbo.BlogHeaders", new[] { "BlogId" });
            DropIndex("dbo.ThongTinDaoTaoBoiDuongs", new[] { "VienChucId" });
            DropIndex("dbo.QuaTrinhLuongs", new[] { "VienChucId" });
            DropIndex("dbo.QuaTrinhCongTacs", new[] { "VienChucId" });
            DropIndex("dbo.QuanHeGiaDinhs", new[] { "VienChucId" });
            DropTable("dbo.TagBlogs");
            DropTable("dbo.Tags");
            DropTable("dbo.BlogTags");
            DropTable("dbo.BlogHeaders");
            DropTable("dbo.Blogs");
            DropTable("dbo.Users");
            DropTable("dbo.ThongTinDaoTaoBoiDuongs");
            DropTable("dbo.QuaTrinhLuongs");
            DropTable("dbo.QuaTrinhCongTacs");
            DropTable("dbo.VienChucs");
            DropTable("dbo.QuanHeGiaDinhs");
        }
    }
}
