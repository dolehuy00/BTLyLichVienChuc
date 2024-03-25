
$(document).ready(function () {
    addEventAddAndDeleteRowForTable('table-31', 'btn-insert-table-31', 'wrapper-table-31', 4, 'input');
    addEventAddAndDeleteRowForTable('table-30a', 'btn-insert-table-30a', 'wrapper-table-30a', 4, 'textarea');
    addEventAddAndDeleteRowForTable('table-30b', 'btn-insert-table-30b', 'wrapper-table-30b', 4, 'textarea');
    addEventAddAndDeleteRowForTable('table-28', 'btn-insert-table-28', 'wrapper-table-28', 2, 'textarea');
    addEventAddAndDeleteRowForTable('table-27', 'btn-insert-table-27', 'wrapper-table-27', 5, 'textarea');


    var button = document.getElementById('send');
    button.addEventListener('click', function () {
        submitForm();
    });
});


////
////FUNCTION////
////
function addEventAddAndDeleteRowForTable(tableId, btnInsertId, wraperId, colDataCount, inputElement) {
    // Select the table
    var table31 = document.getElementById(tableId);
    var buttonInsert31 = document.getElementById(btnInsertId);
    var wrapperTable31 = document.getElementById(wraperId);

    // Add the onclick event listener to the button
    buttonInsert31.addEventListener('click', function () {
        var newRow = document.createElement('tr');

        // Create the cells for the new row
        for (var i = 0; i < colDataCount; i++) {
            var newCell = document.createElement('td');
            var newInput = document.createElement(inputElement);
            //newInput.type = 'text';
            newInput.className = 'form-control';
            newCell.appendChild(newInput);
            newRow.appendChild(newCell);
        }
        
        var newButtonDel = document.createElement('button');
        newButtonDel.type = 'button';
        newButtonDel.className = 'btn btn-danger';
        newButtonDel.innerHTML = 'Xóa';
        newButtonDel.addEventListener('click', function () {
            this.parentNode.parentNode.remove();
        });

        var newCell = document.createElement('td');
        newCell.className = 'text-center align-middle';
        newCell.appendChild(newButtonDel);
        newRow.appendChild(newCell);
        
        // Append the new row to the end of the table
        table31.getElementsByTagName('tbody')[0].appendChild(newRow);
    });

    // Add the mouseenter event listener to the wrapper
    wrapperTable31.addEventListener('mouseenter', function () {
        table31.style.marginBottom = '2px'
        buttonInsert31.style.display = 'unset';
    });

    // Add the mouseleave event listener to the wrapper
    wrapperTable31.addEventListener('mouseleave', function () {
        table31.style.marginBottom = 'revert-layer'
        buttonInsert31.style.display = 'none';
    });
}

function tabel31DataToJson(tableId) {
    const table = document.getElementById(tableId);
    const tableBody = table.getElementsByTagName('tbody')[0];
    const rows = tableBody.getElementsByTagName('tr');
    var dataTable = []
    Array.from(rows).forEach((row) => {
        var cols = row.getElementsByTagName('td')
        var dataRow = {
            "thangNam": cols[0].getElementsByTagName('input')[0].value,
            "maSo": cols[1].getElementsByTagName('input')[0].value,
            "bacLuong": cols[2].getElementsByTagName('input')[0].value,
            "heSoLuong": cols[3].getElementsByTagName('input')[0].value
        };
        dataTable.push(dataRow)
    });
    return dataTable;
}

function tabel27DataToJson(tableId) {
    const table = document.getElementById(tableId);
    const tableBody = table.getElementsByTagName('tbody')[0];
    const rows = tableBody.getElementsByTagName('tr');
    var dataJSON = []
    Array.from(rows).forEach((row) => {
        var cols = row.getElementsByTagName('td')
        var dataRow = {
            "tenTruong": cols[0].getElementsByTagName('textarea')[0].value,
            "chuyenNganh": cols[1].getElementsByTagName('textarea')[0].value,
            "khoangThoiGian": cols[2].getElementsByTagName('textarea')[0].value,
            "hinhThucDaoTao": cols[3].getElementsByTagName('textarea')[0].value,
            "vanBangChungChi": cols[4].getElementsByTagName('textarea')[0].value
        };
        dataJSON.push(dataRow)
    });
    return dataJSON;
}

