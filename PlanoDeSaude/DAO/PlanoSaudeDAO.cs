using PlanoDeSaude.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace PlanoDeSaude.DAO
{
    public class PlanoSaudeDAO
    {

        public void Insert(PlanoSaude p)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO PlanoDeSaude (descricao) VALUES (@descricao)";
            comando.Parameters.AddWithValue("@descricao", p.Nome);
            
            Conexao con = new Conexao();
            con.Crud(comando);
        }
        public void Update (PlanoSaude plano)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE PlanoDeSaude SET descricao=@descricao where planoDeSaudeId=@planoid";

            comando.Parameters.AddWithValue("@descricao", plano.Nome);
            comando.Parameters.AddWithValue("@planoId", plano.Id);

            Conexao con = new Conexao();
            con.Crud(comando);

        }
        public void Delete(PlanoSaude plano)
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM PlanoDeSaude WHERE planoDeSaudeId=@planoId";

            comando.Parameters.AddWithValue("@planoId", plano.Id);

            Conexao con = new Conexao();
            con.Crud(comando);
        }       
        /// <summary>
        /// Busca o plano de saúde desejado
        /// </summary>
        /// <param name="id">Chave que identifica o plano que se deseja buscar</param>
        /// <returns>Retorna um Plano de saúde</returns>
        public PlanoSaude Selecionar(int id)
        {

            PlanoSaude plano = new PlanoSaude();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM PlanoDeSaude WHERE planoDeSaudeId=@planoId";

            comando.Parameters.AddWithValue("@planoId", id);

            //retorno
            Conexao con = new Conexao();
            SqlDataReader dr = con.Selecionar(comando);


            if (dr.HasRows)
            {
                dr.Read();
                plano.Id = Convert.ToInt32(dr["planoDeSaudeId"]);
                plano.Nome = dr["descricao"].ToString();
            }
            else
            {
                plano = null;
            }

            dr.Close();
            return plano;
        }
        /// <summary>
        /// Busca todos os planos de saúde que contenha o nome informado
        /// </summary>
        /// <param name="nome">Parte do nome  do plano</param>
        /// <returns>Retorna uma lista de planos de saúde que contenham o nome informado</returns>
        public IList<PlanoSaude> Selecionar(string nome)
        {
            IList<PlanoSaude> listaPlanos = new List<PlanoSaude>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM PlanoDeSaude WHERE descricao LIKE @descricao";

            comando.Parameters.AddWithValue("@descricao", "%" + nome + "%");

            Conexao con = new Conexao();
            SqlDataReader dr = con.Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    PlanoSaude p = new PlanoSaude();
                    p.Id = (int)dr["planoDeSaudeId"];
                    p.Nome = (string)dr["descricao"];

                    listaPlanos.Add(p);
                }
            }
            else
            {
                listaPlanos = null;
            }

            dr.Close();
            return listaPlanos;
        }
        /// <summary>
        /// Busca todos os planos de saúde
        /// </summary>
        /// <returns>Retorna uma lista de planos de saúde com todos os planos existentes na base de dados</returns>
        public IList<PlanoSaude> Selecionar()
        {
            IList<PlanoSaude> listaPlanos = new List<PlanoSaude>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM PlanoDeSaude";           

            Conexao con = new Conexao();
            SqlDataReader dr = con.Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    PlanoSaude p = new PlanoSaude();
                    p.Id = (int)dr["planoDeSaudeId"];
                    p.Nome = (string)dr["descricao"];

                    listaPlanos.Add(p);
                }
            }
            else
            {
                listaPlanos = null;
            }

            dr.Close();
            return listaPlanos;
        }

    }
}
