using System;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
     public class Morador
    {

        public String PresencaM { get; set; }

        [Key]
        public String  PlacaMId { get; set; }

        public String  CarroM { get; set; }
         
        public String NomeM { get; set; }

        public String TelefoneM { get; set; }

        public  String  Casa_numM { get; set; }
        
        public String StatusM { get; set; }
    }
}