function tabel28DataToJson(tableId) {
    const table = document.getElementById(tableId);
    const tableBody = table.getElementsByTagName('tbody')[0];
    const rows = tableBody.getElementsByTagName('tr');
    var dataTable = []
    Array.from(rows).forEach((row) => {
        var cols = row.getElementsByTagName('td')
        var dataRow = {
            "khoangThoiGian": cols[0].getElementsByTagName('textarea')[0].value,
            "chucDanh": cols[1].getElementsByTagName('textarea')[0].value
        };
        dataTable.push(dataRow)
    });
    return dataTable;
}

function tabel30DataToJson(tableId, laTTQHGDCuaBanThan) {
    const table = document.getElementById(tableId);
    const tableBody = table.getElementsByTagName('tbody')[0];
    const rows = tableBody.getElementsByTagName('tr');
    var dataTable = []
    Array.from(rows).forEach((row) => {
        var cols = row.getElementsByTagName('td')
        var dataRow = {
            "laTTQHGDCuaBanThan": laTTQHGDCuaBanThan,
            "moiQuanHe": cols[0].getElementsByTagName('textarea')[0].value,
            "hoVaTen": cols[1].getElementsByTagName('textarea')[0].value,
            "namSinh": cols[2].getElementsByTagName('textarea')[0].value,
            "thongTinKhac": cols[3].getElementsByTagName('textarea')[0].value
        };
        dataTable.push(dataRow)
    });
    return dataTable;
}

