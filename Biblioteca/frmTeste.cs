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
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
        }

        private void frmTeste_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Vendas bllVend = new Camadas.BLL.Vendas();
            List<Camadas.MODEL.Vendas> lstVenda = new List<Camadas.MODEL.Vendas>();
            //Camadas.DAL.Vendas bllVend = new Camadas.DAL.Vendas();


            lstVenda = bllVend.Select();
            dgvteste.DataSource = "";
            dgvteste.DataSource = lstVenda;
        }
    }
}
