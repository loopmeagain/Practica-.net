using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pract.Models
{
    public class Enfermedad
    {
        public Enfermedad(long id,string nombre,string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
        }
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}