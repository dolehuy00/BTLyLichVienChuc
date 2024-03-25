using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LyLichVienChuc.Models
{
    public class VienChuc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CoQuanQuanLy { get; set; }
        public string CoQuanSuDung { get; set; }
        public string SoHieuVienChuc { get; set; }
        public string AnhThe { get; set; }
        public string HoVaTen { get; set; }
        public string TenGoiKhac { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string XaNoiSinh { get; set; }
        public string HuyenNoiSinh { get; set; }
        public string TinhNoiSinh { get; set; }
        public string XaQueQuan { get; set; }
        public string HuyenQueQuan { get; set; }
        public string TinhQueQuan { get; set; }
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public string HoKhauThuongTru { get; set; }
        public string NoiOHienNay { get; set; }
        public string NgheNghiepKhiDuocTuyen { get; set; }
        public DateTime NgayTuyenDung { get; set; }
        public string CoQuanTuyenDung { get; set; }
        public string ChucDanhHienTai { get; set; }
        public string ChucDanhKiemNhiem { get; set; }
        public string CongViecChinhDuocGiao { get; set; }
        public string ChucDanhNgheNghiep { get; set; }
        public string MaSoChucDanhNgheNghiep { get; set; }
        public string BacLuong { get; set; }
        public string HeSoLuong { get; set; }
        public DateTime NgayHuongBacLuong { get; set; }
        public string PhuCapChucDanh { get; set; }
        public string PhuCapKhac { get; set; }
        public string TrinhDoGiaoDucPhoThong { get; set; }
        public string TrinhDoChuyenMonCaoNhat { get; set; }
        public string TrinhDoLyLuanChinhTri { get; set; }
        public string TrinhDoQuanLyNhaNuoc { get; set; }
        public string TrinhDoNghiepVuChuyenNganh { get; set; }
        public string TrinhDoNgoaiNgu { get; set; }
        public string TrinhDoTinHoc { get; set; }
        public DateTime NgayVaoDang { get; set; }
        public DateTime NgayChinhThucVaoDang { get; set; }
        public string ThamGiaToChucCTXH { get; set; }
        public DateTime NgayNhapNgu { get; set; }
        public DateTime NgayXuatNgu { get; set; }
        public string QuanHamCaoNhat { get; set; }
        public string DanhHieuDuocPhongTangCaoNhat { get; set; }
        public string HocHamDuocPhong { get; set; }
        public int NamPhongHocHam { get; set; }
        public string SoTruongCongTac { get; set; }
        public string KhenThuongCaoNhat { get; set; }
        public string KyLuat { get; set; }
        public string TinhTrangSucKhoe { get; set; }
        public string ChieuCao { get; set; }
        public string CanNang { get; set; }
        public string NhomMau { get; set; }
        public string LaThuongBinhHang { get; set; }
        public string ConGiaDinhChinhSach { get; set; }
        public string SoCCCD { get; set; }
        public DateTime NgayCapCCCD { get; set; }
        public string SoBHXH { get; set; }
        public ICollection<ThongTinDaoTaoBoiDuong> DsThongTinDaoTaoBoiDuong { get; set; }
        public ICollection<QuaTrinhCongTac> DsQuaTrinhCongTac { get; set; }
        public string LichSuBanThan { set; get; }
        public string LichSuThamGiaCacCoQuanNuocNgoai { get; set; }
        public string ThanNhanONuocNgoai { get; set; }
        public ICollection<QuanHeGiaDinh> DsQuanHeGiaDinh { get; set; }
        public ICollection<QuaTrinhLuong> DsQuaTrinhLuong { get; set; }
        public string NhanXet { get; set; }
    }
}