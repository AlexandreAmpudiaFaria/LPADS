using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.BLL
{
    public class cabecalhoCarrinho
    {
        public void Insert(int id_cliente, string nome_cli)
        {
            DAL.cabecalhoCarrinho dalProd = new DAL.cabecalhoCarrinho();

            dalProd.Insert(id_cliente, nome_cli);

        }

        public List<MODEL.cabecalhoCarrinho> Select()
        {
            DAL.cabecalhoCarrinho dalCab = new DAL.cabecalhoCarrinho();
            //escrever regras de negocios
            return dalCab.Select();
        }

        public void DeleteFim()
        {
            DAL.cabecalhoCarrinho dalProd = new DAL.cabecalhoCarrinho();

            dalProd.DeleteFim();

        }
    }
}
