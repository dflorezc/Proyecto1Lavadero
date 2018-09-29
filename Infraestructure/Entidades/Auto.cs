namespace Infraestructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Auto")]
    public partial class Auto
    {
        [Key]
        public int aut_id { get; set; }

        public int aut_id_cliente { get; set; }

        [StringLength(50)]
        public string aut_Placa { get; set; }

        [StringLength(50)]
        public string aut_color { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
