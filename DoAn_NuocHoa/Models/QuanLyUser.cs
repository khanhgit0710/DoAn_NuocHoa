namespace DoAn_NuocHoa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuanLyUser")]
    public partial class QuanLyUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuanLyUser()
        {
            GioHang = new HashSet<GioHang>();
        }

        [Required]
        [StringLength(250)]
        public string Gmail { get; set; }

        [Required]
        [StringLength(250)]
        public string Pass { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GioHang> GioHang { get; set; }
    }
}
