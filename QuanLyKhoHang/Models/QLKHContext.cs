using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using QuanLyKhoHang.Common;
using QuanLyKhoHang.Models.Views;

#nullable disable

namespace QuanLyKhoHang.Models
{
    public partial class QLKHContext : DbContext
    {
        public QLKHContext()
        {
        }

        public QLKHContext(DbContextOptions<QLKHContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<HangNhap> HangNhaps { get; set; }
        public virtual DbSet<MatHang> MatHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhomNhanVien> NhomNhanViens { get; set; }
        public virtual DbSet<PhieuNhapHang> PhieuNhapHangs { get; set; }
        public virtual DbSet<PhieuXuatHang> PhieuXuatHangs { get; set; }
        public virtual DbSet<TinhTrang> TinhTrangs { get; set; }
        public virtual DbSet<viewDanhsachNhapHang> DanhsachNhapHangs { get; set; }
        public virtual DbSet<viewDanhSachMatHangNhapKho> DanhSachMatHangNhapKhos { get; set; }

        public virtual DbSet<viewNhanVienNhapHang> NhanVienNhapHangs { get; set; }

        public virtual DbSet<viewNV_chitiethanghoatrongdon> NV_ChiTietHangHoaTrongDon { get; set; }

        public virtual DbSet<viewNV_PhieuXuatHang> NV_PhieuXuatHangs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
/*#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
*/                optionsBuilder.UseSqlServer("Server=.;Database=QLKH;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HangHoa>(entity =>
            {
                entity.HasKey(e => e.MaHangHoa)
                    .HasName("PK__HangHoa__9737FBA87C400A1C");

                entity.ToTable("HangHoa");

                entity.Property(e => e.MaHangHoa).HasMaxLength(100);

                entity.Property(e => e.HanSuDung).HasColumnType("date");

                entity.Property(e => e.MaMatHang).HasMaxLength(100);

                entity.Property(e => e.MaNvKiemKe)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("MaNV_KiemKe");

                entity.Property(e => e.MaNvNhapKho)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("MaNV_NhapKho");

                entity.Property(e => e.MaNvXuatKho)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("MaNV_XuatKho");

                entity.Property(e => e.MpNhapHang)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("MP_NhapHang");

                entity.Property(e => e.MpXuatHang)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("MP_XuatHang");

                entity.Property(e => e.NgayKiemKe)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_KiemKe");

                entity.Property(e => e.NgayNhapKho).HasColumnType("smalldatetime");

                entity.Property(e => e.NgaySanXuat).HasColumnType("date");

                entity.Property(e => e.ViTri).HasMaxLength(100);

                entity.HasOne(d => d.MaMatHangNavigation)
                    .WithMany(p => p.HangHoas)
                    .HasForeignKey(d => d.MaMatHang)
                    .HasConstraintName("FK__HangHoa__MaMatHa__34C8D9D1");

                entity.HasOne(d => d.MaNvNhapKhoNavigation)
                    .WithMany(p => p.HangHoaMaNvNhapKhoNavigations)
                    .HasForeignKey(d => d.MaNvNhapKho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HangHoa__MaNV_Nh__37A5467C");

                entity.HasOne(d => d.MaNvXuatKhoNavigation)
                    .WithMany(p => p.HangHoaMaNvXuatKhoNavigations)
                    .HasForeignKey(d => d.MaNvXuatKho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HangHoa__MaNV_Xu__38996AB5");

                entity.HasOne(d => d.MpNhapHangNavigation)
                    .WithMany(p => p.HangHoas)
                    .HasForeignKey(d => d.MpNhapHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HangHoa__MP_Nhap__35BCFE0A");

                entity.HasOne(d => d.MpXuatHangNavigation)
                    .WithMany(p => p.HangHoas)
                    .HasForeignKey(d => d.MpXuatHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HangHoa__MP_Xuat__36B12243");
            });

            modelBuilder.Entity<HangNhap>(entity =>
            {
                entity.HasKey(e => new { e.MpNhap, e.MaHangNhap })
                    .HasName("PK__HangNhap__2819BC11E7E772AD");

                entity.ToTable("HangNhap");

                entity.Property(e => e.MpNhap)
                    .HasMaxLength(100)
                    .HasColumnName("MP_Nhap");

                entity.Property(e => e.MaHangNhap).HasMaxLength(100);

                entity.HasOne(d => d.MaHangNhapNavigation)
                    .WithMany(p => p.HangNhaps)
                    .HasForeignKey(d => d.MaHangNhap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HangNhap__MaHang__31EC6D26");

                entity.HasOne(d => d.MpNhapNavigation)
                    .WithMany(p => p.HangNhaps)
                    .HasForeignKey(d => d.MpNhap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HangNhap__MP_Nha__30F848ED");
            });

            modelBuilder.Entity<MatHang>(entity =>
            {
                entity.HasKey(e => e.MaMatHang)
                    .HasName("PK__MatHang__A92254E557835CE9");

                entity.ToTable("MatHang");

                entity.Property(e => e.MaMatHang).HasMaxLength(100);

                entity.Property(e => e.GiaTri).HasColumnType("money");

                entity.Property(e => e.MoTa).HasMaxLength(200);

                entity.Property(e => e.NhaSanXuat).HasMaxLength(50);

                entity.Property(e => e.NvTao)
                    .HasMaxLength(30)
                    .HasColumnName("NV_Tao");

                entity.Property(e => e.TenMatHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.NvTaoNavigation)
                    .WithMany(p => p.MatHangs)
                    .HasForeignKey(d => d.NvTao)
                    .HasConstraintName("FK__MatHang__NV_Tao__2E1BDC42");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK__NhanVien__77B2CA476002059F");

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNhanVien).HasMaxLength(30);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdNhom)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("ID_Nhom");

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.QueQuan).HasMaxLength(100);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.SoCmnd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("So_CMND");

                entity.Property(e => e.TenDangNhap)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenNhanVien)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdNhomNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdNhom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NhanVien__ID_Nho__25869641");
            });

            modelBuilder.Entity<NhomNhanVien>(entity =>
            {
                entity.ToTable("NhomNhanVien");

                entity.Property(e => e.Id)
                    .HasMaxLength(30)
                    .HasColumnName("ID");

                entity.Property(e => e.TenNhom)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PhieuNhapHang>(entity =>
            {
                entity.HasKey(e => e.MaPhieu)
                    .HasName("PK__PhieuNha__2660BFE0D2FCC68A");

                entity.ToTable("PhieuNhapHang");

                entity.Property(e => e.MaPhieu).HasMaxLength(100);

                entity.Property(e => e.MoTa).HasMaxLength(200);

                entity.Property(e => e.NgayNhap).HasColumnType("smalldatetime");

                entity.Property(e => e.NhanVienNhap)
                    .HasMaxLength(30)
                    .HasColumnName("NhanVien_Nhap");

                entity.HasOne(d => d.NhanVienNhapNavigation)
                    .WithMany(p => p.PhieuNhapHangs)
                    .HasForeignKey(d => d.NhanVienNhap)
                    .HasConstraintName("FK__PhieuNhap__NhanV__286302EC");
            });

            modelBuilder.Entity<PhieuXuatHang>(entity =>
            {
                entity.HasKey(e => e.MaPhieu)
                    .HasName("PK__PhieuXua__2660BFE0FDA7A314");

                entity.ToTable("PhieuXuatHang");

                entity.Property(e => e.MaPhieu).HasMaxLength(100);

                entity.Property(e => e.MoTa).HasMaxLength(200);

                entity.Property(e => e.NgayTao).HasColumnType("smalldatetime");

                entity.Property(e => e.NgayXuatDuKien)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("NgayXuat_DuKien");

                entity.Property(e => e.NgayXuatThucTe)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("NgayXuat_ThucTe");

                entity.Property(e => e.NhanVienXuat)
                    .HasMaxLength(30)
                    .HasColumnName("NhanVien_Xuat");

                entity.HasOne(d => d.NhanVienXuatNavigation)
                    .WithMany(p => p.PhieuXuatHangs)
                    .HasForeignKey(d => d.NhanVienXuat)
                    .HasConstraintName("FK__PhieuXuat__NhanV__2B3F6F97");
            });

            modelBuilder.Entity<TinhTrang>(entity =>
            {
                entity.HasKey(e => e.MaTinhTrang)
                    .HasName("PK__TinhTran__89F8F6696E8598BB");

                entity.ToTable("TinhTrang");

                entity.Property(e => e.MaTinhTrang).HasMaxLength(50);

                entity.Property(e => e.MaHangHoa)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ma_HangHoa");

                entity.Property(e => e.TenTinhTrang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaHangHoaNavigation)
                    .WithMany(p => p.TinhTrangs)
                    .HasForeignKey(d => d.MaHangHoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TinhTrang__Ma_Ha__3B75D760");
            });
            modelBuilder.Entity<viewDanhsachNhapHang>(entity =>
            {
                entity.ToTable("viewDanhSachNhapHang");
                entity.HasNoKey();
            });
            modelBuilder.Entity<viewDanhSachMatHangNhapKho>(entity =>
            {
                entity.ToTable("viewDanhSachMatHangNhapKho");
                entity.HasNoKey();
            });
            modelBuilder.Entity<viewNhanVienNhapHang>(entity =>
            {
                entity.ToTable("Nv_NhapHang");
                entity.HasNoKey();
            });

            modelBuilder.Entity<viewNV_chitiethanghoatrongdon>(entity =>
            {
                entity.ToTable("Proc_NV_ChiTietDonHang");
                entity.HasNoKey();
            });

            modelBuilder.Entity<viewNV_PhieuXuatHang>(entity =>
            {
                entity.ToTable("view_NVDonXuatHang");
                entity.HasNoKey();
            });
           
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
