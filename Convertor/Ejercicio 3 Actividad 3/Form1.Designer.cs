namespace Ejercicio_3_Actividad_3
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
            lblValor = new Label();
            txtValor = new TextBox();
            lblDe = new Label();
            combDe = new ComboBox();
            lblA = new Label();
            combA = new ComboBox();
            btnConvertir = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(16, 33);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 0;
            lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(16, 64);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 1;
            // 
            // lblDe
            // 
            lblDe.AutoSize = true;
            lblDe.Location = new Point(21, 113);
            lblDe.Name = "lblDe";
            lblDe.Size = new Size(21, 15);
            lblDe.TabIndex = 2;
            lblDe.Text = "De";
            // 
            // combDe
            // 
            combDe.FormattingEnabled = true;
            combDe.Location = new Point(16, 157);
            combDe.Name = "combDe";
            combDe.Size = new Size(161, 23);
            combDe.TabIndex = 3;
            combDe.Text = "Lista de unidades destino";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(21, 212);
            lblA.Name = "lblA";
            lblA.Size = new Size(15, 15);
            lblA.TabIndex = 4;
            lblA.Text = "A";
            // 
            // combA
            // 
            combA.FormattingEnabled = true;
            combA.Location = new Point(16, 240);
            combA.Name = "combA";
            combA.Size = new Size(121, 23);
            combA.TabIndex = 5;
            combA.Text = "Lista de unidades destino";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(174, 63);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(75, 23);
            btnConvertir.TabIndex = 6;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(24, 311);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 394);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
            Controls.Add(combA);
            Controls.Add(lblA);
            Controls.Add(combDe);
            Controls.Add(lblDe);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValor;
        private TextBox txtValor;
        private Label lblDe;
        private ComboBox combDe;
        private Label lblA;
        private ComboBox combA;
        private Button btnConvertir;
        private Label lblResultado;
    }
}
