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
    public partial class frmCadastrarCliente : Form
    {
        public frmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserirCadCli_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Cliente cliente = new Camadas.MODEL.Cliente();
            //Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();

            cliente.nome = txtNomeCadCli.Text;
            

            bllCli.Insert(cliente);
            dgvCadCliente.DataSource = "";
            dgvCadCliente.DataSource = bllCli.Select();
        }

        private void frmCadastrarCliente_Load(object sender, EventArgs e)
        {
            List<Camadas.MODEL.Cliente> lstCli = new List<Camadas.MODEL.Cliente>();
            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            lstCli= dalCli.Select();

            dgvCadCliente.DataSource = lstCli;
        }

        private void btnEditarCadCli_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Cliente cliente = new Camadas.MODEL.Cliente();
            //Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();

            cliente.id_cliente = Convert.ToInt32(txtIdCadCli.Text);
            cliente.nome = txtNomeCadCli.Text;
            

            bllCli.Update(cliente);
            dgvCadCliente.DataSource = "";
            dgvCadCliente.DataSource = bllCli.Select();
        }

        private void btnRemoverCadCli_Click(object sender, EventArgs e)
        {
            //Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();

            int id_cliente = Convert.ToInt32(txtIdCadCli.Text);


            bllCli.Delete(id_cliente);
            dgvCadCliente.DataSource = "";
            dgvCadCliente.DataSource = bllCli.Select();
        }

        private void btnCancelarCadCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCadCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
