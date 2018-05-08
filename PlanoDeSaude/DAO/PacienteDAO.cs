using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using PlanoDeSaude.Model;

namespace PlanoDeSaude.DAO
{
    public class PacienteDAO  
    {
        public void Insert(Paciente p)
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Paciente (nome, dtnascimento, tipoConveniado, planoDeSaudeId) VALUES (@nome, @dtnascimento, @tipoConveniado, @planoid)";

            comando.Parameters.AddWithValue("@nome", p.Nome);
            comando.Parameters.AddWithValue("@dtnascimento", p.DataNascimento);
            comando.Parameters.AddWithValue("@tipoConveniado", p.TipoConveniado);
            comando.Parameters.AddWithValue("@planoid", p.ObjPlanoDeSaude.Id);

            Conexao con = new Conexao();
            con.Crud(comando);
        }
        public void Update(Paciente pac)
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Paciente SET nome=@nome, tipoConveniado=@tipoConveniado, planoDeSaudeId=@planoid WHERE pacienteId=@pacienteId";

            comando.Parameters.AddWithValue("@nome", pac.Nome);
            comando.Parameters.AddWithValue("@dtnascimento", pac.DataNascimento);
            comando.Parameters.AddWithValue("@tipoConveniado", pac.TipoConveniado);
            comando.Parameters.AddWithValue("@planoId", pac.ObjPlanoDeSaude.Id);
            comando.Parameters.AddWithValue("@pacienteId", pac.Id);

            Conexao con = new Conexao();
            con.Crud(comando);

        }
        public void Delete(Paciente pac)
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE  Paciente WHERE pacienteId=@pacienteId";

            comando.Parameters.AddWithValue("@pacienteId", pac.Id);

            Conexao con = new Conexao();
            con.Crud(comando);

        }
        public Paciente SelectForId(int id)
        {
            Paciente p = new Paciente();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Paciente WHERE pacienteId=@id";
            comando.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = new Conexao().Selecionar(comando);

            if (dr.HasRows)
            {
                dr.Read();

                p.Id = (int) dr["pacienteId"];
                p.DataNascimento = Convert.ToDateTime(dr["dtNascimento"]);
                p.TipoConveniado = (int) dr["tipoConveniado"];
                p.Nome = dr["nome"].ToString();
                p.ObjPlanoDeSaude = new PlanoSaudeDAO().Selecionar((int)dr["planoDeSaudeId"]);
            }
            else
            {
                p = null;
            }
            dr.Close();
            return p;
        }
        public IList<Paciente> SelectForName(string nome)
        {
           
            IList<Paciente> lista = new List<Paciente>();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Paciente WHERE nome like @nome";
            comando.Parameters.AddWithValue("@nome", "%"+nome+"%");

            SqlDataReader dr = new Conexao().Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Paciente p = new Paciente();
                    p.Id = (int) dr["pacienteId"];
                    p.DataNascimento = Convert.ToDateTime(dr["dtNascimento"]);
                    p.TipoConveniado = (int) dr["tipoConveniado"];
                    p.Nome = dr["nome"].ToString();
                    p.ObjPlanoDeSaude = new PlanoSaudeDAO().Selecionar((int) dr["planoDeSaudeId"]);
                    lista.Add(p);
                }
            }
            else
            {
                lista = null;
            }

            dr.Close();
            return lista;
        }
        public IList<Paciente> SelectAll()
        {
            IList<Paciente> lista = new List<Paciente>();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Paciente";

            SqlDataReader dr = new Conexao().Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Paciente p = new Paciente
                    {
                        Id = (int) dr["pacienteId"],
                        DataNascimento = Convert.ToDateTime(dr["dtNascimento"]),
                        TipoConveniado = (int) dr["tipoConveniado"],
                        Nome = dr["nome"].ToString(),
                        ObjPlanoDeSaude = new PlanoSaudeDAO().Selecionar((int) dr["planoDeSaudeId"])
                    };
                    lista.Add(p);
                }
            }
            else
            {
                lista = null;
            }

            dr.Close();
            return lista;
        }
    }
}
