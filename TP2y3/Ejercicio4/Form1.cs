namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelResult.Text = (numericUpDown1.Value + numericUpDown2.Value).ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            labelResult.Text = (numericUpDown1.Value - numericUpDown2.Value).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelResult.Text = (numericUpDown1.Value * numericUpDown2.Value).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double rootSquare1 = Math.Sqrt((double)(numericUpDown1.Value));
            double rootSquare2 = Math.Sqrt((double)(numericUpDown2.Value));

            labelResult.Text = "Raiz cuadrada numero 1 es " + rootSquare1 + ". Raiz cuadrada numero 2 es" + rootSquare2;
        }
    }
}