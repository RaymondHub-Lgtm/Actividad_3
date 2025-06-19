namespace Ejercicio_5_actividad_3
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
            maskedTextNumero = new MaskedTextBox();
            btnVerificar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // maskedTextNumero
            // 
            maskedTextNumero.Location = new Point(12, 61);
            maskedTextNumero.Mask = "00000";
            maskedTextNumero.Name = "maskedTextNumero";
            maskedTextNumero.PromptChar = ' ';
            maskedTextNumero.Size = new Size(100, 23);
            maskedTextNumero.TabIndex = 0;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(12, 105);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 1;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese El Numero:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(223, 214);
            Controls.Add(label1);
            Controls.Add(btnVerificar);
            Controls.Add(maskedTextNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextNumero;
        private Button btnVerificar;
        private Label label1;
    }
}
