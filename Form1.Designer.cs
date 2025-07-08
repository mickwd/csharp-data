namespace app
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_control = new System.Windows.Forms.Button();
            this.input_deuda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.input_categoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.input_fecha = new System.Windows.Forms.DateTimePicker();
            this.input_id = new System.Windows.Forms.TextBox();
            this.input_apellido = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmd_ordenar = new System.Windows.Forms.Button();
            this.cmd_agregar = new System.Windows.Forms.Button();
            this.cmd_modificar = new System.Windows.Forms.Button();
            this.cmd_eliminar = new System.Windows.Forms.Button();
            this.input_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Alumno = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.Alumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_control
            // 
            this.cmd_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_control.Location = new System.Drawing.Point(64, 161);
            this.cmd_control.Name = "cmd_control";
            this.cmd_control.Size = new System.Drawing.Size(261, 35);
            this.cmd_control.TabIndex = 9;
            this.cmd_control.Text = "CORTE DE CONTROL";
            this.cmd_control.UseVisualStyleBackColor = true;
            this.cmd_control.Click += new System.EventHandler(this.cmd_control_Click);
            // 
            // input_deuda
            // 
            this.input_deuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_deuda.Location = new System.Drawing.Point(173, 168);
            this.input_deuda.Margin = new System.Windows.Forms.Padding(2);
            this.input_deuda.Name = "input_deuda";
            this.input_deuda.Size = new System.Drawing.Size(188, 26);
            this.input_deuda.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Deuda";
            // 
            // input_categoria
            // 
            this.input_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_categoria.Location = new System.Drawing.Point(172, 69);
            this.input_categoria.Margin = new System.Windows.Forms.Padding(2);
            this.input_categoria.Name = "input_categoria";
            this.input_categoria.Size = new System.Drawing.Size(188, 26);
            this.input_categoria.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Categoría";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha Nacimiento";
            // 
            // input_fecha
            // 
            this.input_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_fecha.Location = new System.Drawing.Point(172, 201);
            this.input_fecha.Name = "input_fecha";
            this.input_fecha.Size = new System.Drawing.Size(188, 26);
            this.input_fecha.TabIndex = 6;
            this.input_fecha.Value = new System.DateTime(2025, 1, 1, 12, 0, 0, 0);
            // 
            // input_id
            // 
            this.input_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_id.Location = new System.Drawing.Point(173, 36);
            this.input_id.Margin = new System.Windows.Forms.Padding(2);
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(188, 26);
            this.input_id.TabIndex = 1;
            // 
            // input_apellido
            // 
            this.input_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_apellido.Location = new System.Drawing.Point(173, 135);
            this.input_apellido.Margin = new System.Windows.Forms.Padding(2);
            this.input_apellido.Name = "input_apellido";
            this.input_apellido.Size = new System.Drawing.Size(188, 26);
            this.input_apellido.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.cmd_control);
            this.groupBox1.Controls.Add(this.cmd_ordenar);
            this.groupBox1.Controls.Add(this.cmd_agregar);
            this.groupBox1.Controls.Add(this.cmd_modificar);
            this.groupBox1.Controls.Add(this.cmd_eliminar);
            this.groupBox1.Location = new System.Drawing.Point(664, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 214);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // cmd_ordenar
            // 
            this.cmd_ordenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_ordenar.Location = new System.Drawing.Point(64, 126);
            this.cmd_ordenar.Name = "cmd_ordenar";
            this.cmd_ordenar.Size = new System.Drawing.Size(261, 35);
            this.cmd_ordenar.TabIndex = 8;
            this.cmd_ordenar.Text = "ORDENAR";
            this.cmd_ordenar.UseVisualStyleBackColor = true;
            this.cmd_ordenar.Click += new System.EventHandler(this.cmd_ordenar_Click);
            // 
            // cmd_agregar
            // 
            this.cmd_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_agregar.Location = new System.Drawing.Point(64, 21);
            this.cmd_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_agregar.Name = "cmd_agregar";
            this.cmd_agregar.Size = new System.Drawing.Size(261, 35);
            this.cmd_agregar.TabIndex = 6;
            this.cmd_agregar.Text = "AGREGAR";
            this.cmd_agregar.UseVisualStyleBackColor = true;
            this.cmd_agregar.Click += new System.EventHandler(this.cmd_agregar_Click);
            // 
            // cmd_modificar
            // 
            this.cmd_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_modificar.Location = new System.Drawing.Point(64, 91);
            this.cmd_modificar.Name = "cmd_modificar";
            this.cmd_modificar.Size = new System.Drawing.Size(261, 35);
            this.cmd_modificar.TabIndex = 7;
            this.cmd_modificar.Text = "MODIFICAR";
            this.cmd_modificar.UseVisualStyleBackColor = true;
            this.cmd_modificar.Click += new System.EventHandler(this.cmd_modificar_Click);
            // 
            // cmd_eliminar
            // 
            this.cmd_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_eliminar.Location = new System.Drawing.Point(64, 56);
            this.cmd_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_eliminar.Name = "cmd_eliminar";
            this.cmd_eliminar.Size = new System.Drawing.Size(261, 35);
            this.cmd_eliminar.TabIndex = 2;
            this.cmd_eliminar.Text = "ELIMINAR";
            this.cmd_eliminar.UseVisualStyleBackColor = true;
            this.cmd_eliminar.Click += new System.EventHandler(this.cmd_eliminar_Click);
            // 
            // input_nombre
            // 
            this.input_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_nombre.Location = new System.Drawing.Point(173, 102);
            this.input_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.input_nombre.Name = "input_nombre";
            this.input_nombre.Size = new System.Drawing.Size(188, 26);
            this.input_nombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // Alumno
            // 
            this.Alumno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Alumno.Controls.Add(this.input_deuda);
            this.Alumno.Controls.Add(this.label7);
            this.Alumno.Controls.Add(this.input_categoria);
            this.Alumno.Controls.Add(this.label5);
            this.Alumno.Controls.Add(this.label6);
            this.Alumno.Controls.Add(this.input_fecha);
            this.Alumno.Controls.Add(this.input_id);
            this.Alumno.Controls.Add(this.input_apellido);
            this.Alumno.Controls.Add(this.input_nombre);
            this.Alumno.Controls.Add(this.label3);
            this.Alumno.Controls.Add(this.label2);
            this.Alumno.Controls.Add(this.label1);
            this.Alumno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Alumno.Location = new System.Drawing.Point(664, 16);
            this.Alumno.Margin = new System.Windows.Forms.Padding(2);
            this.Alumno.Name = "Alumno";
            this.Alumno.Padding = new System.Windows.Forms.Padding(2);
            this.Alumno.Size = new System.Drawing.Size(384, 265);
            this.Alumno.TabIndex = 11;
            this.Alumno.TabStop = false;
            this.Alumno.Text = "Socios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(637, 501);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Alumno);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.Alumno.ResumeLayout(false);
            this.Alumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmd_control;
        private System.Windows.Forms.TextBox input_deuda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox input_categoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker input_fecha;
        private System.Windows.Forms.TextBox input_id;
        private System.Windows.Forms.TextBox input_apellido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmd_ordenar;
        private System.Windows.Forms.Button cmd_agregar;
        private System.Windows.Forms.Button cmd_modificar;
        private System.Windows.Forms.Button cmd_eliminar;
        private System.Windows.Forms.TextBox input_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Alumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

