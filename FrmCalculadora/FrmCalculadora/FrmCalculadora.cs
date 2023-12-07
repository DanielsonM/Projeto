using System;
using System.Globalization;
using System.Windows.Forms;

namespace FrmCalculadora
{
    public partial class FrmCalculadora : Form
    {
        private decimal _valorUm;
        private decimal _valorDois;
        private string _strOperacao;
        private bool buttonGlobal = false;
        private int buttonGlobalOperador = 1;
        private bool botaoPonto = false;
        private int bntParaOperacoes = 0;

        private Calcular calculo = new Calcular();

        private string strOperacao
        {
            get
            {
                return _strOperacao;
            }
            set
            {
                _strOperacao = value;
            }
        }

        public decimal valorDois
        {
            get
            {
                return _valorDois;
            }
            set
            {
                _valorDois = value;
            }
        }

        public decimal valorUm
        {
            get
            {
                return _valorUm;
            }
            set
            {
                _valorUm = value;
            }
        }

        public FrmCalculadora()
        {
            InitializeComponent();

            this.repetirDigitacao();
            this.eventokeyDown();
        }

        public void eventokeyDown()
        {
            this.KeyDown += new KeyEventHandler(btnNum1_KeyDown);
            this.KeyDown += new KeyEventHandler(btnNum3_KeyDown);
            this.KeyDown += new KeyEventHandler(btnNum4_KeyDown);
            this.KeyDown += new KeyEventHandler(btnNum5_KeyDown);
            this.KeyDown += new KeyEventHandler(btnNum6_KeyDown);
            this.KeyDown += new KeyEventHandler(btnNum7_KeyDown);
            this.KeyDown += new KeyEventHandler(btnNum8_KeyDown);
            this.KeyDown += new KeyEventHandler(btnNum9_KeyDown);
            this.KeyDown += new KeyEventHandler(btnNum0_KeyDown);
            this.KeyDown += new KeyEventHandler(btnCe_KeyDown);
            this.KeyDown += new KeyEventHandler(btnMultiplicacao_KeyDown);
            this.KeyDown += new KeyEventHandler(btnSubtracao_KeyDown);
            this.KeyDown += new KeyEventHandler(btnDivisao_KeyDown);
            this.KeyDown += new KeyEventHandler(btnIqual_KeyDown);
            this.KeyDown += new KeyEventHandler(btnAdicao_KeyDown);
        }

        private void repetirDigitacao()
        {
            while (this.buttonGlobal)
            {
                this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
                this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
                this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
                this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
                this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
                this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
                this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
                this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
                this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
                this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            }
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            string zerar = this.lblResultado.Text;
            if (zerar.Length > 0 && this.buttonGlobal && !this.botaoPonto)
            {
                ((Label)lblResultado).Text = "";
                this.buttonGlobal = false;
                this.botaoPonto = false;
            }
            this.lblResultado.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            string zerar = this.lblResultado.Text;
            if (zerar.Length > 0 && this.buttonGlobal && !this.botaoPonto)
            {
                ((Label)lblResultado).Text = "";
                this.buttonGlobal = false;
                this.botaoPonto = false;
            }
            this.lblResultado.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            string zerar = this.lblResultado.Text;
            if (zerar.Length > 0 && this.buttonGlobal && !this.botaoPonto)
            {
                ((Label)lblResultado).Text = "";
                this.buttonGlobal = false;
                this.botaoPonto = false;
            }
            this.lblResultado.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            string zerar = this.lblResultado.Text;
            if (zerar.Length > 0 && this.buttonGlobal && !this.botaoPonto)
            {
                ((Label)lblResultado).Text = "";
                this.buttonGlobal = false;
                this.botaoPonto = false;
            }
            this.lblResultado.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            string zerar = this.lblResultado.Text;
            if (zerar.Length > 0 && this.buttonGlobal && !this.botaoPonto)
            {
                ((Label)lblResultado).Text = "";
                this.buttonGlobal = false;
                this.botaoPonto = false;
            }
            this.lblResultado.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            string zerar = this.lblResultado.Text;
            if (zerar.Length > 0 && this.buttonGlobal && !this.botaoPonto)
            {
                ((Label)lblResultado).Text = "";
                this.buttonGlobal = false;
                this.botaoPonto = false;
            }
            this.lblResultado.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            string zerar = this.lblResultado.Text;
            if (zerar.Length > 0 && this.buttonGlobal && !this.botaoPonto)
            {
                ((Label)lblResultado).Text = "";
                this.buttonGlobal = false;
                this.botaoPonto = false;
            }
            this.lblResultado.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            string zerar = this.lblResultado.Text;
            if (zerar.Length > 0 && this.buttonGlobal && !this.botaoPonto)
            {
                ((Label)lblResultado).Text = "";
                this.buttonGlobal = false;
                this.botaoPonto = false;
            }
            if (buttonGlobal)
            {
                ((Label)lblResultado).Text = "";
            }
            this.lblResultado.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            string zerar = this.lblResultado.Text;
            if (zerar.Length > 0 && this.buttonGlobal && !this.botaoPonto)
            {
                ((Label)lblResultado).Text = "";
                this.buttonGlobal = false;
                this.botaoPonto = false;
            }
            this.lblResultado.Text += "9";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            string zerar = this.lblResultado.Text;
            if (zerar.Length > 0 && this.buttonGlobal && !this.botaoPonto)
            {
                ((Label)lblResultado).Text = "";
                this.buttonGlobal = false;
                this.botaoPonto = false;
            }
            this.lblResultado.Text += "0";
        }

