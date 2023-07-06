namespace Calculadora
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
            soma = new Button();
            primeiro_numero = new Label();
            segundo_numero = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            resultado = new Label();
            resultado_mostra = new Label();
            SuspendLayout();
            // 
            // soma
            // 
            soma.Location = new Point(96, 249);
            soma.Margin = new Padding(4, 4, 4, 4);
            soma.Name = "soma";
            soma.Size = new Size(118, 36);
            soma.TabIndex = 0;
            soma.Text = "Soma";
            soma.UseVisualStyleBackColor = true;
            soma.Click += soma_Click;
            // 
            // primeiro_numero
            // 
            primeiro_numero.AutoSize = true;
            primeiro_numero.Location = new Point(15, 80);
            primeiro_numero.Margin = new Padding(4, 0, 4, 0);
            primeiro_numero.Name = "primeiro_numero";
            primeiro_numero.Size = new Size(145, 25);
            primeiro_numero.TabIndex = 1;
            primeiro_numero.Text = "Primeiro número";
            // 
            // segundo_numero
            // 
            segundo_numero.AutoSize = true;
            segundo_numero.Location = new Point(15, 136);
            segundo_numero.Margin = new Padding(4, 0, 4, 0);
            segundo_numero.Name = "segundo_numero";
            segundo_numero.Size = new Size(151, 25);
            segundo_numero.TabIndex = 2;
            segundo_numero.Text = "Segundo número";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 80);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 31);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 132);
            textBox2.Margin = new Padding(4, 4, 4, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 31);
            textBox2.TabIndex = 4;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(15, 196);
            resultado.Margin = new Padding(4, 0, 4, 0);
            resultado.Name = "resultado";
            resultado.Size = new Size(90, 25);
            resultado.TabIndex = 5;
            resultado.Text = "Resultado";
            // 
            // resultado_mostra
            // 
            resultado_mostra.AutoSize = true;
            resultado_mostra.Location = new Point(176, 196);
            resultado_mostra.Margin = new Padding(4, 0, 4, 0);
            resultado_mostra.Name = "resultado_mostra";
            resultado_mostra.Size = new Size(22, 25);
            resultado_mostra.TabIndex = 6;
            resultado_mostra.Text = "0";
            resultado_mostra.Click += resultado_mostra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 494);
            Controls.Add(resultado_mostra);
            Controls.Add(resultado);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(segundo_numero);
            Controls.Add(primeiro_numero);
            Controls.Add(soma);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button soma;
        private Label primeiro_numero;
        private Label segundo_numero;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label resultado;
        private Label resultado_mostra;
    }
}