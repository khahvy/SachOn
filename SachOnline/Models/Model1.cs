using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SachOnline.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=SachOnlineModel1")
        {
        }

        public virtual DbSet<CHITIETDATHANG> CHITIETDATHANGs { get; set; }
        public virtual DbSet<CHUDE> CHUDEs { get; set; }
        public virtual DbSet<DONDATHANG> DONDATHANGs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<NHAXUATBAN> NHAXUATBANs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<VIETSACH> VIETSACHes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHITIETDATHANG>()
                .Property(e => e.Dongia)
                .HasPrecision(9, 2);

            modelBuilder.Entity<DONDATHANG>()
                .HasMany(e => e.CHITIETDATHANGs)
                .WithRequired(e => e.DONDATHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.Taikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.Matkhau)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.Dienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<NHAXUATBAN>()
                .Property(e => e.Dienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<SACH>()
                .Property(e => e.Giaban)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SACH>()
                .Property(e => e.Anhbia)
                .IsUnicode(false);

            modelBuilder.Entity<SACH>()
                .HasMany(e => e.CHITIETDATHANGs)
                .WithRequired(e => e.SACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VIETSACH>()
                .HasOptional(e => e.SACH)
                .WithRequired(e => e.VIETSACH);
        }
    }
}
