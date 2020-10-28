using Maquina_de_Cafe_Virtual.Controle;
using Maquina_de_Cafe_Virtual.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquina_de_Cafe_Virtual
{
    public partial class TelaPrincipal : Form
    {
        Logica Comandos = new Logica();
        bool statusCompra = false;
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void buttonCappucino_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos novoProduto = new Produtos("Cappucino", 3.50);
                Comandos.RecebeProduto(novoProduto);
                imgEntregaCappuccino.Visible = true;
                lblEntrega.Visible = true;
                lblEntrega.Text = "Saboreie seu Cappucino";
            }
            catch (Exception)
            {
                MessageBox.Show(Comandos.mensagemErro);
            }
        }
        private void btnMocha_Click(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (statusCompra == false)
            {
                groupBoxMoedas.Visible = true;
                btn1Centavo.Visible = true;
                btn5Centavos.Visible = true;
                btn10Centavos.Visible = true;
                btn25Centavos.Visible = true;
                btn50Centavos.Visible = true;
                btn1Real.Visible = true;

                btnCancelar.Enabled = true;
                statusCompra = true;
            }
            else if (groupBoxTroco.Visible == false)
            {
                groupBoxValorCreditado.Visible = false;
                lblValorCreditado.Visible = false;
                Moedas novaMoeda = new Moedas("0 Centavos", 0);
                Comandos.AtualizaValorCreditado(novaMoeda);
                lblValorCreditado.Text = "0";

                groupBoxTroco.Visible = false;
                imgTroco10Centavos.Visible = false;
                imgTroco25Centavos.Visible = false;
                imgTroco50Centavos.Visible = false;
                imgTroco1Real.Visible = false;

                btnCafeComLeite.Enabled = false;
                btnCappucino.Enabled = false;
                btnMocha.Enabled = false;
                imgSetaCafeComLeite.Visible = false;
                imgSetaCapuccino.Visible = false;
                imgSetaMocha.Visible = false;

                imgEntregaCappuccino.Visible = false;
                lblEntrega.Visible = false;

                lblDefeitoNaLeitoraMoedas.Visible = false;
                btnCancelar.Enabled = true;
                statusCompra = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (statusCompra == true)
            {
                btnCancelar.Enabled = false;
                statusCompra = false;

                groupBoxMoedas.Visible = false;
                btn1Centavo.Visible = false;
                btn5Centavos.Visible = false;
                btn10Centavos.Visible = false;
                btn25Centavos.Visible = false;
                btn50Centavos.Visible = false;
                btn1Real.Visible = false;

                groupBoxValorCreditado.Visible = false;
                lblValorCreditado.Visible = false;
                Moedas novaMoeda = new Moedas("0 Centavos", 0);
                Comandos.AtualizaValorCreditado(novaMoeda);
                lblValorCreditado.Text = "0";

                groupBoxTroco.Visible = false;
                imgTroco10Centavos.Visible = false;
                imgTroco25Centavos.Visible = false;
                imgTroco50Centavos.Visible = false;
                imgTroco1Real.Visible = false;

                btnCafeComLeite.Enabled = false;
                btnCappucino.Enabled = false;
                btnMocha.Enabled = false;
                imgSetaCafeComLeite.Visible = false;
                imgSetaCapuccino.Visible = false;
                imgSetaMocha.Visible = false;

                imgEntregaCappuccino.Visible = false;
                lblEntrega.Visible = false;

                lblDefeitoNaLeitoraMoedas.Visible = false;
            }

        }

        private void btn1Centavo_Click(object sender, EventArgs e)
        {
            lblDefeitoNaLeitoraMoedas.Visible = true;
        }

        private void btn5Centavos_Click(object sender, EventArgs e)
        {
            lblDefeitoNaLeitoraMoedas.Visible = true;
        }

        private void btn10Centavos_Click(object sender, EventArgs e)
        {
            try
            {
                lblDefeitoNaLeitoraMoedas.Visible = false;
                groupBoxValorCreditado.Visible = true;
                lblValorCreditado.Visible = true;
                Moedas novaMoeda = new Moedas("10 Centavos", 0.10);
                lblValorCreditado.Text = Comandos.AtualizaValorCreditado(novaMoeda);
                AtivaBotaoProduto(Comandos.RecebeValorOpçãoDeProduto());
            }
            catch (Exception)
            {
                MessageBox.Show(Comandos.mensagemErro);
            }
        }

        private void btn25Centavos_Click(object sender, EventArgs e)
        {
            try
            {
                lblDefeitoNaLeitoraMoedas.Visible = false;
                groupBoxValorCreditado.Visible = true;
                lblValorCreditado.Visible = true;
                Moedas novaMoeda = new Moedas("25 Centavos", 0.25);
                lblValorCreditado.Text = Comandos.AtualizaValorCreditado(novaMoeda);
                AtivaBotaoProduto(Comandos.RecebeValorOpçãoDeProduto());
            }
            catch (Exception)
            {
                MessageBox.Show(Comandos.mensagemErro);
            }
        }

        private void btn50Centavos_Click(object sender, EventArgs e)
        {
            try
            {
                lblDefeitoNaLeitoraMoedas.Visible = false;
                groupBoxValorCreditado.Visible = true;
                lblValorCreditado.Visible = true;
                Moedas novaMoeda = new Moedas("50 Centavos", 0.50);
                lblValorCreditado.Text = Comandos.AtualizaValorCreditado(novaMoeda);
                AtivaBotaoProduto(Comandos.RecebeValorOpçãoDeProduto());
            }
            catch (Exception)
            {
                MessageBox.Show(Comandos.mensagemErro);
            }
        }

        private void btn1Real_Click(object sender, EventArgs e)
        {
            try
            {
                lblDefeitoNaLeitoraMoedas.Visible = false;
                groupBoxValorCreditado.Visible = true;
                lblValorCreditado.Visible = true;
                Moedas novaMoeda = new Moedas("1 Real", 1);
                lblValorCreditado.Text = Comandos.AtualizaValorCreditado(novaMoeda);
                AtivaBotaoProduto(Comandos.RecebeValorOpçãoDeProduto());
            }
            catch (Exception)
            {
                MessageBox.Show(Comandos.mensagemErro);
            }
        }
        private void AtivaBotaoProduto(double[] AtivaBotaoProduto)
        {
            foreach (double obj in AtivaBotaoProduto)
            {
                if (obj == 1)
                {
                    btnCafeComLeite.Enabled = true;
                    imgSetaCafeComLeite.Visible = true;
                }
                else if (obj == 2)
                {
                    btnCafeComLeite.Enabled = true;
                    btnCappucino.Enabled = true;
                    imgSetaCafeComLeite.Visible = true;
                    imgSetaCapuccino.Visible = true;
                }
                else if (obj == 3)
                {
                    btnCafeComLeite.Enabled = true;
                    btnCappucino.Enabled = true;
                    btnMocha.Enabled = true;
                    imgSetaCafeComLeite.Visible = true;
                    imgSetaCapuccino.Visible = true;
                    imgSetaMocha.Visible = true;
                }
            }
        }

        private void lblValorCreditado_Leave(object sender, EventArgs e)
        {
            try
            {
                if (lblValorCreditado.Text.Length > 0)
                {
                    lblValorCreditado.Text = Convert.ToDouble(lblValorCreditado.Text).ToString("C");
                }
            }
            catch (Exception a)
            {

                MessageBox.Show("Error" + a.Message);
            }
        }

    }
}
