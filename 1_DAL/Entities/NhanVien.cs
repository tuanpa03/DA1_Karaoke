using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Entities
{
    [Table("NhanVien")]
    public class NhanVien
    {
        public NhanVien()
        {
            HoaDonBanHangs = new HashSet<HoaDonBanHang>();
            HoaDonNhaps = new HashSet<HoaDonNhap>();
        }

        [StringLength(30)]
        public string Username { get; set; }
        public string Password { get; set; }
        [Column("IDChucVu")]
        public int? IdchucVu { get; set; }
        [Key]
        [Column("MaNV")]
        [StringLength(30)]
        public string MaNv { get; set; }
        [StringLength(20)]
        public string Ho { get; set; }
        [StringLength(20)]
        public string TenDem { get; set; }
        [StringLength(20)]
        public string Ten { get; set; }
        public int? GioiTinh { get; set; }
        [StringLength(20)]
        public string DienThoai { get; set; }
        [Column("CMND")]
        [StringLength(50)]
        public string Cmnd { get; set; }
        [StringLength(150)]
        public string DiaChi { get; set; }
        [Column("IDTranngThai")]
        public int? IdtranngThai { get; set; }

        [ForeignKey(nameof(IdchucVu))]
        [InverseProperty(nameof(ChucVu.NhanViens))]
        public virtual ChucVu IdchucVuNavigation { get; set; }
        [InverseProperty(nameof(HoaDonBanHang.IdmaNvNavigation))]
        public virtual ICollection<HoaDonBanHang> HoaDonBanHangs { get; set; }
        [InverseProperty(nameof(HoaDonNhap.IdnhanVienNhapNavigation))]
        public virtual ICollection<HoaDonNhap> HoaDonNhaps { get; set; }
    }
}
