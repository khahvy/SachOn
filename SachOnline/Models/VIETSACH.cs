namespace SachOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VIETSACH")]
    public partial class VIETSACH
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTG { get; set; }

        public int? Masach { get; set; }

        [StringLength(30)]
        public string Vaitro { get; set; }

        [StringLength(30)]
        public string Vitri { get; set; }

        public virtual SACH SACH { get; set; }
    }
}
