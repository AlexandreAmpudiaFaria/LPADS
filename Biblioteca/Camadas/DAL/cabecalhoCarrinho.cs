using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace Biblioteca.Camadas.DAL
{
    public class cabecalhoCarrinho
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.cabecalhoCarrinho> Select()
        {
            List<MODEL.cabecalhoCarrinho> clientesCarrinho = new List<MODEL.cabecalhoCarrinho>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " Select * from cabecalhoCarrinho;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.cabecalhoCarrinho cabCarrinho = new MODEL.cabecalhoCarrinho();
                    cabCarrinho.id_cliente = Convert.ToInt32(reader["id_cliente"].ToString());
                    cabCarrinho.nome_cli = reader["nome_cli"].ToString();
                    clientesCarrinho.Add(cabCarrinho);
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

            return clientesCarrinho;
        }

        public void Insert(int id_cliente, string nome_cli)
        {
            Camadas.MODEL.cabecalhoCarrinho cabecalho = new Camadas.MODEL.cabecalhoCarrinho();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into cabecalhoCarrinho values(@id_cliente,@nome_cli);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
            cmd.Parameters.AddWithValue("@nome_cli", nome_cli);
            

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("deu erro na inserção de cliente no carrinho");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void DeleteFim()
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from cabecalhoCarrinho ;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            //cmd.Parameters.AddWithValue("@id_produto", id_produto);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("deu erro na remoção de produtos");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
