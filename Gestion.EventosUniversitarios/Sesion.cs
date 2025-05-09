using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.EventosUniversitarios
{
    public class Sesion
    {
        [Key] public int Id { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin {  get; set; }
        public int Sala { get; set; }

        [ForeignKey("Evento")]
        public int Idevento { get; set; }
        

    }
}
