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
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void frmLocacao_Load(object sender, EventArgs e)
        {
            Camadas.BLL.produtosCarrinho bllCar = new Camadas.BLL.produtosCarrinho();
            bllCar.DeleteFim();
            Camadas.BLL.cabecalhoCarrinho bllCab = new Camadas.BLL.cabecalhoCarrinho();
            bllCab.DeleteFim();

            //lista de produtos na datagrid
            List<Camadas.MODEL.Produto> lstProd = new List<Camadas.MODEL.Produto>();
            Camadas.DAL.Produto dalProd = new Camadas.DAL.Produto();
            lstProd = dalProd.Select();
            dgvLocacaoProdutos.DataSource = lstProd;

            //lista de clientes na datagrid
            List<Camadas.MODEL.Cliente> lstCli = new List<Camadas.MODEL.Cliente>();
            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            lstCli= dalCli.Select();

            dgvClientesLocacao.DataSource = lstCli;



        }

        private void dgvClientesLocacao_DoubleClick(object sender, EventArgs e)
        {
          if (dgvClientesLocacao.SelectedRows.Count > 0) {

                    int id = Convert.ToInt32(dgvClientesLocacao.SelectedRows[0].Cells["id_cliente"].Value.ToString());
                    string nome_cli = dgvClientesLocacao.SelectedRows[0].Cells["nome"].Value.ToString();
                    Camadas.BLL.cabecalhoCarrinho bllCab = new Camadas.BLL.cabecalhoCarrinho();
                    List<Camadas.MODEL.cabecalhoCarrinho> carrinho = new List<Camadas.MODEL.cabecalhoCarrinho>();
                    bllCab.Insert(id,nome_cli);
                    carrinho = bllCab.Select();
                    dgvCabecalho.DataSource = "";
                    dgvCabecalho.DataSource = carrinho;
                }
                else
                {
                    MessageBox.Show("Erro nenhum produto selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
        }

        private void dgvLocacaoProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvLocacaoProdutos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvLocacaoProdutos.SelectedRows[0].Cells["id_produto"].Value.ToString());
                string descricao = dgvLocacaoProdutos.SelectedRows[0].Cells["descricao"].Value.ToString();
                string status;
                    status= dgvLocacaoProdutos.SelectedRows[0].Cells["status"].Value.ToString();
                
                Camadas.BLL.produtosCarrinho bllCar = new Camadas.BLL.produtosCarrinho();
                List<Camadas.MODEL.produtosCarrinho> carrinho = new List<Camadas.MODEL.produtosCarrinho>();
                if (status.Equals("L"))
                {
                    bllCar.Insert(id, descricao, status);
                    carrinho = bllCar.Select();
                    dgvCarrinhovenda.DataSource = "";
                    dgvCarrinhovenda.DataSource = "";
                    dgvCarrinhovenda.DataSource = carrinho;
                }
                else if (status.Equals("E"))
                {
                    MessageBox.Show("Produto Indisponivel no estoque !! Emprestado", " Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
            else
            {
                MessageBox.Show("Erro nenhum produto selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

           private void btnAddProd_Click(object sender, EventArgs e)
        {
            /*Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            Camadas.MODEL.Produto produto = new Camadas.MODEL.Produto();

            txtQuantCarrinho.Text = txtQuantiProdLoc.Text;
            txtNomeCLiCarrinho.Text = lblNomeCli.Text;
            txtIdCliCarrinho.Text = lblIdCliente.Text;
            txtDescCarrinho.Text = lblDescLocProd.Text;
            txtIDCarrinho.Text = lblIdLocProd.Text;*/
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCarrinho_Click(object sender, EventArgs e)
        {
            
      



        }

        private void btnLocar_Click(object sender, EventArgs e)
        {
            if (dgvCabecalho.SelectedRows.Count > 0 && dgvCarrinhovenda.SelectedRows.Count > 0)
            {
                string cliente = dgvCabecalho.SelectedRows[0].Cells["nome_cli"].Value.ToString();
                int id = Convert.ToInt32(dgvLocacaoProdutos.SelectedRows[0].Cells["id_produto"].Value.ToString());
                string descricao = dgvLocacaoProdutos.SelectedRows[0].Cells["descricao"].Value.ToString();
                string status = dgvLocacaoProdutos.SelectedRows[0].Cells["status"].Value.ToString();
                Camadas.BLL.Vendas bllVenda = new Camadas.BLL.Vendas();
                bllVenda.Insert(id, descricao, cliente);
                Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
                bllProd.UpdateVenda(id, status);
                MessageBox.Show("Locação Efetuada com sucesso", "Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Produto ou cliente não selecionado", "Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvLocacaoProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblQuantTest_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoverProdutoCarrinho_Click(object sender, EventArgs e)
        {
            if (dgvCarrinhovenda.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvCarrinhovenda.SelectedRows[0].Cells["id_produto"].Value.ToString());
                //string descricao = dgvLocacaoProdutos.SelectedRows[0].Cells["descricao"].Value.ToString();
                //int quant = Convert.ToInt32(dgvLocacaoProdutos.SelectedRows[0].Cells["quantidade"].Value.ToString());
                Camadas.BLL.produtosCarrinho bllCar = new Camadas.BLL.produtosCarrinho();
                List<Camadas.MODEL.produtosCarrinho> carrinho = new List<Camadas.MODEL.produtosCarrinho>();
                bllCar.Delete(id);
                carrinho = bllCar.Select();
                dgvCarrinhovenda.DataSource = "";
                dgvCarrinhovenda.DataSource = carrinho;
            }
            else
            {
                MessageBox.Show("Erro nenhum produto selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvClientesLocacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCarrinhovenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
