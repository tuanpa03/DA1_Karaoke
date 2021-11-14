using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Entities
{
    [Table("HoaDonBanHang")]
    public class HoaDonBanHang
    {
        public HoaDonBanHang()
        {
            ChiTietHoaDonBans = new HashSet<ChiTietHoaDonBan>();
        }

        [Column("IDMaKH")]
        [StringLength(30)]
        public string IdmaKh { get; set; }
        [Key]
        [Column("IDHoaDon")]
        public int IdhoaDon { get; set; }
        [Column("IDPhong")]
        [StringLength(20)]
        public int? Idphong { get; set; }
        [Column("IDMaNV")]
        [StringLength(30)]
        public string IdmaNv { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThoiGianBatDau { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThoiGianKetThuc { get; set; }
        public double? DonGiaPhong { get; set; }
        [StringLength(50)]
        public string NguoiBan { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayTao { get; set; }
        [StringLength(50)]
        public string NguoiTao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayCapNhap { get; set; }
        [StringLength(50)]
        public string NguoiCapNhap { get; set; }
        [Column("IDTranngThai")]
        public int? IdtranngThai { get; set; }

        [ForeignKey(nameof(IdmaKh))]
        [InverseProperty(nameof(KhachHang.HoaDonBanHangs))]
        public virtual KhachHang IdmaKhNavigation { get; set; }
        [ForeignKey(nameof(IdmaNv))]
        [InverseProperty(nameof(NhanVien.HoaDonBanHangs))]
        public virtual NhanVien IdmaNvNavigation { get; set; }
        [ForeignKey(nameof(Idphong))]
        [InverseProperty(nameof(Phong.HoaDonBanHangs))]
        public virtual Phong IdphongNavigation { get; set; }
        [InverseProperty(nameof(ChiTietHoaDonBan.IdhoaDonNavigation))]
        public virtual ICollection<ChiTietHoaDonBan> ChiTietHoaDonBans { get; set; }
    }
}
