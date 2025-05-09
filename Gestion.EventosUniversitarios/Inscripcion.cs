using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.EventosUniversitarios
{
    public class Inscripcion
    {
        [Key] public int Idinscripcion { get; set; }

        [ForeignKey("Evento")]
        public int Idevento { get; set; }

        [ForeignKey("Participante")]
        public int Idparticipante { get; set; }
        public string Fecha { get; set; }
        public string Estado { get; set; }

        
    }
}
