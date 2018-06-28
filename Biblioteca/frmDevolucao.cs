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
    public partial class frmDevolucao : Form
    {
        public frmDevolucao()
        {
            InitializeComponent();
        }

        private void dgvDevolucao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDevolucao_Load(object sender, EventArgs e)
        {
            List<Camadas.MODEL.Produto> lstProd = new List<Camadas.MODEL.Produto>();
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();

            lstProd = bllProd.SelectByStatus("E");

            dgvDevolucao.DataSource = "";
            dgvDevolucao.DataSource = lstProd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvDevolucao.SelectedRows.Count > 0 )
            {
                int id = Convert.ToInt32(dgvDevolucao.SelectedRows[0].Cells["id_produto"].Value.ToString());
                string status = dgvDevolucao.SelectedRows[0].Cells["status"].Value.ToString();
                Camadas.BLL.Produto bllVenda = new Camadas.BLL.Produto();
                bllVenda.UpdateByStatus(id, status);
                MessageBox.Show("Devolução efetuada com sucesso !", " Devolução", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // atualizando a grid
                List<Camadas.MODEL.Produto> lstProd = new List<Camadas.MODEL.Produto>();
                Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();

                lstProd = bllProd.SelectByStatus("E");

                dgvDevolucao.DataSource = "";
                dgvDevolucao.DataSource = lstProd;


            }
            else
            {
                MessageBox.Show("Produto ou cliente não selecionado", "Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
