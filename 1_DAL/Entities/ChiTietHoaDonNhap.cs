﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Entities
{
    [Table("ChiTietHoaDonNhap")]
    public class ChiTietHoaDonNhap
    {
        [Key]
        [Column("IDHoaDon")]
        public int IdhoaDon { get; set; }
        [Key]
        [Column("IDMatHang")]
        public int IdmatHang { get; set; }
        public int? SoLuong { get; set; }
        public double? DonGiaNhap { get; set; }
        [Column("IDTranngThai")]
        [StringLength(10)]
        public string IdtranngThai { get; set; }

        [ForeignKey(nameof(IdhoaDon))]
        [InverseProperty(nameof(HoaDonNhap.ChiTietHoaDonNhaps))]
        public virtual HoaDonNhap IdhoaDonNavigation { get; set; }
        [ForeignKey(nameof(IdmatHang))]
        [InverseProperty(nameof(MatHang.ChiTietHoaDonNhaps))]
        public virtual MatHang IdmatHangNavigation { get; set; }
    }
}
