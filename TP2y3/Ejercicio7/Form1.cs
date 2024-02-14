namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal resultado = (numericUpDown1.Value * numericUpDown2.Value * numericUpDown3.Value) / 36500;
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = numericUpDown1.Value;
            dataGridView1.Rows[n].Cells[1].Value = numericUpDown2.Value;
            dataGridView1.Rows[n].Cells[2].Value = numericUpDown3.Value;
            dataGridView1.Rows[n].Cells[3].Value = resultado;


        }
    }
}