using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.Camadas.DAL
{
    public class Cliente
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Cliente> Select()
        {
            List<MODEL.Cliente> clientes = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " Select * from Cliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    cliente.id_cliente = Convert.ToInt32(reader["id_cliente"].ToString());
                    cliente.nome = reader["nome"].ToString();
                    clientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na seleção de clientes");
            }
            finally
            {
                conexao.Close();
            }

            return clientes;
        }

        public List<MODEL.Cliente> SelectByNome(string nome)
        {
            List<MODEL.Cliente> clientes = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " Select * from Cliente where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    cliente.id_cliente = Convert.ToInt32(reader["id_cliente"].ToString());
                    cliente.nome = reader["nome"].ToString();
                    clientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na seleção de clientes por nome");
            }
            finally
            {
                conexao.Close();
            }

            return clientes;
        }

        public void Insert(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Cliente values(@nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("deu erro na inserção de clientes");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Cliente set nome=@nome where id_cliente=@id_cliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_cliente", cliente.id_cliente);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("deu erro na edição de clientes");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int id_cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Cliente where id_cliente=@id_cliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_cliente", id_cliente);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("deu erro na remoção de clientes");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
