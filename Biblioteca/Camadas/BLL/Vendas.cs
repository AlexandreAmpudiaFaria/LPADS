using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.BLL
{
    public class Vendas
    {
        public void Insert(int id_produto, string descricao, string cliente)
        {
            DAL.Vendas dalVenda = new DAL.Vendas();
            dalVenda.Insert(id_produto, descricao, cliente);


        }

        public List<MODEL.Vendas> Select()
        {
            DAL.Vendas dalVenda = new DAL.Vendas();
            //escrever regras de negocios
            return dalVenda.Select();
        }
    }
}
