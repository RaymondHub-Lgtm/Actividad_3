namespace Ejercicio_1_Acrividad_3
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            btnMostrar = new Button();
            lstTabla = new ListBox();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = SystemColors.AppWorkspace;
            lblNumero.Location = new Point(12, 44);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(110, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Ingrese Un Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 71);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.Red;
            btnMostrar.Location = new Point(153, 75);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(122, 23);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar Tabla";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lstTabla
            // 
            lstTabla.BackColor = SystemColors.InactiveCaption;
            lstTabla.FormattingEnabled = true;
            lstTabla.ItemHeight = 15;
            lstTabla.Location = new Point(155, 137);
            lstTabla.Name = "lstTabla";
            lstTabla.Size = new Size(120, 169);
            lstTabla.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 405);
            Controls.Add(lstTabla);
            Controls.Add(btnMostrar);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private Button btnMostrar;
        private ListBox lstTabla;
    }
}
