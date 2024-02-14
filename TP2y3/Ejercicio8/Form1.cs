namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int TirarDado()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelResultado.Text = TirarDado().ToString();
        }
    }
}