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
            deletar = new Button();
            SuspendLayout();
            // 
            // soma
            // 
            soma.BackColor = SystemColors.WindowFrame;
            soma.Location = new Point(281, 316);
            soma.Margin = new Padding(4);
            soma.Name = "soma";
            soma.Size = new Size(41, 36);
            soma.TabIndex = 0;
            soma.Text = "+";
            soma.UseVisualStyleBackColor = false;
            soma.Click += soma_Click;
            // 
            // texto
            // 
            texto.BackColor = Color.DarkSeaGreen;
            texto.Location = new Point(35, 54);
            texto.Margin = new Padding(4);
            texto.Name = "texto";
            texto.Size = new Size(259, 31);
            texto.TabIndex = 3;
            texto.TextChanged += textBox1_TextChanged;
            // 
            // subtracao
            // 
            subtracao.BackColor = SystemColors.WindowFrame;
            subtracao.Location = new Point(281, 256);
            subtracao.Margin = new Padding(4);
            subtracao.Name = "subtracao";
            subtracao.Size = new Size(41, 36);
            subtracao.TabIndex = 4;
            subtracao.Text = "-";
            subtracao.UseVisualStyleBackColor = false;
            subtracao.Click += subtracao_Click;
            // 
            // divisao
            // 
            divisao.BackColor = SystemColors.WindowFrame;
            divisao.Location = new Point(281, 376);
            divisao.Margin = new Padding(4);
            divisao.Name = "divisao";
            divisao.Size = new Size(41, 36);
            divisao.TabIndex = 5;
            divisao.Text = "/";
            divisao.UseVisualStyleBackColor = false;
            divisao.Click += divisao_Click;
            // 
            // multiplicacao
            // 
            multiplicacao.BackColor = SystemColors.WindowFrame;
            multiplicacao.Location = new Point(281, 436);
            multiplicacao.Margin = new Padding(4);
            multiplicacao.Name = "multiplicacao";
            multiplicacao.Size = new Size(41, 36);
            multiplicacao.TabIndex = 6;
            multiplicacao.Text = "*";
            multiplicacao.UseVisualStyleBackColor = false;
            multiplicacao.Click += multiplicacao_Click;
            // 
            // um
            // 
            um.BackColor = SystemColors.WindowFrame;
            um.Location = new Point(82, 305);
            um.Margin = new Padding(2);
            um.Name = "um";
            um.Size = new Size(39, 56);
            um.TabIndex = 7;
            um.Text = "1";
            um.UseVisualStyleBackColor = false;
            um.Click += um_Click;
            // 
            // dois
            // 
            dois.BackColor = SystemColors.WindowFrame;
            dois.Location = new Point(144, 305);
            dois.Margin = new Padding(2);
            dois.Name = "dois";
            dois.Size = new Size(39, 56);
            dois.TabIndex = 8;
            dois.Text = "2";
            dois.UseVisualStyleBackColor = false;
            dois.Click += dois_Click;
            // 
            // tres
            // 
            tres.BackColor = SystemColors.WindowFrame;
            tres.Location = new Point(201, 305);
            tres.Margin = new Padding(2);
            tres.Name = "tres";
            tres.Size = new Size(39, 56);
            tres.TabIndex = 9;
            tres.Text = "3";
            tres.UseVisualStyleBackColor = false;
            tres.Click += tres_Click;
            // 
            // quatro
            // 
            quatro.BackColor = SystemColors.WindowFrame;
            quatro.Location = new Point(82, 215);
            quatro.Margin = new Padding(2);
            quatro.Name = "quatro";
            quatro.Size = new Size(39, 56);
            quatro.TabIndex = 10;
            quatro.Text = "4";
            quatro.UseVisualStyleBackColor = false;
            quatro.Click += quatro_Click;
            // 
            // cinco
            // 
            cinco.BackColor = SystemColors.WindowFrame;
            cinco.Location = new Point(144, 215);
            cinco.Margin = new Padding(2);
            cinco.Name = "cinco";
            cinco.Size = new Size(39, 56);
            cinco.TabIndex = 11;
            cinco.Text = "5";
            cinco.UseVisualStyleBackColor = false;
            cinco.Click += cinco_Click;
            // 
            // seis
            // 
            seis.BackColor = SystemColors.WindowFrame;
            seis.Location = new Point(201, 215);
            seis.Margin = new Padding(2);
            seis.Name = "seis";
            seis.Size = new Size(39, 56);
            seis.TabIndex = 12;
            seis.Text = "6";
            seis.UseVisualStyleBackColor = false;
            seis.Click += seis_Click;
            // 
            // sete
            // 
            sete.BackColor = SystemColors.WindowFrame;
            sete.Location = new Point(82, 121);
            sete.Margin = new Padding(2);
            sete.Name = "sete";
            sete.Size = new Size(39, 56);
            sete.TabIndex = 13;
            sete.Text = "7";
            sete.UseVisualStyleBackColor = false;
            sete.Click += sete_Click;
            // 
            // oito
            // 
            oito.BackColor = SystemColors.WindowFrame;
            oito.Location = new Point(144, 121);
            oito.Margin = new Padding(2);
            oito.Name = "oito";
            oito.Size = new Size(39, 56);
            oito.TabIndex = 14;
            oito.Text = "8";
            oito.UseVisualStyleBackColor = false;
            oito.Click += oito_Click;
            // 
            // nove
            // 
            nove.BackColor = SystemColors.WindowFrame;
            nove.Location = new Point(201, 121);
            nove.Margin = new Padding(2);
            nove.Name = "nove";
            nove.Size = new Size(39, 56);
            nove.TabIndex = 15;
            nove.Text = "9";
            nove.UseVisualStyleBackColor = false;
            nove.Click += nove_Click;
            // 
            // igual
            // 
            igual.BackColor = SystemColors.WindowFrame;
            igual.Location = new Point(76, 426);
            igual.Margin = new Padding(2);
            igual.Name = "igual";
            igual.Size = new Size(158, 56);
            igual.TabIndex = 16;
            igual.Text = "=";
            igual.UseVisualStyleBackColor = false;
            igual.Click += igual_Click;
            // 
            // zero
            // 
            zero.BackColor = SystemColors.WindowFrame;
            zero.Location = new Point(144, 376);
            zero.Margin = new Padding(2);
            zero.Name = "zero";
            zero.Size = new Size(39, 36);
            zero.TabIndex = 17;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += zero_Click;
            // 
            // deletar
            // 
            deletar.BackColor = SystemColors.WindowFrame;
            deletar.Location = new Point(281, 202);
            deletar.Name = "deletar";
            deletar.Size = new Size(41, 34);
            deletar.TabIndex = 18;
            deletar.Text = "<-";
            deletar.UseVisualStyleBackColor = false;
            deletar.Click += deletar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(352, 537);
            Controls.Add(deletar);
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
            Controls.Add(soma);
            Controls.Add(texto);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
        private Button deletar;
    }
}