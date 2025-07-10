using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
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

        Data data = new Data(); 
        List<Productos> lista = new List<Productos>();

        private void Actualizar(List<Productos> lista)
        {
            dgv.DataSource = null;
            dgv.DataSource = lista;
        }

        private string ValidarId()
        {
            if (String.IsNullOrEmpty(input_id.Text)) return "El campo de Id no puede estar vacio";
            if (String.IsNullOrEmpty(input_descripcion.Text)) return "El campo de Descripcion no puede estar vacio";
            if (String.IsNullOrEmpty(input_importe.Text)) return "El campo de Importe no puede estar vacio";

            if (input_id.Text.Length != 4) return "El Id debe tener el formato X000 (Ej: A123)";
            if (!char.IsLetter(input_id.Text[0])) return "El Id debe tener el formato X000 (Ej: A123)";
            if (!char.IsDigit(input_id.Text[1]) || !char.IsDigit(input_id.Text[2]) || !char.IsDigit(input_id.Text[3])) return "El Id debe tener el formato X000 (Ej: A123)";

            return "cool";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista = data.Importar(lista);
            Actualizar(lista);
        }

        private void cmd_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarId() != "cool") throw new Exception($"{ValidarId()}");
                Productos X = new Productos(input_id.Text, input_descripcion.Text, input_importe.Text);
                lista = data.Agregar(lista, X);
                Actualizar(lista);
                data.Exportar(lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return;
            }
        }

        private void cmd_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Productos X = (Productos)dgv.CurrentRow.DataBoundItem;
                lista = data.Eliminar(lista, X);
                Actualizar(lista);
                data.Exportar(lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Productos X = (Productos)dgv.CurrentRow.DataBoundItem;
            input_id.Text = X.Id;
            input_descripcion.Text = X.Descripcion;
            input_importe.Text = X.Importe;
        }

        private void cmd_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarId() != "cool") throw new Exception($"{ValidarId()}");
                Productos X = (Productos)dgv.CurrentRow.DataBoundItem;
                Productos Y = new Productos(input_id.Text, input_descripcion.Text, input_importe.Text);
                lista = data.Modificar(lista, X, Y, dgv.CurrentRow.Index);
                Actualizar(lista);
                data.Exportar(lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return;
            }
        }
        
        private void cmd_ordenar_0_Click(object sender, EventArgs e)
        {
            lista = lista.OrderByDescending(x => x.Id).ToList();
            Actualizar(lista);
        }

        private void cmd_ordenar_1_Click(object sender, EventArgs e)
        {
            lista = lista.OrderBy(x => x.Id).ToList();
            Actualizar(lista);
        }

        private void cmd_control_Click(object sender, EventArgs e)
        {
            lista = lista.OrderBy(x => x.Id).ToList();
            lista = data.Corte(lista);
            Actualizar(lista);
        }
    }
}
