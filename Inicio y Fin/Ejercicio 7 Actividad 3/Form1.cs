namespace Ejercicio_7_Actividad_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerarPrimos_Click(object sender, EventArgs e)
        {
            listBoxPrimos.Items.Clear();

            if (int.TryParse(txtInicio.Text, out int inicio) && int.TryParse(txtFin.Text, out int fin))
            {
                if (inicio > fin)
                {
                    MessageBox.Show("El valor de inicio debe ser menor o igual al de fin.", "Error");
                    return;
                }

                for (int i = inicio; i <= fin; i++)
                {
                    if (EsPrimo(i))
                        listBoxPrimos.Items.Add(i);
                }

                if (listBoxPrimos.Items.Count == 0)
                {
                    MessageBox.Show("No se encontraron números primos en ese rango.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa valores numéricos válidos.");
            }
        }

        private bool EsPrimo(int numero)
        {
            if (numero < 2) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
    }
    
}
