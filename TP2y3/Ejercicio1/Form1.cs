namespace Ejercicio1
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
    }
}