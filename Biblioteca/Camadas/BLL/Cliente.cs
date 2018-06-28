using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.BLL
{
    public class Cliente
    {
        public List<MODEL.Cliente> Select()
        {
            Camadas.DAL.Cliente bllCli = new Camadas.DAL.Cliente();
            //escrever regras de negocios
            return bllCli.Select();
        }

        public List<MODEL.Cliente> SelectByNome(string nome)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            //escrever regras de negocios
            return dalCli.SelectByNome(nome);
        }

        public void Delete(int id_cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            //escrever regras de negocios
            dalCli.Delete(id_cliente);
        }

        public void Insert(MODEL.Cliente cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            //escrever regras de negocios
            dalCli.Insert(cliente);
        }

        public void Update(MODEL.Cliente cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            //escrever regras de negocios
            dalCli.Update(cliente);
        }
    }
}
