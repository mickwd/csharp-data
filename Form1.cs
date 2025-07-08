using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Lista lista = new Lista();
        List<Socios> listita = new List<Socios>();

        private void Form1_Load(object sender, EventArgs e)
        {
            listita = lista.Importar(listita);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listita;
        }

        private bool ValidarId()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Id"].Value.ToString() == input_id.Text)
                {
                    MessageBox.Show("El ID ya existe. Por favor, ingrese un ID diferente.");
                    return true;
                }
            }
            return false;
        }

        private bool Validaciones()
        {
            if (String.IsNullOrEmpty(input_id.Text) || String.IsNullOrEmpty(input_nombre.Text) || String.IsNullOrEmpty(input_apellido.Text) || String.IsNullOrEmpty(input_categoria.Text) || String.IsNullOrEmpty(input_deuda.Text) || String.IsNullOrEmpty(input_fecha.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return true;
            }

            if (!char.IsLetter(input_id.Text[0]) || !char.IsLetter(input_id.Text[1]))
            {
                MessageBox.Show("El ID debe ser XX000 (AA111)");
                return true;
            }
            
            if (!char.IsDigit(input_id.Text[2]) || !char.IsDigit(input_id.Text[3]) || !char.IsDigit(input_id.Text[4]))
            {
                MessageBox.Show("El ID debe ser XX000 (AA111)");
                return true;
            }
            
            foreach (char c in input_nombre.Text)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("El nombre solo puede contener letras.");
                    return true;
                }
            }

            foreach (char c in input_apellido.Text)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("El apellido solo puede contener letras.");
                    return true;
                }
            }

            return false;
        }

        private void Cargar(List<Socios> listita)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listita;
            Validaciones();
            lista.Exportar(listita);
        }

        private void cmd_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validaciones()) throw new Exception("Valida las credenciales.");
                if (ValidarId()) throw new Exception("Valida las credenciales.");

                Socios X = new Socios(input_id.Text, input_nombre.Text, input_apellido.Text, input_categoria.Text, input_deuda.Text, input_fecha.Text);
                listita = lista.Agregar(listita, X);
                Cargar(listita);
            }
            catch (Exception ex)
            {
            }
        }

        private void cmd_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Socios X = (Socios)this.dataGridView1.CurrentRow.DataBoundItem;
                listita = lista.Eliminar(listita, X);
                Cargar(listita);
            }
            catch (Exception ex)
            {
            }
        }

        private void cmd_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validaciones()) throw new Exception("Valida las credenciales.");

                Socios X = (Socios)this.dataGridView1.CurrentRow.DataBoundItem;
                Socios Q = new Socios(input_id.Text, input_nombre.Text, input_apellido.Text, input_categoria.Text, input_deuda.Text, input_fecha.Text);

                listita = lista.Modificar(listita, X, Q, this.dataGridView1.CurrentRow.Index);
                Cargar(listita);
            }
            catch (Exception ex)
            {
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Socios X = (Socios)this.dataGridView1.CurrentRow.DataBoundItem;

            input_id.Text = X.Id;
            input_nombre.Text = X.Nombre;
            input_apellido.Text = X.Apellido;
            input_categoria.Text = X.Categoria;
            input_deuda.Text = X.Deuda;
            input_fecha.Text = X.Fecha;
        }

        private void cmd_ordenar_Click(object sender, EventArgs e)
        {
            listita = listita.OrderBy(x => x.Id).ToList();
            Cargar(listita);
        }

        private void cmd_control_Click(object sender, EventArgs e)
        {
            listita = listita.OrderBy(x => x.Categoria).ToList();
            listita = lista.Control(listita);
            Cargar(listita);
        }
    }
}
