Alter table HangHoa
	Alter column MaNV_KiemKe nvarchar(30)
	Alter column Ngay_Kiemke date
Alter table dbo.HangHoa
   Alter column MP_XuatHang nvarchar(100)
Alter table dbo.HangHoa
	Add Foreign Key (MP_XuatHang) References PhieuXuatHang (MaPhieu)
Alter Table HangHoa
	Alter Column MaNV_XuatKho nvarchar(30) 
Alter table HangHoa
	Add Foreign Key (MaNV_XuatKho) References NhanVien (MaNhanVien)
Alter table HangHoa
	Alter column NgayNhapKho date not null