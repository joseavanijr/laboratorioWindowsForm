using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PlanoDeSaude.Model;

namespace PlanoDeSaude.DAO
{
    public class AtendimentoDAO
    {
        public int Inserir(Atendimento objAtendimento)
        {
            var comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Atendimento (dataAtendimento, status , valorAPagar, pacienteID) VALUES (@dataAtendimento, @status, @valorAPagar, @pacienteID);Select SCOPE_IDENTITY ()";

            comando.Parameters.AddWithValue("@dataAtendimento", objAtendimento.DataAtendimento);
            comando.Parameters.AddWithValue("@status", objAtendimento.Status);
            comando.Parameters.AddWithValue("@valorAPagar", objAtendimento.ValorAPagar);
            comando.Parameters.AddWithValue("@pacienteID", objAtendimento.ObjPaciente.Id);
            Conexao con = new Conexao();
            int x = con.Crud(comando);
            return x;
        }

        public int Apagar(Atendimento objAtendimento)
        {

            var comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE Atendimento WHERE atendimentoId=@atendimentoID";
            comando.Parameters.AddWithValue("@atendimentoID", objAtendimento.Id);

            Conexao con = new Conexao();
            return con.manterCRUDComRetorno(comando);
        }

        public IList<Atendimento> BuscarTodos()
        {
            IList<Atendimento> listaAtendimento = new List<Atendimento>();

            var comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Atendimento";
            Conexao con = new Conexao();
            SqlDataReader dr = con.Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Atendimento objAtendimento = new Atendimento();
                    objAtendimento.Id = (int)dr["atendimentoID"];
                    objAtendimento.DataAtendimento = (DateTime)dr["dataAtendimento"];
                    objAtendimento.Status = (string)dr["status"];
                    //objAtendimento.ValorAPagar = (decimal)dr["valorAPagar"];
                    objAtendimento.ObjPaciente = new PacienteDAO().SelectById((int)dr["pacienteID"]);
                    objAtendimento.ListaExamesDoAtendimento = new ExamesDoAtendimentoDAO().BuscarExamesDoAtendimento(objAtendimento);
                    listaAtendimento.Add(objAtendimento);
                }//fim while
            }//fim if
            else
            {
                listaAtendimento = null;
            }//fim else

            dr.Close();
            return listaAtendimento;
        }

        public IList<Atendimento> BuscarEntreDatas(DateTime inicio, DateTime fim)
        {
            IList<Atendimento> listaAtendimento = new List<Atendimento>();

            var comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Atendimento WHERE dataAtendimento BETWEEN  @dataInicio and @dataFim";
            comando.Parameters.AddWithValue("@dataInicio", inicio);
            comando.Parameters.AddWithValue("@dataFim", fim);

            Conexao con = new Conexao();
            SqlDataReader dr = con.Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Atendimento objAtendimento = new Atendimento();
                    objAtendimento.Id = (int)dr["atendimentoID"];
                    objAtendimento.DataAtendimento = (DateTime)dr["dataAtendimento"];
                    objAtendimento.Status = (string)dr["status"];
                    //objAtendimento.ValorAPagar = (decimal)dr["valorAPagar"];
                    objAtendimento.ObjPaciente = new PacienteDAO().SelectById((int)dr["pacienteID"]);
                    objAtendimento.ListaExamesDoAtendimento = new ExamesDoAtendimentoDAO().BuscarExamesDoAtendimento(objAtendimento);
                    listaAtendimento.Add(objAtendimento);
                }//fim while
            }//fim if
            else
            {
                listaAtendimento = null;
            }//fim else

            dr.Close();
            return listaAtendimento;
        }

        public Atendimento BuscarPorID(int atendimentoId)
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * From Atendimento Where atendimentoID=@id";
            comando.Parameters.AddWithValue("@id", atendimentoId);
            Conexao con = new Conexao();
            SqlDataReader dr = con.Selecionar(comando);
            Atendimento objAtendimento = new Atendimento();
            if (dr.HasRows)
            {
                dr.Read();
                //preenche o objeto
                objAtendimento.Id = (int)dr["atendimentoID"];
                objAtendimento.DataAtendimento = (DateTime)dr["dataAtendimento"];
                objAtendimento.Status = (string)dr["status"];
                //objAtendimento.ValorAPagar = (decimal)dr["valorAPagar"];
                objAtendimento.ObjPaciente = new PacienteDAO().SelectById((int)dr["pacienteID"]);
                objAtendimento.ListaExamesDoAtendimento = new ExamesDoAtendimentoDAO().BuscarExamesDoAtendimento(objAtendimento);
            }
            else
            {
                objAtendimento = null;
            }
            return objAtendimento;

        }
    }
}