namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = openFileDialog.FileName;
                try
                {
                    Image imagenSeleccionada = Image.FromFile(rutaImagen);

                    pictureBox1.Image = imagenSeleccionada;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar");
                }
            }
        }
    }
}