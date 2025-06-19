namespace Ejercicio_8_Actividad_3
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
            txtOracion = new TextBox();
            btnContar = new Button();
            lblResultado = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtOracion
            // 
            txtOracion.Location = new Point(12, 102);
            txtOracion.Name = "txtOracion";
            txtOracion.Size = new Size(233, 23);
            txtOracion.TabIndex = 0;
            // 
            // btnContar
            // 
            btnContar.Location = new Point(12, 132);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(134, 23);
            btnContar.TabIndex = 1;
            btnContar.Text = "Contar Palabras";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(152, 136);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado";
            lblResultado.Click += lblResultado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(241, 23);
            label1.TabIndex = 3;
            label1.Text = "Contador de palabras";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 214);
            Controls.Add(label1);
            Controls.Add(lblResultado);
            Controls.Add(btnContar);
            Controls.Add(txtOracion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOracion;
        private Button btnContar;
        private Label lblResultado;
        private Label label1;
    }
}
