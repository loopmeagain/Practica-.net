using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pract.Models
{
    public class Paciente
    {
        public long Id { get; set; }
        public virtual List<Enfermedad> Enfermedades { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public long Dni { get; set; }
        public List<Consulta> Historial {get; set; }

    }
}