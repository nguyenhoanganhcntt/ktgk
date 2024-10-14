using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace De02.Models
{
    public partial class SanphamDBContext : DbContext
    {
        public SanphamDBContext()
            : base("name=SanphamDBContext")
        {
        }

        public virtual DbSet<LoaiSP> LoaiSP { get; set; }
        public virtual DbSet<Sanpham> Sanpham { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiSP>()
                .Property(e => e.MaLoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sanpham>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sanpham>()
                .Property(e => e.MaLoai)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
