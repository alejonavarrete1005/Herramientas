using System.ComponentModel.DataAnnotations;

namespace Gestion.EventosUniversitarios
{
    public class Evento
    {
        [Key] public int Idevento { get; set; }
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public string Lugar { get; set; }
        public string Tipo { get; set; }

        public List<Sesion>? Sesiones { get; set; }
        public List<Inscripcion>? Inscripciones { get; set; }
        public List<Certificado>? Certificados { get; set; }

    }
}
