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

    [Table("Caixa")]
    public partial class Caixa
    {
        public int ID_TRANSACAO { get; set; }

        public DateTime DATA { get; set; }

        public string DESCRICAO { get; set; }

        public decimal VALOR { get; set; }

        public string tipoTransacao { get; set; }
    }
}
