namespace Ejercicio_4_actividad_4
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
            texBoxPalabra = new TextBox();
            botonVerificar = new Button();
            lblPalabra = new Label();
            SuspendLayout();
            // 
            // texBoxPalabra
            // 
            texBoxPalabra.Location = new Point(12, 84);
            texBoxPalabra.Name = "texBoxPalabra";
            texBoxPalabra.Size = new Size(100, 23);
            texBoxPalabra.TabIndex = 0;
            // 
            // botonVerificar
            // 
            botonVerificar.Location = new Point(12, 123);
            botonVerificar.Name = "botonVerificar";
            botonVerificar.Size = new Size(75, 23);
            botonVerificar.TabIndex = 1;
            botonVerificar.Text = "Verificar";
            botonVerificar.UseVisualStyleBackColor = true;
            botonVerificar.Click += botonVerificar_Click;
            // 
            // lblPalabra
            // 
            lblPalabra.AutoSize = true;
            lblPalabra.Location = new Point(14, 56);
            lblPalabra.Name = "lblPalabra";
            lblPalabra.Size = new Size(109, 15);
            lblPalabra.TabIndex = 2;
            lblPalabra.Text = "Escribe una palabra";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(200, 221);
            Controls.Add(lblPalabra);
            Controls.Add(botonVerificar);
            Controls.Add(texBoxPalabra);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox texBoxPalabra;
        private Button botonVerificar;
        private Label lblPalabra;
    }
}
