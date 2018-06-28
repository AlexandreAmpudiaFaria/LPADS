using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.MODEL
{
    public class Vendas
    {
        public int id_venda;
        public int id_produto;
        public string descricao;
        public string cliente;

        public int Id_venda { get => id_venda; set => id_venda = value; }
        public int Id_produto { get => id_produto; set => id_produto = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Cliente { get => cliente; set => cliente = value; }
    }
}
