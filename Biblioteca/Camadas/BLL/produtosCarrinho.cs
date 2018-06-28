using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.BLL
{
    public class produtosCarrinho
    {
        public void Insert(int id_produto, string descricao,string status)
        {
            DAL.produtosCarrinho dalProd = new DAL.produtosCarrinho();
            dalProd.Insert(id_produto, descricao,status);
            

        }

        public void Delete(int id_produto)
        {
            DAL.produtosCarrinho dalProd = new DAL.produtosCarrinho();

            dalProd.Delete(id_produto);

        }

        public void DeleteFim()
        {
            DAL.produtosCarrinho dalProd = new DAL.produtosCarrinho();

            dalProd.DeleteFim();

        }

        public List<MODEL.produtosCarrinho> Select()
        {
            DAL.produtosCarrinho dalProd = new DAL.produtosCarrinho();
            //escrever regras de negocios
            return dalProd.Select();
        }
    }
}
