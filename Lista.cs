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

        public List<Socios> Agregar(List<Socios> listita, Socios X)
        {
            listita.Add(X);
            return listita;
        }

        public List<Socios> Eliminar(List<Socios> listita, Socios X)
        {
            listita.Remove(X);
            return listita;
        }

        public List<Socios> Modificar(List<Socios> listita, Socios X, Socios Q, int index)
        {
            listita.Remove(X);
            listita.Insert(index, Q);
            return listita;
        }

        public List<Socios> Control(List<Socios> listita)
        {
            int deuda_total = 0;
            int deuda_parcial = 0;
            string categoria = listita[0].Categoria;
            List<Socios> Subtotales = new List<Socios>();

            for (int i = 0; i < listita.Count; i++)
            {
                Socios X = listita[i];
                
                if (X.Categoria == categoria)
                {
                    deuda_parcial += int.Parse(X.Deuda);
                    Subtotales.Add(X);
                }
                else
                {
                    Socios Q = new Socios("", "Subtotal", $"{categoria}", "", $"{deuda_parcial}", "");
                    deuda_total += deuda_parcial;
                    Subtotales.Add(Q);
                    
                    deuda_parcial = int.Parse(X.Deuda);

                    categoria = X.Categoria;
                    Subtotales.Add(X);
                }
            }

            Socios Xq = new Socios("", "Subtotal", $"{categoria}", "", $"{deuda_parcial}", "");
            Subtotales.Add(Xq);

            deuda_total += deuda_parcial;
            Socios Y = new Socios("", "Total", $"", "", $"{deuda_total}", "");
            Subtotales.Add(Y);

            return Subtotales;
        }

        private string file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db.txt");
        //private string file = @"C:\Users\admin\Desktop\app\bin\Debug\db.txt"; // Forma mas facil si es local.

        public void Exportar(List<Socios> listita)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Socios socio in listita)
                {
                    writer.WriteLine($"{socio.Id};{socio.Nombre};{socio.Apellido};{socio.Categoria};{socio.Deuda};{socio.Fecha}");
                }
            }
        }

        public List<Socios> Importar(List<Socios> listita)
        {
            listita.Clear();

            using (StreamReader reader = new StreamReader(file))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] data = linea.Split(';');

                    if (data.Length == 6)
                    {
                        Socios X = new Socios(data[0], data[1], data[2], data[3], data[4], data[5]);
                        listita.Add(X);
                    }
                }
            }
            return listita;
        }
    }
}
