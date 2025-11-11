using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroAdopcionApp.Entidad
{
    public class Adopcion
    {
        public int IdAdopcion { get; set; }
        public int IdAdoptante { get; set; }
        public int IdMascota { get; set; }
        public DateTime FechaAdopcion { get; set; }
        public string Observacion { get; set; }

    }
}
