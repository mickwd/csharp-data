using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class Socios
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Categoria { get; set; }
        public string Deuda { get; set; }
        public string Fecha { get; set; }

        public Socios(string _id, string _nombre, string _apellido, string _categoria, string _deuda, string _fecha)
        {
            Id = _id;
            Nombre = _nombre;
            Apellido = _apellido;
            Categoria = _categoria;
            Deuda = _deuda;
            Fecha = _fecha;
        }
    }
}
