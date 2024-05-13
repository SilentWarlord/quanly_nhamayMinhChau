-- Tạo bảng Sản phẩm
CREATE TABLE SanPham (
    MaSanPham VARCHAR(50) PRIMARY KEY,
    HinhAnhSanPham VARCHAR(255),
    TenSanPham VARCHAR(255),
    SoLuongTon INT,
    MoTaSanPham TEXT
);

-- Tạo bảng Đặc tả dữ liệu sản phẩm
CREATE TABLE SanPham (
    MaSanPham VARCHAR(50) PRIMARY KEY,
    TenSanPham VARCHAR(255),
    SoLuongTon INT,
    MoTaSanPham TEXT
);

-- Tạo bảng Nhân viên
CREATE TABLE NhanVien (
    MaNhanVien VARCHAR(50) PRIMARY KEY,
    TenNhanVien VARCHAR(255),
    ChucVu VARCHAR(100),
    SoDienThoai VARCHAR(20),
    DiaChiEmail VARCHAR(255),
    NgaySinh DATE,
    NgayBatDauLamViec DATE,
    Password VARCHAR(255),
    LuongCoBan INT
);

-- Tạo bảng Đặc tả dữ liệu nhân viên
CREATE TABLE NhanVien (
    MaNhanVien VARCHAR(50) PRIMARY KEY,
    TenNhanVien VARCHAR(255),
    ChucVu VARCHAR(100),
    SoDienThoai VARCHAR(20),
    DiaChiEmail VARCHAR(255),
    NgaySinh DATE,
    NgayBatDauLamViec DATE,
    Password VARCHAR(255),
    LuongCoBan INT
);

-- Tạo bảng Khách hàng
CREATE TABLE KhachHang (
    MaKhachHang VARCHAR(50) PRIMARY KEY,
    HoTen VARCHAR(255),
    DiaChi VARCHAR(255),
    SoDienThoai VARCHAR(20),
    DiaChiEmail VARCHAR(255),
    NgaySinh DATE,
    GioiTinh VARCHAR(10)
);

-- Tạo bảng Hóa đơn
CREATE TABLE HoaDon (
    MaHoaDon VARCHAR(50) PRIMARY KEY,
    MaKhachHang VARCHAR(50),
    MaNhanVien VARCHAR(50),
    NgayTao DATETIME,
    TongCong INT,
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Tạo bảng Chi tiết hóa đơn
CREATE TABLE ChiTietHoaDon (
    MaHoaDon VARCHAR(50),
    TenSanPham VARCHAR(255),
    SoLuong INT,
    DonGia INT,
    TongCong INT,
    PRIMARY KEY (MaHoaDon, TenSanPham),
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon)
);

-- Tạo bảng Thống kê
CREATE TABLE ThongKe (
    DoanhSo INT,
    DoanhThu INT,
    TongDon INT
);

-- Tạo bảng Nguyên vật liệu
CREATE TABLE NguyenVatLieu (
    MaNguyenVatLieu VARCHAR(50) PRIMARY KEY,
    TenNguyenVatLieu VARCHAR(255),
    SoLuongTonKho INT,
    DonViDoLuong VARCHAR(50),
    GiaThanh INT
);
