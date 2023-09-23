namespace SachOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONDATHANG")]
    public partial class DONDATHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONDATHANG()
        {
            CHITIETDATHANGs = new HashSet<CHITIETDATHANG>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDonHang { get; set; }

        public bool? Dathanhtoan { get; set; }

        public int? Tinhtranggiaohang { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Ngaydat { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Ngaygiao { get; set; }

        public int? MaKH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDATHANG> CHITIETDATHANGs { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
