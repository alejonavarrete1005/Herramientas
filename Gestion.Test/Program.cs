using Gestion.APIConsumer;
using Gestion.EventosUniversitarios;

namespace Gestion.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProbarParticipantes();
            ProbarCertificados();
            ProbarEventos();
            ProbarInscripcion();
            ProbarPago();
            ProbarPonente();
            ProbarSesion();
            ProbarEventoPonente();

            Console.ReadLine();
        }

        private static void ProbarParticipantes()
        {
            Crud<Participante>.EndPoint = "https://localhost:7031/api/Participantes";

            
            var participante = Crud<Participante>.Create(new Participante
            {
                Idparticipante = 0,   // para crear un registro nuevo
                Nombre="Steve Rosas",
                Email="rssteve@gmail.com",
                Telefono="0968999754"
            });
            var participantes= Crud<Participante>.GetAll();

            foreach (var p in participantes)
            {
                Console.WriteLine($"Idparticipante: {p.Idparticipante}, Nombre:{p.Nombre}, Email:{p.Email},Telefono:{p.Telefono}");
            }
        }
        private static void ProbarCertificados()
        {
            Crud<Certificado>.EndPoint = "https://localhost:7031/api/Certificados";


            var certificado = Crud<Certificado>.Create(new Certificado
            {
                Idcertificado =0,
                Idevento = 4,
                Idparticipante = 4
                
            });
            var certificados = Crud<Certificado>.GetAll();

            foreach (var c in certificados)
            {
                Console.WriteLine($" Idcertificado:{c.Idcertificado},Idevento:{c.Idevento}, Idparticipante:{c.Idparticipante}");
            }
        }

        private static void ProbarEventos()
        {
            Crud<Evento>.EndPoint = "https://localhost:7031/api/Eventos";


            var evento = Crud<Evento>.Create(new Evento
            {
                Idevento = 0,   
                Nombre = "Paco",
                Fecha = "14 de mayo",
                Lugar = "UTN-colegio",
                Tipo = "Conferencia"
            });
            var eventos = Crud<Evento>.GetAll();

            foreach (var e in eventos)
            {
                Console.WriteLine($"Idevento: {e.Idevento}, Nombre:{e.Nombre}, Fecha:{e.Fecha},Lugar:{e.Lugar}, Tipo:{e.Tipo}");
            }
        }
        private static void ProbarInscripcion()
        {
            Crud<Inscripcion>.EndPoint = "https://localhost:7031/api/Inscripciones";


            var inscripcion = Crud<Inscripcion>.Create(new Inscripcion
            {
                Idinscripcion = 0,
                Idevento = 1,
                Idparticipante = 1,
                Fecha = "11 de mayo",
                Estado = "aceptado"
            });
            var inscripciones = Crud<Inscripcion>.GetAll();

            foreach (var i in inscripciones)
            {
                Console.WriteLine($"Idinscripcion:{i.Idinscripcion}, Idevento: {i.Idevento}, Idparticipante:{i.Idparticipante}, Fecha:{i.Fecha}, Estado:{i.Estado}");
            }
        }
        private static void ProbarPago()
        {
            Crud<Pago>.EndPoint = "https://localhost:7031/api/Pagos";


            var pago = Crud<Pago>.Create(new Pago
            {
                Idpago = 0,
                Idinscripcion = 1,
                Monto = 1,
                MedioPago ="Efectivo",
                Fecha = "11 de mayo"
            });
            var pagos = Crud<Pago>.GetAll();

            foreach (var pg in pagos)
            {
                Console.WriteLine($"Idpago:{pg.Idpago}, Idinscripcion:{pg.Idinscripcion}, Monto:{pg.Monto}, MedioPago:{pg.MedioPago}, Fecha:{pg.Fecha},");
            }
        }
        private static void ProbarPonente()
        {
            Crud<Ponente>.EndPoint = "https://localhost:7031/api/Ponentes";


            var ponente = Crud<Ponente>.Create(new Ponente
            {
                Idponente = 0,
                Nombre="Luis",
                Email="luis@gmail.com"
            });
            var ponentes = Crud<Ponente>.GetAll();

            foreach (var pn in ponentes)
            {
                Console.WriteLine($"Idponente:{pn.Idponente}, Nombre:{pn.Nombre}, Email:{pn.Email}");
            }
        }
        private static void ProbarSesion()
        {
            Crud<Sesion>.EndPoint = "https://localhost:7031/api/Sesiones";


            var sesion = Crud<Sesion>.Create(new Sesion
            {
                Id = 0,
                HoraInicio = "1pm",
                HoraFin = "3pm",
                Sala = 5,
                Idevento =4
            });
            var sesiones = Crud<Sesion>.GetAll();

            foreach (var s in sesiones)
            {
                Console.WriteLine($"Id:{s.Id}, Inicio:{s.HoraInicio}, Fin:{s.HoraFin}, Sala:{s.Sala}, Idevento:{s.Idevento}");
            }
        }
        private static void ProbarEventoPonente()
        {
            Crud<EventoPonente>.EndPoint = "https://localhost:7031/api/EventosPonentes";


            var eventoponente = Crud<EventoPonente>.Create(new EventoPonente
            {
                IdeventoPonente = 0,
                Idponente = 1
            });
            var eventosponentes = Crud<EventoPonente>.GetAll();

            foreach (var ep in eventosponentes)
            {
                Console.WriteLine($"IdeventoPonente:{ep.IdeventoPonente}, Idponente: {ep.Idponente}");
            }
        }
    }
}
