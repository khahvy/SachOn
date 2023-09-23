namespace SachOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            CHITIETDATHANGs = new HashSet<CHITIETDATHANG>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Masach { get; set; }

        [StringLength(100)]
        public string Tensach { get; set; }

        [Column(TypeName = "money")]
        public decimal? Giaban { get; set; }

        [Column(TypeName = "ntext")]
        public string Mota { get; set; }

        [StringLength(50)]
        public string Anhbia { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Ngaycapnhat { get; set; }

        public int? Soluongban { get; set; }

        public int? MaCD { get; set; }

        public int? MaNXB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDATHANG> CHITIETDATHANGs { get; set; }

        public virtual CHUDE CHUDE { get; set; }

        public virtual NHAXUATBAN NHAXUATBAN { get; set; }

        public virtual VIETSACH VIETSACH { get; set; }
    }
}
