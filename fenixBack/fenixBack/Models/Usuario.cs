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

    [Table("Usuario")]
    public partial class Usuario
    {
        public int id { get; set; }

        [StringLength(255)]
        public string nome { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(45)]
        public string senha { get; set; }

        public DateTime? data_nascimento { get; set; }

        public int? tipoUsuario { get; set; }

        public bool ligadoDesligado { get; set; }

        [Column("usuario")]
        [Required]
        [StringLength(45)]
        public string usuario1 { get; set; }

        [Required]
        [StringLength(45)]
        public string cpf { get; set; }

        [Required]
        [StringLength(45)]
        public string cep { get; set; }

        [StringLength(300)]
        public string logradouro { get; set; }

        [StringLength(300)]
        public string complemento { get; set; }

        [StringLength(300)]
        public string bairro { get; set; }

        [StringLength(300)]
        public string localidade { get; set; }

        [StringLength(5)]
        public string uf { get; set; }

        public DateTime? dataEntrada { get; set; }

        public DateTime? dataSaida { get; set; }

        [StringLength(1)]
        public string sexo { get; set; }

        public virtual TipoUsuario TipoUsuario1 { get; set; }
    }
}
