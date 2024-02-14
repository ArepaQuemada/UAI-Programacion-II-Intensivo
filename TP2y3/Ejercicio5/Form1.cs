namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for(int i = int.Parse(textBox1.Text); i <= int.Parse(textBox2.Text); i ++)
            {
                int divisores = 0;
                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        divisores++;
                    }
                }

                if (divisores == 2)
                {
                    listBox1.Items.Add("Numero primo " + i);
                }
            }
        }
    }
}