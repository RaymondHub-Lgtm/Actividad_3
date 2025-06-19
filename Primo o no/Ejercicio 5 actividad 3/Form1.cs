namespace Ejercicio_5_actividad_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(maskedTextNumero.Text.Trim(), out int numero))
            {
                if (numero < 2)
                {
                    MessageBox.Show("El número NO es primo.", "Resultado");
                    return;
                }

                bool esPrimo = true;

                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                    MessageBox.Show("El número es primo.", "Resultado");
                else
                    MessageBox.Show("El número no es primo.", "Resultado");
            }
            else
            {
                MessageBox.Show("Por favor ingresa un número válido.", "Error");
            }
        }
    }
    
}
