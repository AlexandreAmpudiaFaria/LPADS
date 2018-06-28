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
    public partial class frmCadastroProdutos : Form
    {
        public frmCadastroProdutos()
        {
            InitializeComponent();
        }

        private void frmCadastroProdutos_Load(object sender, EventArgs e)
        {
            List<Camadas.MODEL.Produto> lstProd = new List<Camadas.MODEL.Produto>();
            Camadas.DAL.Produto dalProd = new Camadas.DAL.Produto();
            lstProd = dalProd.Select();

            dgvCadProdutos.DataSource = lstProd;
        }

        private void btnInserirCadProd_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Produto produto = new Camadas.MODEL.Produto();
            //Camadas.DAL.Produto dalProd = new Camadas.DAL.Produto();
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();

            produto.descricao = txtDescricaoCadProd.Text;
            produto.status = txtStatusCadProd.Text;
            //produto.quantidade = Convert.ToInt32(txtQuantCadProd.Text);

            bllProd.Insert(produto);
            dgvCadProdutos.DataSource = "";
            dgvCadProdutos.DataSource = bllProd.Select();
        }

        private void btnEditarCadProd_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Produto produto = new Camadas.MODEL.Produto();
            //Camadas.DAL.Produto dalProd = new Camadas.DAL.Produto();
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();

            produto.id_produto = Convert.ToInt32(txtIdCadProd.Text);
            produto.descricao = txtDescricaoCadProd.Text;
            produto.status = txtStatusCadProd.Text;
            //produto.quantidade = Convert.ToInt32(txtQuantCadProd.Text);

            bllProd.Update(produto);
            dgvCadProdutos.DataSource = "";
            dgvCadProdutos.DataSource = bllProd.Select();
        }

        private void btnRemoverCadProd_Click(object sender, EventArgs e)
        {
            //Camadas.DAL.Produto dalProd = new Camadas.DAL.Produto();
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();

            int id_produto = Convert.ToInt32(txtIdCadProd.Text);
            

            bllProd.Delete(id_produto);
            dgvCadProdutos.DataSource = "";
            dgvCadProdutos.DataSource = bllProd.Select();
        }

        private void btnCancelarCadProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
