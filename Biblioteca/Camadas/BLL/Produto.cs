using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.BLL
{
    public class Produto
    {
        public List<MODEL.Produto> Select()
        {
            DAL.Produto dalProd = new DAL.Produto();
            //escrever regras de negocios
            return dalProd.Select();
        }

        public List<MODEL.Produto> SelectByStatus(string status)
        {
            DAL.Produto dalProd = new DAL.Produto();
            
                return dalProd.SelectByStatus(status);
            
        }

        public void Insert(MODEL.Produto produto)
        {
            DAL.Produto dalProd = new DAL.Produto();

             dalProd.Insert(produto);

        }

        public void Update(MODEL.Produto produto)
        {
            DAL.Produto dalProd = new DAL.Produto();

            dalProd.Update(produto);

        }

        public void UpdateVenda(int id_produto, string status)
        {
            DAL.Produto dalProd = new DAL.Produto();
            status = "E";
            dalProd.UpdateVenda(id_produto,status);

        }

        public void UpdateByStatus( int id_produto, string status)
        {
            DAL.Produto dalProd = new DAL.Produto();
            if (status.Equals("L"))
            {
                status = "E";
                dalProd.UpdateByStatus(status, id_produto);
            } else if (status.Equals("E"))
            {
                status = "L";
                dalProd.UpdateByStatus(status, id_produto);

            }
            //dalProd.UpdateStatus(status);

        }

        public void Delete(int id_produto)
        {
            DAL.Produto dalProd = new DAL.Produto();

            dalProd.Delete(id_produto);

        }

        public void UpdateByStatus(string status,int id_produto)
        {
            DAL.Produto dalProd = new DAL.Produto();

            dalProd.UpdateByStatus(status,id_produto);

        }

        public void UpdateByQuant(int id_produto, int quantidade, int sub)
        {
            Camadas.MODEL.Produto produto = new MODEL.Produto();
            DAL.Produto dalProd = new DAL.Produto();
            
            //dalProd.UpdateByQuant(id_produto, quantidade, sub);

        }
    }
}
