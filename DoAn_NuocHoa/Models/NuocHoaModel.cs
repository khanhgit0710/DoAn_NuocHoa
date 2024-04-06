using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAn_NuocHoa.Models
{
    public partial class NuocHoaModel : DbContext
    {
        public NuocHoaModel()
            : base("name=NuocHoaDB")
        {
        }

        public virtual DbSet<GioHang> GioHang { get; set; }
        public virtual DbSet<QuanLyUser> QuanLyUser { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GioHang>()
                .Property(e => e.GiaTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<GioHang>()
                .Property(e => e.TongTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<GioHang>()
                .HasOptional(e => e.SanPham)
                .WithRequired(e => e.GioHang);

            modelBuilder.Entity<QuanLyUser>()
                .HasMany(e => e.GioHang)
                .WithRequired(e => e.QuanLyUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.Gia)
                .HasPrecision(18, 0);
        }
    }
}
