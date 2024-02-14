namespace Ejercicio3
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
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            labelResult = new Label();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(192, 83);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(315, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 65);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese un numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 238);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 3;
            label2.Text = "Numeros Ingresados";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(296, 338);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(86, 15);
            labelResult.TabIndex = 4;
            labelResult.Text = "Suma de todos";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(247, 132);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(187, 27);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Agregar";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAdd);
            Controls.Add(labelResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            DoubleBuffered = true;
            Enabled = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label labelResult;
        private Button buttonAdd;
    }
}