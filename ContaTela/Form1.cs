using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaTela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form tela;
        private void btnPoupanca_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaPoupanca
            {
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            pnlTelas.Controls.Add(tela);
            tela.Show();
        }

        private void bntInvestimento_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaEspecial
            {
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            pnlTelas.Controls.Add(tela);
            tela.Show();
        }
    }
}
