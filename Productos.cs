using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class Productos
    {
        public string Id { get; set; } // Id unica del socio
        public string Descripcion { get; set; } // Id unica del socio
        public string Importe { get; set; } // Id unica del socio

        public Productos(string _id, string _descripcion, string _importe) // Constructor de la clase Socios
        {
            Id = _id; // Asigna el id del socio
            Descripcion = _descripcion; // Asigna el nombre del socio
            Importe = _importe; // Asigna el apellido del socio
        }
    }
}
