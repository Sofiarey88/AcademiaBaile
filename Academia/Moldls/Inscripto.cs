using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Moldls
{
    public class Inscripto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Edad {  get; set; }

        public int? RitmoId { get; set; }
        public Ritmo Ritmo { get; set; }
        
        public int? Profesorid { get; set; }
        public Profesor Profesor { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