function submitForm() {
    var data = {
        "coQuanQuanLy": document.getElementById('co-quan-quan-ly').value,
        "coQuanSuDung": document.getElementById('don-vi-su-dung-vien-chuc').value,
        "soHieuVienChuc": document.getElementById('so-hieu-vien-chuc').value,
        "hoVaTen": document.getElementById('ho-ten-khai-sinh').value,
        "tenGoiKhac": document.getElementById('ten-khac').value,
        "ngaySinh": document.getElementById('ngay-sinh').value,
        "gioiTinh": $("input[name='gender']:checked").val() === '1' ? true : false,
        "xaNoiSinh": document.getElementById('xa-noi-sinh').value,
        "huyenNoiSinh": document.getElementById('huyen-noi-sinh').value,
        "tinhNoiSinh": document.getElementById('tinh-noi-sinh').value,
        "xaQueQuan": document.getElementById('xa-que-quan').value,
        "huyenQueQuan": document.getElementById('huyen-que-quan').value,
        "tinhQueQuan": document.getElementById('tinh-que-quan').value,
        "danToc": document.getElementById('dan-toc').value,
        "tonGiao": document.getElementById('ton-giao').value,
        "hoKhauThuongTru": document.getElementById('ho-khau').value,
        "noiOHienNay": document.getElementById('noi-o-hien-nay').value,
        "ngheNghiepKhiDuocTuyen": document.getElementById('nghe-nghiep').value,
        "ngayTuyenDung": document.getElementById('ngay-tuyen-dung').value,
        "coQuanTuyenDung": document.getElementById('co-quan-tuyen-dung').value,
        "chucDanhHienTai": document.getElementById('chuc-vu-hien-tai').value,
        "chucDanhKiemNhiem": document.getElementById('chuc-vu-kiem-nhiem').value,
        "congViecChinhDuocGiao": document.getElementById('cong-viec-chinh').value,
        "chucDanhNgheNghiep": document.getElementById('chuc-danh-nghe-nghiep').value,
        "maSoChucDanhNgheNghiep": document.getElementById('ma-so-chuc-danh-nghe-nghiep').value,
        "bacLuong": document.getElementById('bac-luong-chuc-danh-nghe-nghiep').value,
        "heSoLuong": document.getElementById('he-so-luong-chuc-danh-nghe-nghiep').value,
        "ngayHuongBacLuong": document.getElementById('ngay-huong-chuc-danh-nghe-nghiep').value,
        "phuCapChucDanh": document.getElementById('phu-cap-chuc-danh-nghe-nghiep').value,
        "phuCapKhac": document.getElementById('phu-cap-khac-chuc-danh-nghe-nghiep').value,
        "trinhDoGiaoDucPhoThong": document.getElementById('trinh-do-giao-duc-pho-thong').value,
        "trinhDoChuyenMonCaoNhat": document.getElementById('trinh-do-chuyen-mon-cao-nhat').value,
        "trinhDoLyLuanChinhTri": document.getElementById('ly-luan-chinh-tri').value,
        "trinhDoQuanLyNhaNuoc": document.getElementById('quan-ly-nha-nuoc').value,
        "trinhDoNghiepVuChuyenNganh": document.getElementById('trinh-do-nghiep-vu-chuyen-nganh').value,
        "trinhDoNgoaiNgu": document.getElementById('ngoai-ngu').value,
        "trinhDoTinHoc": document.getElementById('tin-hoc').value,
        "ngayVaoDang": document.getElementById('ngay-vao-dang').value,
        "ngayChinhThucVaoDang": document.getElementById('ngaychinhthuc-vao-dang').value,
        "thamGiaToChucCTXH": document.getElementById('thamgia-tochuc-ctxh').value,
        "ngayNhapNgu": document.getElementById('ngay-nhapngu').value,
        "ngayXuatNgu": document.getElementById('ngay-xuatngu').value,
        "quanHamCaoNhat": document.getElementById('quanham-caonhat').value,
        "danhHieuDuocPhongTangCaoNhat": document.getElementById('danhhieu-duocphong-caonhat').value,
        "hocHamDuocPhong": document.getElementById('hocham-duocphong').value,
        "namPhongHocHam": document.getElementById('nam-hocham-duocphong').value,
        "soTruongCongTac": document.getElementById('sotruong-congtac').value,
        "khenThuongCaoNhat": document.getElementById('khen-thuong').value,
        "kyLuat": document.getElementById('ky-luat').value,
        "tinhTrangSucKhoe": document.getElementById('tinhtrang-suckhoe').value,
        "chieuCao": document.getElementById('chieu-cao').value,
        "canNang": document.getElementById('can-nang').value,
        "nhomMau": document.getElementById('nhom-mau').value,
        "laThuongBinhHang": document.getElementById('hang-thuongbinh').value,
        "conGiaDinhChinhSach": document.getElementById('con-giadinh-chinhsach').value,
        "soCCCD": document.getElementById('cancuoc-congdan').value,
        "ngayCapCCCD": document.getElementById('ngaycap-cccd').value,
        "soBHXH": document.getElementById('so-bhxh').value,
        "lichSuBanThan": document.getElementById('lichsu-banthan').value,
        "lichSuThamGiaCacCoQuanNuocNgoai": document.getElementById('lichsu-thamgia-caccoquan-nuocngoai').value,
        "thanNhanONuocNgoai": document.getElementById('thannhan-o-nuocngoai').value,
        "nhanXet": document.getElementById('nhan-xet').value,
        "dsThongTinDaoTaoBoiDuong": tabel27DataToJson('table-27'),
        "dsQuaTrinhCongTac": tabel28DataToJson('table-28'),
        "dsQuanHeGiaDinh": tabel30DataToJson('table-30a', true).concat(tabel30DataToJson('table-30b', false)),
        "dsQuaTrinhLuong": tabel31DataToJson('table-31')
    }

    $.ajax({
        url: '',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(data),
        success: function (response) {
            console.log('Dữ liệu đã được gửi thành công!');
            console.log('Phản hồi từ server:', response);
        },
        error: function (xhr, status, error) {
            console.error('Lỗi trong quá trình gửi dữ liệu:', error);
        }
    });
}