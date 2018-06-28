using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Camadas.DAL
{
    public class Conexao
    {
        public static string getConexao()
        {
            return "Data Source=DESKTOP-3AJ4III\\SQLEXPRESS;Initial Catalog=ALMIR;Integrated Security=True";
        }

    }
}
