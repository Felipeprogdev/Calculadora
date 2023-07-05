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
            soma.Location = new Point(77, 199);
            soma.Name = "soma";
            soma.Size = new Size(94, 29);
            soma.TabIndex = 0;
            soma.Text = "Soma";
            soma.UseVisualStyleBackColor = true;
            // 
            // primeiro_numero
            // 
            primeiro_numero.AutoSize = true;
            primeiro_numero.Location = new Point(12, 64);
            primeiro_numero.Name = "primeiro_numero";
            primeiro_numero.Size = new Size(120, 20);
            primeiro_numero.TabIndex = 1;
            primeiro_numero.Text = "Primeiro número";
            // 
            // segundo_numero
            // 
            segundo_numero.AutoSize = true;
            segundo_numero.Location = new Point(12, 109);
            segundo_numero.Name = "segundo_numero";
            segundo_numero.Size = new Size(123, 20);
            segundo_numero.TabIndex = 2;
            segundo_numero.Text = "Segundo número";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(12, 157);
            resultado.Name = "resultado";
            resultado.Size = new Size(75, 20);
            resultado.TabIndex = 5;
            resultado.Text = "Resultado";
            // 
            // resultado_mostra
            // 
            resultado_mostra.AutoSize = true;
            resultado_mostra.Location = new Point(141, 157);
            resultado_mostra.Name = "resultado_mostra";
            resultado_mostra.Size = new Size(17, 20);
            resultado_mostra.TabIndex = 6;
            resultado_mostra.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 395);
            Controls.Add(resultado_mostra);
            Controls.Add(resultado);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(segundo_numero);
            Controls.Add(primeiro_numero);
            Controls.Add(soma);
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