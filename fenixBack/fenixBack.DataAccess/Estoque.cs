//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fenixBack.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estoque
    {
        public int id { get; set; }
        public int idCategoria { get; set; }
        public string descricao { get; set; }
        public Nullable<System.DateTime> dataValidade { get; set; }
        public Nullable<int> unidade { get; set; }
    
        public virtual EstoqueCat EstoqueCat { get; set; }
    }
}