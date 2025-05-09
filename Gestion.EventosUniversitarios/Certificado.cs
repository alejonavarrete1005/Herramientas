using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.EventosUniversitarios
{
    public class Certificado
    {
        [Key] public int Idcertificado { get; set; }
        [ForeignKey("Evento")]
        public int Idevento { get; set; }
        [ForeignKey("Participante")]
        public int Idparticipante { get; set; }


        



    }
}
