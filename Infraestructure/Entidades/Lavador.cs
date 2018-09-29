namespace Infraestructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lavador")]
    public partial class Lavador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lavador()
        {
            Turno = new HashSet<Turno>();
            venta = new HashSet<venta>();
        }

        [Key]
        public int lav_id { get; set; }

        [StringLength(50)]
        public string lav_nombre { get; set; }

        [Required]
        [StringLength(15)]
        public string lav_cedula { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? lav_telefono { get; set; }

        public DateTime? lav_fecha_ingreso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turno> Turno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta> venta { get; set; }
    }
}
