namespace Ejercicio_8_Actividad_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            string oracion = txtOracion.Text.Trim();

            if (string.IsNullOrWhiteSpace(oracion))
            {
                lblResultado.Text = "La oración está vacía.";
                return;
            }

            // Separar por espacios y quitar espacios vacíos
            string[] palabras = oracion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            lblResultado.Text = $"Número de palabras: {palabras.Length}";
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
        
    

