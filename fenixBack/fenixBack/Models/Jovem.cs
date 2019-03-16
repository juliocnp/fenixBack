using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fenixBack.Models
{
    public class Jovem
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public char possuiTranstorno { get; set; }
        public string descricaoTranstorno { get; set; }
        public string descricaoEstadoSaudo { get; set; }
        public char sexo { get; set; }
        public DateTime dataNascimento { get; set; }
        public bool ligadoDesligado { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string endereco { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime dataSaida { get; set; }
    }
}