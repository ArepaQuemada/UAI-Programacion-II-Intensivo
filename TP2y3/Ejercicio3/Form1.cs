namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        private int[] numbers;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            numbers.Append((int)numericUpDown1.Value);
            textBox1.Text.Concat(numericUpDown1.Value.ToString());
            foreach (var item in numbers)
            {
                labelResult.Text.Concat(item.ToString());
            }
        }
    }
}