namespace DoAn_NuocHoa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("SanPham")]
    public partial class SanPham
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Ten { get; set; }

        [Required]
        [StringLength(250)]
        public string Loai { get; set; }

        [Required]
        [StringLength(1000)]
        public string MoTa { get; set; }

        public decimal Gia { get; set; }

        public virtual GioHang GioHang { get; set; }

        public decimal SoLgTon { get; set; }
        public string Hinh { get; set; }

        public static List<SanPham> GetAll()
        {
            NuocHoaModel context = new NuocHoaModel();
            return context.SanPham.ToList();
        }

        public static SanPham FindById(int id)
        {
            NuocHoaModel context = new NuocHoaModel();
            return context.SanPham.FirstOrDefault(p => p.Id == id);
        }

        public void Insert()
        {
            NuocHoaModel context = new NuocHoaModel();
            try
            {
                context.SanPham.Add(this);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
