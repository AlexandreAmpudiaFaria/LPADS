using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.Camadas.DAL
{
    public class produtosCarrinho
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.produtosCarrinho> Select()
        {
            List<MODEL.produtosCarrinho> produtosCarrinho = new List<MODEL.produtosCarrinho>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " Select * from produtosCarrinho;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.produtosCarrinho produtoCarrinho = new MODEL.produtosCarrinho();
                    produtoCarrinho.id_produto = Convert.ToInt32(reader["id_produto"].ToString());
                    produtoCarrinho.descricao = reader["descricao"].ToString();
                    produtoCarrinho.status = reader["status"].ToString();
                    produtosCarrinho.Add(produtoCarrinho);
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

            return produtosCarrinho;
        }

   
        public void Insert(int id_produto, string descricao,string status)
        {
            Camadas.MODEL.produtosCarrinho produto = new Camadas.MODEL.produtosCarrinho();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into produtosCarrinho values(@id_produto,@descricao,@status);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_produto", id_produto);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@status", status);
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

        public void Delete(int id_produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from produtosCarrinho where id_produto=@id_produto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_produto", id_produto);

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

        public void DeleteFim()
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from produtosCarrinho ;";
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
