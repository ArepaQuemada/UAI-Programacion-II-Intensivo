namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        private const int NumDado = 6;
        private int totalTiradas = 0;
        private Dictionary<int, int> resultados = new Dictionary<int, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void TirarDados()
        {
            Random rnd = new Random();
            int dado1 = rnd.Next(1, NumDado + 1);
            int dado2 = rnd.Next(1, NumDado + 1);
            int suma = dado1 + dado2;

            totalTiradas++;
            if (resultados.ContainsKey(suma))
                resultados[suma]++;
            else
                resultados.Add(suma, 1);

            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dataGridView1.Rows.Clear();

            foreach (var par in resultados)
            {
                int numero = par.Key;
                int cantidad = par.Value;
                double porcentaje = (double)cantidad / totalTiradas * 100;

                dataGridView1.Rows.Add(numero, cantidad, porcentaje.ToString("0.00") + "%");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TirarDados();

        }
    }
}