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

        Lista lista = new Lista(); // Se llama a la clase 'Lista' para poder utilizar los metodos de tal.
        List<Socios> listita = new List<Socios>(); // Se crea una lista de 'Socios' para poder almacenar los datos de los socios.

        private void Form1_Load(object sender, EventArgs e) // Al cargar el formulario
        {
            listita = lista.Importar(listita); // Se importa la lista de socios desde el archivo 'db.txt'.
            dataGridView1.DataSource = null; // Se limpia el DataGridView para evitar duplicados.
            dataGridView1.DataSource = listita; // Se asigna la lista de socios al DataGridView para mostrar los datos.
        }

        private bool ValidarId() // Verifica si el ID ingresado ya existe en la lista de socios.
        {
            foreach (DataGridViewRow row in dataGridView1.Rows) // Recorre cada fila del DataGridView
            {
                if (row.Cells[0].Value.ToString() == input_id.Text) // Compara el ID ingresado con el ID de cada fila (!) La fila 0 es 'Id'.
                {
                    MessageBox.Show("El ID ya existe. Por favor, ingrese un ID diferente."); // Si el ID ya existe, muestra un mensaje de error.
                    return true; // Retorna true para indicar que hay un error.
                }
            }
            return false; // Retorna false por que no hay ningun error.
        }

        private bool Validaciones() // Verifica si los campos de entrada son válidos y completos.
        {
            if (String.IsNullOrEmpty(input_id.Text) || String.IsNullOrEmpty(input_nombre.Text) || String.IsNullOrEmpty(input_apellido.Text) || String.IsNullOrEmpty(input_categoria.Text) || String.IsNullOrEmpty(input_deuda.Text) || String.IsNullOrEmpty(input_fecha.Text))
            { // Verifica si alguno de los campos de entrada está vacío.
                MessageBox.Show("Debe completar todos los campos"); // Si algún campo está vacío, muestra un mensaje de error.
                return true; // Retorna true para indicar que hay un error.
            }

            if (!char.IsLetter(input_id.Text[0]) || !char.IsLetter(input_id.Text[1])) // Verifica si los dos primeros caracteres del ID son letras.
            {
                MessageBox.Show("El ID debe ser XX000 (AA111)"); // Si no lo son, muestra un mensaje de error.
                return true; // Retorna true para indicar que hay un error.
            }
            
            if (!char.IsDigit(input_id.Text[2]) || !char.IsDigit(input_id.Text[3]) || !char.IsDigit(input_id.Text[4])) // Verifica si los últimos tres caracteres del ID son dígitos.
            {
                MessageBox.Show("El ID debe ser XX000 (AA111)"); // Si no lo son, muestra un mensaje de error.
                return true; // Retorna true para indicar que hay un error.
            }
            
            foreach (char c in input_nombre.Text) // Recorre cada carácter del nombre ingresado
            {
                if (!char.IsLetter(c)) // Verifica si el carácter NO es una letra
                {
                    MessageBox.Show("El nombre solo puede contener letras."); // Si no es una letra, muestra un mensaje de error.
                    return true; // Retorna true para indicar que hay un error.
                }
            }

            foreach (char c in input_apellido.Text) // Recorre cada carácter del apellido ingresado
            {
                if (!char.IsLetter(c)) // Verifica si el carácter NO es una letra
                {
                    MessageBox.Show("El apellido solo puede contener letras."); // Si no es una letra, muestra un mensaje de error.
                    return true; // Retorna true para indicar que hay un error.
                }
            }

            DateTime fecha = DateTime.Parse(input_fecha.Text); // Intenta convertir la fecha ingresada a un objeto DateTime.
            if (fecha > DateTime.Now) // Verifica si la fecha ingresada es mayor a la fecha actual.
            {
                MessageBox.Show("La fecha no puede ser futura."); // Si la fecha es futura, muestra un mensaje de error.
                return true; // Retorna true para indicar que hay un error.
            }

            return false; // Retorna false para indicar que no hay errores.
        }

        private void Cargar(List<Socios> listita) // Carga la lista de socios en el DataGridView y actualiza la vista.
        {
            dataGridView1.DataSource = null; // Limpia el DataGridView para evitar duplicados.
            dataGridView1.DataSource = listita; // Asigna la lista de socios al DataGridView para mostrar los datos.
            Validaciones(); // Llama a la función de validaciones para asegurarse de que los datos sean correctos.
            lista.Exportar(listita); // Exporta la lista de socios al archivo 'db.txt'.
        }

        private void cmd_agregar_Click(object sender, EventArgs e) // Al hacer clic en el botón "Agregar" 
        {
            try
            {
                if (Validaciones()) throw new Exception("Valida las credenciales."); // Llama a la función de validaciones para asegurarse de que los datos sean correctos.
                if (ValidarId()) throw new Exception("Valida las credenciales."); // Verifica si el ID ingresado ya existe en la lista de socios.

                Socios X = new Socios(input_id.Text, input_nombre.Text, input_apellido.Text, input_categoria.Text, input_deuda.Text, input_fecha.Text); // Crea un nuevo objeto Socios con los datos ingresados en los campos de entrada.
                listita = lista.Agregar(listita, X); // Agrega el nuevo objeto Socios a la lista de socios.
                Cargar(listita); // Llama a la función Cargar para actualizar el DataGridView y exportar la lista de socios al archivo 'db.txt'.
            }
            catch (Exception ex)
            { // Esto se queda en blanco por que ya se gestiona el error desde la anterior call.
            }
        }

        private void cmd_eliminar_Click(object sender, EventArgs e) // Al hacer clic en el botón "Eliminar"
        {
            try
            {
                Socios X = (Socios)this.dataGridView1.CurrentRow.DataBoundItem; // Obtiene el objeto Socios seleccionado en la fila actual del DataGridView.
                listita = lista.Eliminar(listita, X); // Elimina el objeto Socios seleccionado de la lista de socios.
                Cargar(listita); // Llama a la función Cargar para actualizar el DataGridView y exportar la lista de socios al archivo 'db.txt'.
            }
            catch (Exception ex)
            { // Esto se queda en blanco por que ya se gestiona el error desde la anterior call.
            }
        }

        private void cmd_modificar_Click(object sender, EventArgs e) // Al hacer clic en el botón "Modificar"
        {
            try // Intenta ejecutar el siguiente bloque de código
            {
                if (Validaciones()) throw new Exception("Valida las credenciales."); // Llama a la función de validaciones para asegurarse de que los datos sean correctos.
                 
                Socios X = (Socios)this.dataGridView1.CurrentRow.DataBoundItem; // Obtiene el objeto Socios seleccionado en la fila actual del DataGridView.
                Socios Q = new Socios(input_id.Text, input_nombre.Text, input_apellido.Text, input_categoria.Text, input_deuda.Text, input_fecha.Text); // Crea un nuevo objeto Socios con los datos ingresados en los campos de entrada.

                listita = lista.Modificar(listita, X, Q, this.dataGridView1.CurrentRow.Index); // Modifica el objeto Socios seleccionado en la lista de socios con los nuevos datos ingresados. 
                Cargar(listita); // Llama a la función Cargar para actualizar el DataGridView y exportar la lista de socios al archivo 'db.txt'.
            }
            catch (Exception ex)
            { // Esto se queda en blanco por que ya se gestiona el error desde la anterior call.
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // Al hacer clic en una celda del DataGridView
        {
            Socios X = (Socios)this.dataGridView1.CurrentRow.DataBoundItem; // Obtiene el objeto Socios seleccionado en la fila actual del DataGridView.

            input_id.Text = X.Id; // Asigna el ID del objeto Socios a la caja de texto de entrada correspondiente.
            input_nombre.Text = X.Nombre; // ....
            input_apellido.Text = X.Apellido;
            input_categoria.Text = X.Categoria;
            input_deuda.Text = X.Deuda;
            input_fecha.Text = X.Fecha;
        }

        private void cmd_ordenar_Click(object sender, EventArgs e) // Al hacer clic en el botón "Ordenar"
        {
            listita = listita.OrderBy(x => x.Id).ToList(); // Ordena la lista de socios por el ID.
            Cargar(listita); // Llama a la función Cargar para actualizar el DataGridView y exportar la lista de socios al archivo 'db.txt'.
        }

        private void cmd_control_Click(object sender, EventArgs e) // Al hacer clic en el botón "Control"
        {
            listita = listita.OrderBy(x => x.Categoria).ToList(); // Ordena la lista de socios por la categoría.
            listita = lista.Control(listita); // Llama a la función Control para calcular los subtotales y totales de las deudas por categoría.
            Cargar(listita); // Llama a la función Cargar para actualizar el DataGridView y exportar la lista de socios al archivo 'db.txt'.
        }
    }
}
