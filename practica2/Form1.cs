namespace practica2
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double montoInicial, interesCompuesto, resultado;

            montoInicial = Convert.ToDouble(txtMonto.Text);
            interesCompuesto = Convert.ToDouble(txtPorcentaje.Text);
            resultado = montoInicial + (montoInicial * (interesCompuesto / 100));

            lblMensaje.Text = "El interes compuesto es:" + interesCompuesto.ToString();
        }
    }
}