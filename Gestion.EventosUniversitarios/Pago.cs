using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.EventosUniversitarios
{
    public class Pago
    {
        [Key] public int Idpago { get; set; }
        [ForeignKey("Inscripcion")]
        public int Idinscripcion { get; set; }
        public int Monto { get; set; }
        public string MedioPago { get; set; }
        public String Fecha { get; set; }

        
    }
}
