using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    internal class Lista
    {
        public Socios X;
        
        public Lista()
        {
            X = null;
        }

        public List<Socios> Agregar(List<Socios> listita, Socios X) // Agrega un socio a la lista
        {
            listita.Add(X); // Agrega el socio a la lista de socios
            return listita; // Devuelve la lista actualizada
        }

        public List<Socios> Eliminar(List<Socios> listita, Socios X) // Elimina un socio de la lista
        {
            listita.Remove(X); // Elimina el socio de la lista de socios
            return listita; // Devuelve la lista actualizada
        }

        public List<Socios> Modificar(List<Socios> listita, Socios X, Socios Q, int index) // Modifica un socio en la lista
        {
            listita.Remove(X); // Elimina el socio original de la lista
            listita.Insert(index, Q); // Inserta el socio modificado en la posición original
            return listita; // Devuelve la lista actualizada
        }

        public List<Socios> Control(List<Socios> listita) // Controla la lista de socios y calcula subtotales y totales por categoría
        {
            int deuda_total = 0; // Variable para almacenar la deuda total
            int deuda_parcial = 0; // Variable para almacenar la deuda parcial por categoría
            string categoria = listita[0].Categoria; // Inicializa la categoría con la del primer socio
            List<Socios> Subtotales = new List<Socios>(); // Lista para almacenar los subtotales y totales
                                                          // Esta lista se usa para reemplazar la lista original de socios + Agregarle los detalles.
            for (int i = 0; i < listita.Count; i++)
            {
                Socios X = listita[i]; // Obtiene el socio actual de la lista

                if (X.Categoria == categoria) // Si la categoría del socio actual es la misma que la anterior
                {
                    deuda_parcial += int.Parse(X.Deuda); // Suma la deuda del socio actual a la deuda parcial
                    Subtotales.Add(X); // Agrega el socio actual a la lista de subtotales
                }
                else
                {
                    Socios Q = new Socios("", "Subtotal", $"{categoria}", "", $"{deuda_parcial}", ""); // Crea un nuevo socio para el subtotal de la categoría anterior
                    deuda_total += deuda_parcial; // Suma la deuda parcial al total
                    Subtotales.Add(Q); // Agrega el subtotal a la lista de subtotales

                    deuda_parcial = int.Parse(X.Deuda); // Reinicia la deuda parcial con la deuda del nuevo socio

                    categoria = X.Categoria; // Actualiza la categoría con la del nuevo socio
                    Subtotales.Add(X); // Agrega el nuevo socio a la lista de subtotales
                }
            }

            Socios Xq = new Socios("", "Subtotal", $"{categoria}", "", $"{deuda_parcial}", ""); // Crea un nuevo socio para el subtotal de la última categoría
            Subtotales.Add(Xq); // Agrega el subtotal de la última categoría a la lista de subtotales

            deuda_total += deuda_parcial; // Suma la deuda parcial de la última categoría al total
            Socios Y = new Socios("", "Total", $"", "", $"{deuda_total}", ""); // Crea un nuevo socio para el total de todas las categorías
            Subtotales.Add(Y); // Agrega el total a la lista de subtotales

            return Subtotales; // Devuelve la lista de subtotales y totales
        }

        private string file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db.txt"); // Ruta del archivo de texto donde se guardarán los datos. Se usa AppDomain para obtener la ruta del directorio actual de la aplicación.
        //private string file = @"C:\Users\admin\Desktop\app\bin\Debug\db.txt"; // Forma mas facil si es local.

        public void Exportar(List<Socios> listita) // Exporta la lista de socios a un archivo de texto
        {
            using (StreamWriter writer = new StreamWriter(file)) // Crea un StreamWriter para escribir en el archivo
            {
                foreach (Socios socio in listita) // Recorre cada socio en la lista
                {
                    writer.WriteLine($"{socio.Id};{socio.Nombre};{socio.Apellido};{socio.Categoria};{socio.Deuda};{socio.Fecha}"); // Escribe los datos del socio en el archivo, separándolos por punto y coma
                }
            }
        }

        public List<Socios> Importar(List<Socios> listita) // Importa la lista de socios desde un archivo de texto
        {
            listita.Clear(); // Limpia la lista de socios antes de importar nuevos datos

            using (StreamReader reader = new StreamReader(file)) // Crea un StreamReader para leer desde el archivo
            {
                string linea; // Variable para almacenar cada línea leída del archivo
                while ((linea = reader.ReadLine()) != null) // Lee cada línea del archivo hasta que no haya más líneas
                {
                    string[] data = linea.Split(';'); // Separa la línea en partes usando el punto y coma como delimitador

                    if (data.Length == 6) // Verifica que la línea tenga exactamente 6 partes
                    {
                        Socios X = new Socios(data[0], data[1], data[2], data[3], data[4], data[5]); // Crea un nuevo objeto Socios con los datos leídos
                        listita.Add(X); // Agrega el nuevo socio a la lista de socios
                    }
                }
            }
            return listita; // Devuelve la lista de socios actualizada
        }
    }
}
