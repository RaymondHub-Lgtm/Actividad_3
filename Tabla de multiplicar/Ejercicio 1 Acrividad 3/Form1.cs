namespace Ejercicio_1_Acrividad_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            lstTabla.Items.Clear(); // Limpia la lista antes de mostrar una nueva tabla

            if (int.TryParse(txtNumero.Text, out int numero))
            {
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    lstTabla.Items.Add($"{numero} x {i} = {resultado}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
