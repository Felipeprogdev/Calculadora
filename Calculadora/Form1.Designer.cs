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
            texto = new TextBox();
            subtracao = new Button();
            divisao = new Button();
            multiplicacao = new Button();
            um = new Button();
            dois = new Button();
            tres = new Button();
            quatro = new Button();
            cinco = new Button();
            seis = new Button();
            sete = new Button();
            oito = new Button();
            nove = new Button();
            igual = new Button();
            zero = new Button();
            SuspendLayout();
            // 
            // soma
            // 
            soma.Location = new Point(281, 316);
            soma.Margin = new Padding(4);
            soma.Name = "soma";
            soma.Size = new Size(41, 36);
            soma.TabIndex = 0;
            soma.Text = "+";
            soma.UseVisualStyleBackColor = true;
            soma.Click += soma_Click;
            // 
            // texto
            // 
            texto.Location = new Point(44, 72);
            texto.Margin = new Padding(4);
            texto.Name = "texto";
            texto.Size = new Size(266, 31);
            texto.TabIndex = 3;
            texto.TextChanged += textBox1_TextChanged;
            // 
            // subtracao
            // 
            subtracao.Location = new Point(281, 257);
            subtracao.Margin = new Padding(4);
            subtracao.Name = "subtracao";
            subtracao.Size = new Size(41, 36);
            subtracao.TabIndex = 4;
            subtracao.Text = "-";
            subtracao.UseVisualStyleBackColor = true;
            subtracao.Click += subtracao_Click;
            // 
            // divisao
            // 
            divisao.Location = new Point(281, 376);
            divisao.Margin = new Padding(4);
            divisao.Name = "divisao";
            divisao.Size = new Size(41, 36);
            divisao.TabIndex = 5;
            divisao.Text = "/";
            divisao.UseVisualStyleBackColor = true;
            divisao.Click += divisao_Click;
            // 
            // multiplicacao
            // 
            multiplicacao.Location = new Point(281, 432);
            multiplicacao.Margin = new Padding(4);
            multiplicacao.Name = "multiplicacao";
            multiplicacao.Size = new Size(41, 36);
            multiplicacao.TabIndex = 6;
            multiplicacao.Text = "*";
            multiplicacao.UseVisualStyleBackColor = true;
            multiplicacao.Click += multiplicacao_Click;
            // 
            // um
            // 
            um.Location = new Point(82, 305);
            um.Name = "um";
            um.Size = new Size(39, 56);
            um.TabIndex = 7;
            um.Text = "1";
            um.UseVisualStyleBackColor = true;
            um.Click += um_Click;
            // 
            // dois
            // 
            dois.Location = new Point(144, 305);
            dois.Name = "dois";
            dois.Size = new Size(39, 56);
            dois.TabIndex = 8;
            dois.Text = "2";
            dois.UseVisualStyleBackColor = true;
            dois.Click += dois_Click;
            // 
            // tres
            // 
            tres.Location = new Point(201, 305);
            tres.Name = "tres";
            tres.Size = new Size(39, 56);
            tres.TabIndex = 9;
            tres.Text = "3";
            tres.UseVisualStyleBackColor = true;
            tres.Click += tres_Click;
            // 
            // quatro
            // 
            quatro.Location = new Point(82, 215);
            quatro.Name = "quatro";
            quatro.Size = new Size(39, 56);
            quatro.TabIndex = 10;
            quatro.Text = "4";
            quatro.UseVisualStyleBackColor = true;
            quatro.Click += quatro_Click;
            // 
            // cinco
            // 
            cinco.Location = new Point(144, 215);
            cinco.Name = "cinco";
            cinco.Size = new Size(39, 56);
            cinco.TabIndex = 11;
            cinco.Text = "5";
            cinco.UseVisualStyleBackColor = true;
            cinco.Click += cinco_Click;
            // 
            // seis
            // 
            seis.Location = new Point(201, 215);
            seis.Name = "seis";
            seis.Size = new Size(39, 56);
            seis.TabIndex = 12;
            seis.Text = "6";
            seis.UseVisualStyleBackColor = true;
            seis.Click += seis_Click;
            // 
            // sete
            // 
            sete.Location = new Point(82, 121);
            sete.Name = "sete";
            sete.Size = new Size(39, 56);
            sete.TabIndex = 13;
            sete.Text = "7";
            sete.UseVisualStyleBackColor = true;
            sete.Click += sete_Click;
            // 
            // oito
            // 
            oito.Location = new Point(144, 121);
            oito.Name = "oito";
            oito.Size = new Size(39, 56);
            oito.TabIndex = 14;
            oito.Text = "8";
            oito.UseVisualStyleBackColor = true;
            oito.Click += oito_Click;
            // 
            // nove
            // 
            nove.Location = new Point(201, 121);
            nove.Name = "nove";
            nove.Size = new Size(39, 56);
            nove.TabIndex = 15;
            nove.Text = "9";
            nove.UseVisualStyleBackColor = true;
            nove.Click += nove_Click;
            // 
            // igual
            // 
            igual.Location = new Point(76, 426);
            igual.Name = "igual";
            igual.Size = new Size(158, 56);
            igual.TabIndex = 16;
            igual.Text = "=";
            igual.UseVisualStyleBackColor = true;
            igual.Click += igual_Click;
            // 
            // zero
            // 
            zero.Location = new Point(144, 376);
            zero.Name = "zero";
            zero.Size = new Size(39, 36);
            zero.TabIndex = 17;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += zero_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 494);
            Controls.Add(zero);
            Controls.Add(igual);
            Controls.Add(nove);
            Controls.Add(oito);
            Controls.Add(sete);
            Controls.Add(seis);
            Controls.Add(cinco);
            Controls.Add(quatro);
            Controls.Add(tres);
            Controls.Add(dois);
            Controls.Add(um);
            Controls.Add(multiplicacao);
            Controls.Add(divisao);
            Controls.Add(subtracao);
            Controls.Add(texto);
            Controls.Add(soma);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button soma;
        private TextBox texto;
        private Button subtracao;
        private Button divisao;
        private Button multiplicacao;
        private Button um;
        private Button dois;
        private Button tres;
        private Button quatro;
        private Button cinco;
        private Button seis;
        private Button sete;
        private Button oito;
        private Button nove;
        private Button igual;
        private Button zero;
    }
}