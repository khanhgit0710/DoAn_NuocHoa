namespace DoAn_NuocHoa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GioHang")]
    public partial class GioHang
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string TenSanPham { get; set; }

        public decimal GiaTien { get; set; }

        public decimal TongTien { get; set; }

        public int IdUser { get; set; }
        public decimal SoLuong { get; set; }

        public virtual QuanLyUser QuanLyUser { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
