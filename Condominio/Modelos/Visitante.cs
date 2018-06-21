using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Visitante
    {
        public String PresencaV { get; set; }

        [Key]
        public String PlacaVId { get; set; }

        public String CarroV { get; set; }

        public String NomeV { get; set; }

        public String TelefoneV { get; set; }

        public String Visita { get; set; }
    }
}
