using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ContaTela
{
    public partial class TelaPoupanca : Form
    {
        public TelaPoupanca()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaPoupanca_Load(object sender, EventArgs e)
        {

        }
        List<Poupanca> poupancas = new List<Poupanca>();


        double valorInicial;
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Poupanca poupanca = new Poupanca();
            poupanca.nome = txtNome.Text;
            poupanca.cpf  = txtCPF.Text;
            poupanca.id = Convert.ToInt32(txtIdConta.Text);
            poupanca.saldo = Convert.ToDouble(txtSaldo.Text);
            popanca.dia = DateTime.Today;
            poupanca.dia = Convert.ToInt32(txtData.Text);
            valorInicial = poupanca.saldo;
            poupancas.Add(poupanca);
            MessageBox.Show(poupanca.exibirDados());
            txtNome.Text = "";
            txtCPF.Text = "";
            txtIdConta.Text = "";
            txtSaldo.Text = "";
            txtData.Text = "";
            txtData.Text = "";



        }
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < poupancas.Count; i++)
            {
                if (poupancas[i].cpf.Equals(txtCPF.Text))
                {

                    double deposito = Convert.ToDouble(txtSaldo.Text);
                    valorInicial += deposito;
                    MessageBox.Show($"deposito{valorInicial}");
                    txtCPF.Text = "";
                    txtSaldo.Text = "";
                }
            }
       
            
            
        }

        private void btnRendimento_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < poupancas.Count; i++)
            {
                if (poupancas[i].cpf.Equals(txtCPF.Text))
                {

                    double rendimento = (valorInicial * 0.1);
                    valorInicial += rendimento;
                   
                 //  string exibirmsg = "";
                   // exibirmsg += rendimento;
                    MessageBox.Show($"Rendimento {rendimento}");
                    txtCPF.Text = "";
                    txtSaldo.Text = "";
                }
            }

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < poupancas.Count; i++)
            {
                if (poupancas[i].cpf.Equals(txtCPF.Text))
                {

                    double saque = valorInicial - Convert.ToDouble(txtSaldo.Text);

                    //  string exibirmsg = "";
                    // exibirmsg += rendimento;
                    MessageBox.Show($"Saldo atual {saque}");
                    txtCPF.Text = "";
                    txtSaldo.Text = "";
                }
            }
        }
    }
}
