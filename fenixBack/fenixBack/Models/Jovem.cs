using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fenixBack.Models
{
    public class Jovem
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int? idade { get; set; }
        public string possuiTranstorno { get; set; }
        public string descricaoTranstorno { get; set; }
        public string descricaoEstadoSaude { get; set; }
        public string sexo { get; set; }
        public DateTime? dataNascimento { get; set; }
        public bool? ligadoDesligado { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string endereco { get; set; }
        public DateTime? dataEntrada { get; set; }
        public DateTime? dataSaida { get; set; }
        public string cep { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string responsavel { get; set; }
        public string outroResponsavel { get; set; }
        public string nomeResponsavel { get; set; }
        public string motivoSaida { get; set; }
    }
}