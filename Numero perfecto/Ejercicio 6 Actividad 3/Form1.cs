namespace Ejercicio_6_Actividad_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            maskedTextBox1.Mask = "000000"; // 
            maskedTextBox1.PromptChar = ' ';
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(maskedTextBox1.Text.Trim(), out int numero))
            {
                if (EsNumeroPerfecto(numero))
                {
                    MessageBox.Show($"{numero} es un número perfecto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{numero} no es un número perfecto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsNumeroPerfecto(int numero)
        {
            if (numero <= 0) return false;

            int suma = 0;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                    suma += i;
            }

            return suma == numero;
        }
    }
}
        
    
