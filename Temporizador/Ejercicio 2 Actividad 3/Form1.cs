namespace Ejercicio_2_Actividad_3
{
    public partial class Form1 : Form
    {
        private int tiempoTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblMinutos_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int minutos = (int)nudMinutos.Value;
            int segundos = (int)nudSegundos.Value;

            tiempoTotal = minutos * 60 + segundos;

            if (tiempoTotal <= 0)
            {
                MessageBox.Show("Por favor, ingresa un tiempo mayor a cero.");
                return;
            }

            lblTiempoRestante.Text = $"{minutos:D2}:{segundos:D2}";
            timer1.Start();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempoTotal > 0)
            {
                tiempoTotal--;
                int minutos = tiempoTotal / 60;
                int segundos = tiempoTotal % 60;
                lblTiempoRestante.Text = $"{minutos:D2}:{segundos:D2}";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("¡El tiempo ha terminado!", "Temporizador");
            }
        }

        private void lblTiempoRestante_Click(object sender, EventArgs e)
        {

        }
    }

}
