namespace SachOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETDATHANG")]
    public partial class CHITIETDATHANG
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDonHang { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Masach { get; set; }

        public int? Soluong { get; set; }

        public decimal? Dongia { get; set; }

        public virtual DONDATHANG DONDATHANG { get; set; }

        public virtual SACH SACH { get; set; }
    }
}
