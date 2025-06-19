namespace Ejercicio_7_Actividad_3
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
            txtInicio = new TextBox();
            txtFin = new TextBox();
            btnGenerarPrimos = new Button();
            listBoxPrimos = new ListBox();
            SuspendLayout();
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(12, 26);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(100, 23);
            txtInicio.TabIndex = 0;
            // 
            // txtFin
            // 
            txtFin.Location = new Point(12, 67);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(100, 23);
            txtFin.TabIndex = 1;
            // 
            // btnGenerarPrimos
            // 
            btnGenerarPrimos.Location = new Point(12, 119);
            btnGenerarPrimos.Name = "btnGenerarPrimos";
            btnGenerarPrimos.Size = new Size(114, 23);
            btnGenerarPrimos.TabIndex = 2;
            btnGenerarPrimos.Text = "Generar Primos";
            btnGenerarPrimos.UseVisualStyleBackColor = true;
            btnGenerarPrimos.Click += btnGenerarPrimos_Click;
            // 
            // listBoxPrimos
            // 
            listBoxPrimos.FormattingEnabled = true;
            listBoxPrimos.ItemHeight = 15;
            listBoxPrimos.Location = new Point(16, 163);
            listBoxPrimos.Name = "listBoxPrimos";
            listBoxPrimos.Size = new Size(120, 124);
            listBoxPrimos.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 306);
            Controls.Add(listBoxPrimos);
            Controls.Add(btnGenerarPrimos);
            Controls.Add(txtFin);
            Controls.Add(txtInicio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInicio;
        private TextBox txtFin;
        private Button btnGenerarPrimos;
        private ListBox listBoxPrimos;
    }
}
