namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        private List<int> secuence = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            secuence.Add(0);
            int number = int.Parse(textBox1.Text);
            CalculateFibonacci(0, 1, number);
            foreach (int i in secuence)
            {
                listBox1.Items.Add("Numero secuenca Fibonacci: " + i);
            }
        }

        private int CalculateFibonacci(int num1, int num2, int end)
        {
            secuence.Add(num2);
            if ((num1 + num2) > end)
            {
                return 0;
            }
            return CalculateFibonacci(num2, num1 + num2, end);
        }
    }
}