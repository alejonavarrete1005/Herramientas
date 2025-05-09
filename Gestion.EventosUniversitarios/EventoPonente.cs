using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.EventosUniversitarios
{
    public class EventoPonente
    {
        [ForeignKey("Evento")]
        [Key] public int IdeventoPonente { get; set; }

        [ForeignKey("Ponente")]
        public int Idponente { get; set; }

       

    }
}
