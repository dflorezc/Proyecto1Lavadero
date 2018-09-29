namespace Infraestructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        public int usu_id { get; set; }

        [Required]
        [StringLength(15)]
        public string usu_cedula { get; set; }

        [StringLength(50)]
        public string usu_contrasena { get; set; }

        [StringLength(30)]
        public string usu_nombre { get; set; }
    }
}
