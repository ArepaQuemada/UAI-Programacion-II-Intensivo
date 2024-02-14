using System.Runtime.CompilerServices;

namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        List<Button> buttons = new List<Button>();
        bool x_or_o = true;
        public Form1()
        {
            InitializeComponent();
            InicializarBotones();
        }

        void InicializarBotones()
        {
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);

            BloqueoBotones();
            EscucharEventoDeClick();
        }

        void BloqueoBotones()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = false;
            }
        }

        void LimpiarBotones()
        {
            foreach (Button button in buttons)
            {
                button.Text = "-";
            }
        }

        void EscucharEventoDeClick()
        {
            foreach (Button button in buttons)
            {
                button.Click += game_action_boton_click;
            }
        }

        private bool VerificoSiSonXoSonO(Button buttonPressed1, Button buttonPressed2, Button buttonPressed3) 
        {
            return (buttonPressed1.Text == "X" && buttonPressed2.Text == "X" && buttonPressed3.Text == "X") ||
                (buttonPressed1.Text == "O" && buttonPressed2.Text == "O" && buttonPressed3.Text == "O");
        }

        private bool VerificarGanador()
        {
            // compruebo Filas
            for (int i = 0; i < 3; i++)
            {
                Button buttonPressed1 = buttons[i * 3];
                Button buttonPressed2 = buttons[i * 3 + 1];
                Button buttonPressed3 = buttons[i * 3 + 2];

                if (buttonPressed1.Text != "-" && buttonPressed2.Text != "-" && buttonPressed3.Text != "-")
                {
                    return VerificoSiSonXoSonO(buttonPressed1, buttonPressed2, buttonPressed3);
                }
            }

            // Compruebo Columnas
            for (int i = 0; i < 3; i++)
            {
                Button buttonPressed1 = buttons[i];
                Button buttonPressed2 = buttons[i + 3];
                Button buttonPressed3 = buttons[i + 6];

                if (buttonPressed1.Text != "-" && buttonPressed2.Text != "-" && buttonPressed3.Text != "-")
                {
                    return VerificoSiSonXoSonO(buttonPressed1, buttonPressed2, buttonPressed3); ;
                }
            }

            // Compruebi Diagonales
            if (buttons[0].Text != "-" &&
                buttons[4].Text != "-" &&
                buttons[8].Text != "-")
            {
                return VerificoSiSonXoSonO(buttons[0], buttons[4], buttons[8]);
            }

            if (buttons[2].Text != "-" &&
                buttons[4].Text != "-" &&
                buttons[6].Text != "-")
            {
                return VerificoSiSonXoSonO(buttons[2], buttons[4], buttons[6]); ;
            }

            return false;
        }

        void DesbloquearBotones()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LimpiarBotones();
            DesbloquearBotones();
            winnerLabel.Text = "";
        }

        private void game_action_boton_click(object sender, EventArgs e)
        {
            Button botonPresionado = (Button)sender;
            if (x_or_o)
            {
                botonPresionado.Text = "X";
            }
            else
            {
                botonPresionado.Text = "O";
            }
            botonPresionado.Enabled = false;
            x_or_o = !x_or_o;
            if (VerificarGanador())
            {
                BloqueoBotones();
                winnerLabel.Text = "Hubo Ganador";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}