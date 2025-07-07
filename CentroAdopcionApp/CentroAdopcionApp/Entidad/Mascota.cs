using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroAdopcionApp.Entidad
{
    public  class Mascota
    {
        public int IdMascota { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Tipo { get; set; }
        public string Raza { get; set; }
        public string Estado { get; set; }
    }
}
