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

    [Table("Estoque")]
    public partial class Estoque
    {
        public int id { get; set; }

        public int idCategoria { get; set; }

        [Required]
        [StringLength(45)]
        public string descricao { get; set; }

        public DateTime? dataValidade { get; set; }

        public int? unidade { get; set; }

        public virtual EstoqueCat EstoqueCat { get; set; }
    }
}
