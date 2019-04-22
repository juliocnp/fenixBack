namespace fenixBack.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    using Newtonsoft.Json;
    using System.Linq;
    using System.Web;

    [Table("Visita")]
    public partial class Visita
    {
        [Key]
        public int idVisita { get; set; }

        [Required]
        [StringLength(255)]
        public string nomeVisitante { get; set; }

        [StringLength(20)]
        public string cpfVisitante { get; set; }

        [StringLength(20)]
        public string TELVisitante { get; set; }

        [Column(TypeName = "date")]
        public DateTime dataVisita { get; set; }

        public TimeSpan horaVisita { get; set; }

        public int? idJovemVisitado { get; set; }

        public int? numOrdemJudicial { get; set; }

        public short? tipoVisita { get; set; }
    }
}
