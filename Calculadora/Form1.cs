namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtratacao,
            Multiplicacao,
            Divisao
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void ctnNove_Click(object sender, EventArgs e)
        {
            texResultado.Text += "9";
        }

        private void bntCinco_Click(object sender, EventArgs e)
        {
            texResultado.Text += "5";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            texResultado.Text += "0";
        }

        private void bntQuatro_Click(object sender, EventArgs e)
        {
            texResultado.Text += "4";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            texResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            texResultado.Text += "8";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            texResultado.Text += "6";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            texResultado.Text += "3";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            texResultado.Text += "2";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            texResultado.Text += "1";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(texResultado.Text);
            texResultado.Text = "";
            lblOperacao.Text = "+";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtratacao;
            Valor = Convert.ToDecimal(texResultado.Text);
            texResultado.Text = "";
            lblOperacao.Text = "-";
        }

        private void btnmultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(texResultado.Text);
            texResultado.Text = "";
            lblOperacao.Text = "x";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(texResultado.Text);
            texResultado.Text = "";
            lblOperacao.Text = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(texResultado.Text);
                    break;
                case Operacao.Subtratacao:
                    Resultado = Valor - Convert.ToDecimal(texResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(texResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(texResultado.Text);
                    break;
            }
            texResultado.Text = Convert.ToString(Resultado);
            lblOperacao.Text = "=";
        }

        private void ntbVirgula_Click(object sender, EventArgs e)
        {
            if (!texResultado.Text.Contains(","))
                texResultado.Text += ",";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            texResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void texResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
