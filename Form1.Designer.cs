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
            this.input_descripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.input_id = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmd_ordenar_1 = new System.Windows.Forms.Button();
            this.cmd_ordenar_0 = new System.Windows.Forms.Button();
            this.cmd_agregar = new System.Windows.Forms.Button();
            this.cmd_modificar = new System.Windows.Forms.Button();
            this.cmd_eliminar = new System.Windows.Forms.Button();
            this.input_importe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Alumno = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.Alumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_control
            // 
            this.cmd_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_control.Location = new System.Drawing.Point(64, 198);
            this.cmd_control.Name = "cmd_control";
            this.cmd_control.Size = new System.Drawing.Size(261, 35);
            this.cmd_control.TabIndex = 9;
            this.cmd_control.Text = "CORTE DE CONTROL";
            this.cmd_control.UseVisualStyleBackColor = true;
            this.cmd_control.Click += new System.EventHandler(this.cmd_control_Click);
            // 
            // input_descripcion
            // 
            this.input_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_descripcion.Location = new System.Drawing.Point(172, 69);
            this.input_descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.input_descripcion.Name = "input_descripcion";
            this.input_descripcion.Size = new System.Drawing.Size(188, 26);
            this.input_descripcion.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descripcion";
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.cmd_ordenar_1);
            this.groupBox1.Controls.Add(this.cmd_control);
            this.groupBox1.Controls.Add(this.cmd_ordenar_0);
            this.groupBox1.Controls.Add(this.cmd_agregar);
            this.groupBox1.Controls.Add(this.cmd_modificar);
            this.groupBox1.Controls.Add(this.cmd_eliminar);
            this.groupBox1.Location = new System.Drawing.Point(378, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 252);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // cmd_ordenar_1
            // 
            this.cmd_ordenar_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_ordenar_1.Location = new System.Drawing.Point(64, 162);
            this.cmd_ordenar_1.Name = "cmd_ordenar_1";
            this.cmd_ordenar_1.Size = new System.Drawing.Size(261, 35);
            this.cmd_ordenar_1.TabIndex = 10;
            this.cmd_ordenar_1.Text = "ORDENAR - > +";
            this.cmd_ordenar_1.UseVisualStyleBackColor = true;
            this.cmd_ordenar_1.Click += new System.EventHandler(this.cmd_ordenar_1_Click);
            // 
            // cmd_ordenar_0
            // 
            this.cmd_ordenar_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_ordenar_0.Location = new System.Drawing.Point(64, 126);
            this.cmd_ordenar_0.Name = "cmd_ordenar_0";
            this.cmd_ordenar_0.Size = new System.Drawing.Size(261, 35);
            this.cmd_ordenar_0.TabIndex = 8;
            this.cmd_ordenar_0.Text = "ORDENAR + > -";
            this.cmd_ordenar_0.UseVisualStyleBackColor = true;
            this.cmd_ordenar_0.Click += new System.EventHandler(this.cmd_ordenar_0_Click);
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
            // input_importe
            // 
            this.input_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_importe.Location = new System.Drawing.Point(173, 102);
            this.input_importe.Margin = new System.Windows.Forms.Padding(2);
            this.input_importe.Name = "input_importe";
            this.input_importe.Size = new System.Drawing.Size(188, 26);
            this.input_importe.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id";
            // 
            // Alumno
            // 
            this.Alumno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Alumno.Controls.Add(this.input_descripcion);
            this.Alumno.Controls.Add(this.label5);
            this.Alumno.Controls.Add(this.input_id);
            this.Alumno.Controls.Add(this.input_importe);
            this.Alumno.Controls.Add(this.label3);
            this.Alumno.Controls.Add(this.label1);
            this.Alumno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Alumno.Location = new System.Drawing.Point(378, 15);
            this.Alumno.Margin = new System.Windows.Forms.Padding(2);
            this.Alumno.Name = "Alumno";
            this.Alumno.Padding = new System.Windows.Forms.Padding(2);
            this.Alumno.Size = new System.Drawing.Size(384, 143);
            this.Alumno.TabIndex = 11;
            this.Alumno.TabStop = false;
            this.Alumno.Text = "Socios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importe";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(11, 11);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(353, 417);
            this.dgv.TabIndex = 10;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 444);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Alumno);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.Alumno.ResumeLayout(false);
            this.Alumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmd_control;
        private System.Windows.Forms.TextBox input_descripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmd_ordenar_0;
        private System.Windows.Forms.Button cmd_agregar;
        private System.Windows.Forms.Button cmd_modificar;
        private System.Windows.Forms.Button cmd_eliminar;
        private System.Windows.Forms.TextBox input_importe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Alumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button cmd_ordenar_1;
    }
}

