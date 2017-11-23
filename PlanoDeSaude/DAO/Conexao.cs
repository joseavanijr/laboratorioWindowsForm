using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PlanoDeSaude.DAO
{
    public class Conexao
    {
        public int Crud(SqlCommand comando)
        {
            SqlConnection con = Conectar();
            comando.Connection = con;
           //Convert.ToInt32(comando.ExecuteNonQuery());
            int id = Convert.ToInt32(comando.ExecuteScalar());
            con.Close();
            return id;
        }

        public SqlDataReader Selecionar(SqlCommand Comando)
        {
            SqlConnection con = Conectar();
            Comando.Connection = con;
            SqlDataReader Dr = Comando.ExecuteReader(CommandBehavior.CloseConnection);
            return Dr;
        }

        public SqlConnection Conectar()
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["ConAtendimentoHospitalar"].ConnectionString;
            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();
            return conexao;
        }

        public int manterCRUDComRetorno(SqlCommand comando)
        {
            SqlTransaction transaction = null;
            SqlConnection conexao = Conectar();
            try
            {

                bool inserir = false;
                int retorno = 0;

                if (comando.CommandText.Contains("INSERT INTO"))
                {
                    inserir = true;
                } 
                comando.Connection = conexao;
                if (inserir)
                {
                    transaction = conexao.BeginTransaction(IsolationLevel.ReadCommitted);
                    comando.Transaction = transaction;
                    comando.CommandText = comando.CommandText + ";SELECT CAST(scope_identity() AS int);";
                    retorno = Convert.ToInt32(comando.ExecuteScalar());
                    transaction.Commit();
                }
                else
                {
                    retorno = comando.ExecuteNonQuery();
                }
                conexao.Close();
                return retorno;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                }
                catch { }
                throw new ArgumentException(e.Message);
            }
            finally
            {
                if (conexao.State == System.Data.ConnectionState.Open)
                    conexao.Close();
            }//fim-try

        }

        internal int CrudRetornaId(SqlCommand comando)
        {
            throw new NotImplementedException();
        }
    }
}
