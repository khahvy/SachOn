namespace SachOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            DONDATHANGs = new HashSet<DONDATHANG>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaKH { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(15)]
        public string Taikhoan { get; set; }

        [StringLength(15)]
        public string Matkhau { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Diachi { get; set; }

        [StringLength(10)]
        public string Dienthoai { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Ngaysinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONDATHANG> DONDATHANGs { get; set; }
    }
}
