using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    internal class Data
    {
        public Productos X;
        
        public Data()
        {
            X = null;
        }

        public List<Productos> Agregar(List<Productos> lista, Productos X)
        {
            lista.Add(X);
            return lista;
        }

        public List<Productos> Eliminar(List<Productos> lista, Productos X)
        {
            lista.Remove(X);
            return lista;
        }

        public List<Productos> Modificar(List<Productos> lista, Productos X, Productos Y, int index)
        {
            lista.Remove(X);
            lista.Insert(index, Y);
            return lista;
        }

        public List<Productos> Corte(List<Productos> lista)
        {
            List<Productos> lista_prod = new List<Productos>();
            int deuda_parcial = 0;
            int deuda_total = 0;
            string categoria = lista[0].Id;

            foreach (Productos X in lista)
            {
                if (X.Id == categoria)
                {
                    deuda_parcial += Convert.ToInt32(X.Importe);
                    lista_prod.Add(X);
                }
                else
                {
                    lista_prod.Add(new Productos("", "Subtotal", $"{deuda_parcial}"));
                    deuda_total += deuda_parcial;

                    categoria = X.Id;
                    lista_prod.Add(X);
                    deuda_parcial = Convert.ToInt32(X.Importe);
                }
            }

            lista_prod.Add(new Productos("", "Subtotal", $"{deuda_parcial}"));
            deuda_total += deuda_parcial;
            lista_prod.Add(new Productos("", "Total", $"{deuda_total}"));

            return lista_prod;
        }


        private string file = AppDomain.CurrentDomain.BaseDirectory + "db.txt";
        public List<Productos> Importar(List<Productos> lista)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(';');
                    
                    if (data.Length == 3)
                    {
                        Productos X = new Productos(data[0], data[1], data[2]);
                        lista.Add(X);
                    }
                }
            }
            return lista;
        }

        public void Exportar(List<Productos> lista)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Productos X in lista)
                {
                    writer.WriteLine($"{X.Id};{X.Descripcion};{X.Importe}");
                }
            }
        }
    }
}
