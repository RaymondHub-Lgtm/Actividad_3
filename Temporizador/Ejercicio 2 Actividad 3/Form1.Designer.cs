namespace Ejercicio_2_Actividad_3
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
            components = new System.ComponentModel.Container();
            lblMinutos = new Label();
            nudMinutos = new NumericUpDown();
            lblSegundos = new Label();
            nudSegundos = new NumericUpDown();
            btnIniciar = new Button();
            lblTiempoRestante = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)nudMinutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSegundos).BeginInit();
            SuspendLayout();
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.Location = new Point(25, 66);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(51, 15);
            lblMinutos.TabIndex = 0;
            lblMinutos.Text = "Minutos";
            lblMinutos.Click += lblMinutos_Click;
            // 
            // nudMinutos
            // 
            nudMinutos.BackColor = SystemColors.InactiveCaption;
            nudMinutos.Location = new Point(25, 84);
            nudMinutos.Name = "nudMinutos";
            nudMinutos.Size = new Size(120, 23);
            nudMinutos.TabIndex = 1;
            // 
            // lblSegundos
            // 
            lblSegundos.AutoSize = true;
            lblSegundos.Location = new Point(25, 134);
            lblSegundos.Name = "lblSegundos";
            lblSegundos.Size = new Size(59, 15);
            lblSegundos.TabIndex = 2;
            lblSegundos.Text = "Segundos";
            // 
            // nudSegundos
            // 
            nudSegundos.BackColor = SystemColors.InactiveCaption;
            nudSegundos.Location = new Point(25, 152);
            nudSegundos.Name = "nudSegundos";
            nudSegundos.Size = new Size(120, 23);
            nudSegundos.TabIndex = 3;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = SystemColors.Info;
            btnIniciar.Location = new Point(25, 214);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(137, 23);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar Temporizador";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // lblTiempoRestante
            // 
            lblTiempoRestante.AutoSize = true;
            lblTiempoRestante.Location = new Point(25, 271);
            lblTiempoRestante.Name = "lblTiempoRestante";
            lblTiempoRestante.Size = new Size(0, 15);
            lblTiempoRestante.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 314);
            Controls.Add(lblTiempoRestante);
            Controls.Add(btnIniciar);
            Controls.Add(nudSegundos);
            Controls.Add(lblSegundos);
            Controls.Add(nudMinutos);
            Controls.Add(lblMinutos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudMinutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSegundos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMinutos;
        private NumericUpDown nudMinutos;
        private Label lblSegundos;
        private NumericUpDown nudSegundos;
        private Button btnIniciar;
        private Label lblTiempoRestante;
        private System.Windows.Forms.Timer timer1;
    }
}
