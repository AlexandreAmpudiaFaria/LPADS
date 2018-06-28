using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.MODEL
{
    public class cabecalhoCarrinho
    {
        public int id_cliente;
        public string nome_cli;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nome_cli { get => nome_cli; set => nome_cli = value; }
    }
}
