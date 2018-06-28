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
    public partial class frmRelatorios : Form
    {
        public frmRelatorios()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close(); // botao sair
        }

        private void rdbTodosFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTodosFiltro.Checked)
            {
                List<Camadas.MODEL.Produto> lstProd = new List<Camadas.MODEL.Produto>();
                Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
                lstProd = bllProd.Select();

                dgvRelatorioProd.DataSource = "";
                dgvRelatorioProd.DataSource = lstProd;
            }
        }

        private void rdbLocadosFiltro_CheckedChanged(object sender, EventArgs e)
        {
            List<Camadas.MODEL.Produto> lstProd = new List<Camadas.MODEL.Produto>();
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();

            lstProd = bllProd.SelectByStatus("E");

            dgvRelatorioProd.DataSource = "";
            dgvRelatorioProd.DataSource = lstProd;

            
        }

        private void rdbLivresFiltro_CheckedChanged(object sender, EventArgs e)
        {
            List<Camadas.MODEL.Produto> lstProd = new List<Camadas.MODEL.Produto>();
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();

            lstProd = bllProd.SelectByStatus("L");

            dgvRelatorioProd.DataSource = "";
            dgvRelatorioProd.DataSource = lstProd;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExibirClientes_Click(object sender, EventArgs e)
        {
            List<Camadas.MODEL.Cliente> lstCli = new List<Camadas.MODEL.Cliente>();
            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            lstCli = dalCli.Select();

            dgvRelatorioCli.DataSource = lstCli;

            
        }

        private void dgvRelatorioVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

        private void dgvRelatorioCli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVendasRelatorio_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Vendas bllVend = new Camadas.BLL.Vendas();
            List<Camadas.MODEL.Vendas> lstVenda = new List<Camadas.MODEL.Vendas>();
            //Camadas.DAL.Vendas bllVend = new Camadas.DAL.Vendas();


            lstVenda = bllVend.Select();
            dgvRelatorioVendas.DataSource = "";
            dgvRelatorioVendas.DataSource = lstVenda;
        }
    }
}
