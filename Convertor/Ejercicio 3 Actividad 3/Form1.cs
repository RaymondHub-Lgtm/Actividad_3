namespace Ejercicio_3_Actividad_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] unidades = { "Metros", "Centímetros", "Pulgadas" };
            combDe.Items.AddRange(unidades);
            combA.Items.AddRange(unidades);

            combDe.SelectedIndex = 0;
            combA.SelectedIndex = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtValor.Text, out double valor))
            {
                MessageBox.Show("Introduce un valor numérico válido.");
                return;
            }

            string unidadOrigen = combDe.SelectedItem.ToString();
            string unidadDestino = combA.SelectedItem.ToString();

            // Convertir primero a metros como unidad base
            double valorEnMetros = valor;

            switch (unidadOrigen)
            {
                case "Metros":
                    valorEnMetros = valor;
                    break;
                case "Centímetros":
                    valorEnMetros = valor / 100;
                    break;
                case "Pulgadas":
                    valorEnMetros = valor * 0.0254;
                    break;
            }

            // Convertir de metros a la unidad destino
            double resultado = valorEnMetros;

            switch (unidadDestino)
            {
                case "Metros":
                    resultado = valorEnMetros;
                    break;
                case "Centímetros":
                    resultado = valorEnMetros * 100;
                    break;
                case "Pulgadas":
                    resultado = valorEnMetros / 0.0254;
                    break;
            }

            lblResultado.Text = $"Resultado: {resultado:F2} {unidadDestino}";
        }
    }
}
    

