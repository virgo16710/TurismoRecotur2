using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recotur2.Models
{
    /*
     * DCandidato es una clase en donde ira el posible usuario a ser guardado, distinto es de Reco_User que es un DBContext
     */
    public class DCandidato
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string CanNombre { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string email { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string pass { get; set; }
    }
}
