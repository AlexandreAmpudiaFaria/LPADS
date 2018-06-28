using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.Camadas.DAL
{
    public class Produto
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Produto> Select()
        {
            List<MODEL.Produto> produtos = new List<MODEL.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " Select * from Produto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Produto produto = new MODEL.Produto();
                    produto.id_produto = Convert.ToInt32(reader["id_produto"].ToString());
                    produto.descricao = reader["descricao"].ToString();
                    produto.status = reader["status"].ToString();
                    //produto.quantidade = Convert.ToInt32(reader["quantidade"].ToString());
                    produtos.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na seleção de produtos");
            }
            finally
            {
                conexao.Close();
            }

            return produtos;
        }

        public List<MODEL.Produto> SelectByStatus(string status)
        {
            List<MODEL.Produto> produtos = new List<MODEL.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " Select * from Produto where (status like @status);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@status", status);
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Produto produto = new MODEL.Produto();
                    produto.id_produto = Convert.ToInt32(reader["id_produto"].ToString());
                    produto.descricao = reader["descricao"].ToString();
                    produto.status = reader["status"].ToString();
                    produto.quantidade = Convert.ToInt32(reader["quantidade"].ToString());
                    produtos.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na seleção de produtos locados");
            }
            finally
            {
                conexao.Close();
            }

            return produtos;
        }

        public void Insert(MODEL.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Produto values(@descricao,@status,@quantidade);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", produto.descricao);
            cmd.Parameters.AddWithValue("@status", produto.status);
            cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("deu erro na inserção de produtos");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Produto set descricao=@descricao, status=@status, quantidade=@quantidade ";
            sql += " where id_produto=@id_produto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_produto", produto.id_produto);
            cmd.Parameters.AddWithValue("@descricao", produto.descricao);
            cmd.Parameters.AddWithValue("@status", produto.status);
            //cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("deu erro na inserção de produtos");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void UpdateVenda(int id_produto,string status)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Produto set status=@status ";
            sql += " where id_produto=@id_produto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_produto", id_produto);
            //cmd.Parameters.AddWithValue("@descricao", produto.descricao);
            cmd.Parameters.AddWithValue("@status", status);
            //cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("deu erro na inserção de produtos");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void UpdateByStatus(string status, int id_produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Produto set status=@status where id_produto=@id_produto;";
            
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_produto", id_produto);
            //cmd.Parameters.AddWithValue("@descricao", produto.descricao);
            cmd.Parameters.AddWithValue("@status", status);
            //cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("deu erro na inserção de produtos");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void UpdateByQuant(int id_produto ,int quantidade)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Produto set quantidade=@quantidade where id_produto=@id_produto;";

            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_produto", id_produto);
            //cmd.Parameters.AddWithValue("@descricao", produto.descricao);
            //cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("deu erro na inserção de produtos");
            }
            finally
            {
                conexao.Close();
            }
        }


        public void Delete (int id_produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Produto where id_produto=@id_produto;";
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

    }
}
