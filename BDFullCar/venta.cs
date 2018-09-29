namespace BDFullCar
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("venta")]
    public partial class venta
    {
        [Key]
        public int ven_id { get; set; }

        public int ven_id_cliente { get; set; }

        public int ven_id_lavador { get; set; }

        public int? ven_valor { get; set; }

        public DateTime? ven_fecha_entrada { get; set; }

        public DateTime? ven_fecha_salida { get; set; }

        public int? ven_ser_tiposervicio { get; set; }

        [StringLength(1)]
        public string adicional { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Lavador Lavador { get; set; }

        public virtual Servicio Servicio { get; set; }
    }
}
