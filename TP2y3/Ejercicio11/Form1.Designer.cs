namespace Ejercicio11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonStartGame = new Button();
            winnerLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(104, 57);
            button1.Name = "button1";
            button1.Size = new Size(92, 83);
            button1.TabIndex = 0;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(216, 57);
            button2.Name = "button2";
            button2.Size = new Size(92, 83);
            button2.TabIndex = 1;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(331, 57);
            button3.Name = "button3";
            button3.Size = new Size(92, 83);
            button3.TabIndex = 2;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(104, 169);
            button4.Name = "button4";
            button4.Size = new Size(92, 83);
            button4.TabIndex = 3;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(216, 169);
            button5.Name = "button5";
            button5.Size = new Size(92, 83);
            button5.TabIndex = 4;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(331, 169);
            button6.Name = "button6";
            button6.Size = new Size(92, 83);
            button6.TabIndex = 5;
            button6.Text = "-";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(104, 278);
            button7.Name = "button7";
            button7.Size = new Size(92, 83);
            button7.TabIndex = 6;
            button7.Text = "-";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(216, 278);
            button8.Name = "button8";
            button8.Size = new Size(92, 83);
            button8.TabIndex = 7;
            button8.Text = "-";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(331, 278);
            button9.Name = "button9";
            button9.Size = new Size(92, 83);
            button9.TabIndex = 8;
            button9.Text = "-";
            button9.UseVisualStyleBackColor = true;
            // 
            // buttonStartGame
            // 
            buttonStartGame.Location = new Point(494, 57);
            buttonStartGame.Name = "buttonStartGame";
            buttonStartGame.Size = new Size(210, 83);
            buttonStartGame.TabIndex = 9;
            buttonStartGame.Text = "Iniciar Juego";
            buttonStartGame.UseVisualStyleBackColor = true;
            buttonStartGame.Click += button10_Click;
            // 
            // winnerLabel
            // 
            winnerLabel.AutoSize = true;
            winnerLabel.Location = new Point(494, 182);
            winnerLabel.Name = "winnerLabel";
            winnerLabel.Size = new Size(0, 15);
            winnerLabel.TabIndex = 10;
            winnerLabel.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(winnerLabel);
            Controls.Add(buttonStartGame);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonStartGame;
        private Label winnerLabel;
    }
}