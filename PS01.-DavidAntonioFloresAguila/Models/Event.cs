using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PS01._DavidAntonioFloresAguila.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public string Invitado { get; set; }
        public DateTime Fecha { get; set; }
        public string Negocio { get; set; }
        public City IDCiudad { get; set; }
    }
}