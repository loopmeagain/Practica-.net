using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pract.Models
{
    public class PacienteModel
    {
        public long Id { get; set; }
        public virtual List<Enfermedad> Enfermedades { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public long Dni { get; set; }
        public List<Consulta> Historial { get; set; }

        public List<long> EnfermedadesId { get; set; }
        public SelectList EnfermedadesSelect { get; set; }
    }
}