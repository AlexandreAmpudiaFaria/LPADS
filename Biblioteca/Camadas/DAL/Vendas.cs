using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.Camadas.DAL
{
    public class Vendas
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Vendas> Select()
        {
            List<MODEL.Vendas>  vendas = new List<MODEL.Vendas>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " Select * from Vendas ;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Camadas.MODEL.Vendas vendasEfetuadas = new Camadas.MODEL.Vendas();
                    vendasEfetuadas.id_venda = Convert.ToInt32(reader["id_venda"].ToString());
                    vendasEfetuadas.id_produto = Convert.ToInt32(reader["id_produto"].ToString());
                    vendasEfetuadas.descricao = reader["descricao"].ToString();
                    vendasEfetuadas.cliente = reader["cliente"].ToString();

                    vendas.Add(vendasEfetuadas);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na seleção de produtos do carrinho");

            }
            finally
            {
                conexao.Close();
            }

            return vendas;
        }

        public void Insert(int id_produto, string descricao, string cliente)
        {
            Camadas.MODEL.Vendas vendas = new Camadas.MODEL.Vendas();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Vendas values(@id_produto,@descricao,@cliente);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_produto", id_produto);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@cliente", cliente);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("deu erro na inserção de produtos no carrinho");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
