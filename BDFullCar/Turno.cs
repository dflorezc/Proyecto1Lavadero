namespace BDFullCar
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Turno")]
    public partial class Turno
    {
        [Key]
        public int tur_id { get; set; }

        public int tur_id_lavador { get; set; }

        public int? tur_numero_turno { get; set; }

        public DateTime? tur_fecha_ingreso { get; set; }

        public DateTime? tur_fecha_salida { get; set; }

        public virtual Lavador Lavador { get; set; }
    }
}
