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

    [Table("EstoqueCat")]
    public partial class EstoqueCat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstoqueCat()
        {
            //Estoque = new HashSet<Estoque>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(45)]
        public string nomeCategoria { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Estoque> Estoque { get; set; }
    }
}
