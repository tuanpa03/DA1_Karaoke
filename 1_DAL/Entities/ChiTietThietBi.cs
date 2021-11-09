using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Entities
{
    [Table("ChiTietThietBi")]
    public class ChiTietThietBi
    {
        [Key]
        [Column("IDPhong")]
        [StringLength(20)]
        public string Idphong { get; set; }
        [Key]
        [Column("IDMaTB")]
        [StringLength(30)]
        public string IdmaTb { get; set; }
        public double? DonGia { get; set; }
        public int? SoLuong { get; set; }
        [Column("IDTranngThai")]
        public int? IdtranngThai { get; set; }

        [ForeignKey(nameof(IdmaTb))]
        [InverseProperty(nameof(ThietBi.ChiTietThietBis))]
        public virtual ThietBi IdmaTbNavigation { get; set; }
        [ForeignKey(nameof(Idphong))]
        [InverseProperty(nameof(Phong.ChiTietThietBis))]
        public virtual Phong IdphongNavigation { get; set; }
    }
}