        private void btnIqual_Click(object sender, EventArgs e)
        {
            this.valorDois = Convert.ToDecimal(lblResultado.Text, new CultureInfo("pt-BR"));
            string resul = lblResultado.Text;
            decimal total = 0;

            switch (strOperacao)
            {
                case "SOMA":
                    decimal[] decArmazenar = new decimal[buttonGlobalOperador];

                    for (int i = 0; i < buttonGlobalOperador; i++)
                    {
                        decArmazenar[i] = this.valorDois;
                        if (decArmazenar[i] != 0)
                        {
                            total += decArmazenar[i];
                        }
                    }
                    lblResultado.Text = Convert.ToString(total);
                    break;

                case
                    "MULTIPLICACAO":
                    total = this.valorUm * this.valorDois;
                    this.lblResultado.Text = Convert.ToString(total);
                    break;

                case "DIVISAO":
                    total = this.valorUm / this.valorDois;
                    this.lblResultado.Text = Convert.ToString(total);
                    break;

                case "SUBTRACAO":
                    total = this.valorUm - this.valorDois;
                    this.lblResultado.Text = Convert.ToString(total);
                    break;

                case "PORCENTAGEM":
                    total = this.valorUm / this.valorDois;
                    this.lblResultado.Text = Convert.ToString(total);
                    break;

                default:
                    break;
            }
            if (true)
            {
            }
            buttonGlobal = true;
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            this.buttonGlobalOperador += 1;

            if (lblResultado.Text != "")
            {
                this.valorUm = Convert.ToDecimal(lblResultado.Text, new CultureInfo("pt-BR"));
                this.strOperacao = "SOMA";
                this.lblOperacao.Text = "+";
                this.lblValor.Text = Convert.ToString(valorUm, CultureInfo.InvariantCulture);
                this.lblResultado.Text = "";
                this.bntParaOperacoes += this.bntParaOperacoes + 1;
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (this.lblResultado.Text != "")
            {
                this.valorUm = Convert.ToDecimal(lblResultado.Text, CultureInfo.InvariantCulture);
                this.strOperacao = "MULTIPLICACAO";
                this.lblOperacao.Text = "x";
                this.lblResultado.Text = "";
                this.lblValor.Text = Convert.ToString(this.valorUm);
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (this.lblResultado.Text != "")
            {
                this.valorUm = Convert.ToDecimal(lblResultado.Text, CultureInfo.InvariantCulture);
                this.strOperacao = "SUBTRACAO";
                this.lblOperacao.Text = "-";
                this.lblResultado.Text = "";
                this.lblValor.Text = Convert.ToString(this.valorUm);
            }
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            if (this.lblResultado.Text != "")
            {
                this.valorUm = Convert.ToDecimal(lblResultado.Text, CultureInfo.InvariantCulture);
                this.strOperacao = "PORCENTAGEM";
                this.lblOperacao.Text = "%";
                this.lblResultado.Text = "";
                this.lblValor.Text = Convert.ToString(this.valorUm);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = "";
            this.lblValor.Text = "";
            this.lblOperacao.Text = "";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            string adicionarPonto = Convert.ToString(this.lblResultado.Text);
            if (adicionarPonto.StartsWith("") && adicionarPonto.Length < 0)
            {
                this.lblResultado.Text = ",";
            }
            else
            {
                this.lblResultado.Text = lblResultado.Text + ",";
            }

            this.botaoPonto = true;
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "")
            {
                this.lblResultado.Text = this.lblResultado.Text.Remove(this.lblResultado.Text.Length - 1);
            }
            else
            {
                return;
            }
        }

        private void btnNum1_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                this.btnNum1.PerformClick();
            }
        }

        private void btnNum2_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                this.btnNum2.PerformClick();
            }
        }

        private void btnNum3_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                this.btnNum3.PerformClick();
            }
        }

        private void btnNum4_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                this.btnNum4.PerformClick();
            }
        }

        private void btnNum5_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                this.btnNum5.PerformClick();
            }
        }

        private void btnNum6_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                this.btnNum6.PerformClick();
            }
        }

        private void btnNum7_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                this.btnNum7.PerformClick();
            }
        }

        private void btnNum8_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                this.btnNum8.PerformClick();
            }
        }

        private void btnNum9_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                this.btnNum9.PerformClick();
            }
        }

        public void btnNum0_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                this.btnNum0.PerformClick();
            }
        }

        private void btnCe_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            if (e.KeyCode == Keys.Back)
            {
                this.btnCe.PerformClick();
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDivisao_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.Oem2)
            {
                this.btnNum0.PerformClick();
            }
        }

        private void btnSubtracao_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                this.btnNum0.PerformClick();
            }
        }

        private void btnAdicao_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
            {
                this.btnNum0.PerformClick();
            }
        }

        private void btnIqual_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            if (e.KeyCode == Keys.Oemplus)
            {
                this.btnNum0.PerformClick();
            }
        }

        private void btnMultiplicacao_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            if (e.KeyCode == Keys.X || e.KeyCode == Keys.Multiply)
            {
                this.btnNum0.PerformClick();
            }
           
        }
    }
}