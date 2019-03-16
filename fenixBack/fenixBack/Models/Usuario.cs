using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fenixBack.Models
{
    public class Usuario
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public DateTime data_nascimento { get; set; }
        public string tipoUsuario { get; set; }
    }
}