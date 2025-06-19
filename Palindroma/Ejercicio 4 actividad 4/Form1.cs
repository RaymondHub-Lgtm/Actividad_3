namespace Ejercicio_4_actividad_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonVerificar_Click(object sender, EventArgs e)
        {
            string palabra = texBoxPalabra.Text.Trim().ToLower();
            string invertida = new string(palabra.Reverse().ToArray());

            if (palabra == invertida)
            {
                MessageBox.Show("La palabra es un palíndromo.", "Resultado");
            }
            else
            {
                MessageBox.Show("La palabra no es un palíndromo.", "Resultado");
            }
        }
    }
    
}
