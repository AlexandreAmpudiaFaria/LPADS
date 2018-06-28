using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMenuCadastroProdutos_Click(object sender, EventArgs e)
        {
            frmCadastroProdutos frm = new frmCadastroProdutos();
            frm.Show();
        }

        private void btnEfetuarLoc_Click(object sender, EventArgs e)
        {
            frmLocacao frm = new frmLocacao();
            frm.Show();
        }

        private void btnMenuCadastrarCli_Click(object sender, EventArgs e)
        {
            frmCadastrarCliente frm = new frmCadastrarCliente();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRelatorios frm = new frmRelatorios();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTeste frm = new frmTeste();
            frm.Show();
        }

        private void btnEfetuarDevolucao_Click(object sender, EventArgs e)
        {
            frmDevolucao frm = new frmDevolucao();
            frm.Show();
        }
    }
}
