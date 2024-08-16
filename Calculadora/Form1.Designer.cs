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
            texResultado = new TextBox();
            btnOito = new Button();
            btnDivisao = new Button();
            btnNove = new Button();
            btnSete = new Button();
            bntQuatro = new Button();
            btnSeis = new Button();
            btnmultiplicacao = new Button();
            bntCinco = new Button();
            btnUm = new Button();
            btnTres = new Button();
            btnZero = new Button();
            btnDois = new Button();
            btnIgual = new Button();
            ntbVirgula = new Button();
            btnSubtracao = new Button();
            btnAdicao = new Button();
            btnLimpar = new Button();
            lblOperacao = new Label();
            SuspendLayout();
            // 
            // texResultado
            // 
            texResultado.Location = new Point(12, 12);
            texResultado.Name = "texResultado";
            texResultado.Size = new Size(176, 23);
            texResultado.TabIndex = 0;
            texResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(62, 78);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(38, 42);
            btnOito.TabIndex = 1;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(150, 78);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(38, 42);
            btnDivisao.TabIndex = 2;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(106, 78);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(38, 42);
            btnNove.TabIndex = 3;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += ctnNove_Click;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(18, 78);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(38, 42);
            btnSete.TabIndex = 4;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // bntQuatro
            // 
            bntQuatro.Location = new Point(18, 126);
            bntQuatro.Name = "bntQuatro";
            bntQuatro.Size = new Size(38, 42);
            bntQuatro.TabIndex = 8;
            bntQuatro.Text = "4";
            bntQuatro.UseVisualStyleBackColor = true;
            bntQuatro.Click += bntQuatro_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(106, 126);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(38, 42);
            btnSeis.TabIndex = 7;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnmultiplicacao
            // 
            btnmultiplicacao.Location = new Point(150, 126);
            btnmultiplicacao.Name = "btnmultiplicacao";
            btnmultiplicacao.Size = new Size(38, 42);
            btnmultiplicacao.TabIndex = 6;
            btnmultiplicacao.Text = "x";
            btnmultiplicacao.UseVisualStyleBackColor = true;
            btnmultiplicacao.Click += btnmultiplicacao_Click;
            // 
            // bntCinco
            // 
            bntCinco.Location = new Point(62, 126);
            bntCinco.Name = "bntCinco";
            bntCinco.Size = new Size(38, 42);
            bntCinco.TabIndex = 5;
            bntCinco.Text = "5";
            bntCinco.UseVisualStyleBackColor = true;
            bntCinco.Click += bntCinco_Click;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(18, 174);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(38, 42);
            btnUm.TabIndex = 12;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(106, 174);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(38, 42);
            btnTres.TabIndex = 11;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(62, 222);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(38, 42);
            btnZero.TabIndex = 10;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(62, 174);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(38, 42);
            btnDois.TabIndex = 9;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(106, 222);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(38, 42);
            btnIgual.TabIndex = 13;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // ntbVirgula
            // 
            ntbVirgula.Location = new Point(18, 222);
            ntbVirgula.Name = "ntbVirgula";
            ntbVirgula.Size = new Size(38, 42);
            ntbVirgula.TabIndex = 14;
            ntbVirgula.Text = ",";
            ntbVirgula.UseVisualStyleBackColor = true;
            ntbVirgula.Click += ntbVirgula_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(150, 174);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(38, 42);
            btnSubtracao.TabIndex = 15;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.Location = new Point(150, 222);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(38, 42);
            btnAdicao.TabIndex = 16;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = true;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(150, 49);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(38, 27);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(15, 16);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 15);
            lblOperacao.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(196, 279);
            Controls.Add(lblOperacao);
            Controls.Add(btnLimpar);
            Controls.Add(btnAdicao);
            Controls.Add(btnSubtracao);
            Controls.Add(ntbVirgula);
            Controls.Add(btnIgual);
            Controls.Add(btnUm);
            Controls.Add(btnTres);
            Controls.Add(btnZero);
            Controls.Add(btnDois);
            Controls.Add(bntQuatro);
            Controls.Add(btnSeis);
            Controls.Add(btnmultiplicacao);
            Controls.Add(bntCinco);
            Controls.Add(btnSete);
            Controls.Add(btnNove);
            Controls.Add(btnDivisao);
            Controls.Add(btnOito);
            Controls.Add(texResultado);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox texResultado;
        private Button btnOito;
        private Button btnDivisao;
        private Button btnNove;
        private Button btnSete;
        private Button bntQuatro;
        private Button btnSeis;
        private Button btnmultiplicacao;
        private Button bntCinco;
        private Button btnUm;
        private Button btnTres;
        private Button btnZero;
        private Button btnDois;
        private Button btnIgual;
        private Button ntbVirgula;
        private Button btnSubtracao;
        private Button btnAdicao;
        private Button btnLimpar;
        private Label lblOperacao;
    }
}
