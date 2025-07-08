using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class Socios
    {
        public string Id { get; set; } // Id unica del socio
        public string Nombre { get; set; } // Nombre del socio
        public string Apellido { get; set; } // Apellido del socio
        public string Categoria { get; set; } // Categoria del socio (1-2-3-...)
        public string Deuda { get; set; } // Deuda del socio 
        public string Fecha { get; set; } // Fecha en string del socio (dd/mm/yyyy)

        public Socios(string _id, string _nombre, string _apellido, string _categoria, string _deuda, string _fecha) // Constructor de la clase Socios
        {
            Id = _id; // Inicializa el Id del socio
            Nombre = _nombre; // ....
            Apellido = _apellido;
            Categoria = _categoria;
            Deuda = _deuda;
            Fecha = _fecha;
        }
    }
}
