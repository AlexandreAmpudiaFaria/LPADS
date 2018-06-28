using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.MODEL
{
    public class Produto
    {
        public int id_produto;
        public string descricao;
        public string status;
        public int quantidade;

        public int Id_produto { get => id_produto; set => id_produto = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Status { get => status; set => status = value; }
        //public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}
