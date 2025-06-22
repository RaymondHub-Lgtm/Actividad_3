
namespace Ejercicio_Actividad_3_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbCodigo = new TextBox();
            tbNombre = new TextBox();
            tbPromedio = new TextBox();
            btnRegistrar = new Button();
            btnOrdenar = new Button();
            btnBuscar = new Button();
            label4 = new Label();
            tbBuscar = new TextBox();
            dgAlumnos = new DataGridView();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 38);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 77);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 112);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "promedio:";
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(93, 38);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(123, 23);
            tbCodigo.TabIndex = 3;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(93, 74);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(231, 23);
            tbNombre.TabIndex = 4;
            // 
            // tbPromedio
            // 
            tbPromedio.Location = new Point(93, 112);
            tbPromedio.Name = "tbPromedio";
            tbPromedio.Size = new Size(92, 23);
            tbPromedio.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(26, 184);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(134, 32);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(314, 184);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(126, 32);
            btnOrdenar.TabIndex = 8;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(314, 234);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(126, 32);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 248);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 10;
            label4.Text = "Buscar Por Codigo:";
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(140, 240);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(148, 23);
            tbBuscar.TabIndex = 11;
            // 
            // dgAlumnos
            // 
            dgAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAlumnos.Location = new Point(26, 288);
            dgAlumnos.Name = "dgAlumnos";
            dgAlumnos.Size = new Size(396, 150);
            dgAlumnos.TabIndex = 12;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(176, 184);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(122, 32);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(478, 450);
            Controls.Add(btnEliminar);
            Controls.Add(dgAlumnos);
            Controls.Add(tbBuscar);
            Controls.Add(label4);
            Controls.Add(btnBuscar);
            Controls.Add(btnOrdenar);
            Controls.Add(btnRegistrar);
            Controls.Add(tbPromedio);
            Controls.Add(tbNombre);
            Controls.Add(tbCodigo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Registro de alumnos";
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbCodigo;
        private TextBox tbNombre;
        private TextBox tbPromedio;
        private Button btnRegistrar;
        private Button btnOrdenar;
        private Button btnBuscar;
        private Label label4;
        private TextBox tbBuscar;
        private DataGridView dgAlumnos;
        private Button btnEliminar;
    }
}
