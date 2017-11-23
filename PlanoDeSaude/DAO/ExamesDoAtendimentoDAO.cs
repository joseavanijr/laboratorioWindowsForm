using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PlanoDeSaude.Model;

namespace PlanoDeSaude.DAO
{
    public class ExamesDoAtendimentoDAO
    {
        public void Inserir(ExamesDoAtendimento objItem)
        {

            var comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO ExamesDoAtendimento(dataExame,status,atendimentoID,exameID) VALUES (@dataExame,@status, @atendimentoID, @exameID)";  
            comando.Parameters.AddWithValue("@dataExame", objItem.DataExame);       
            comando.Parameters.AddWithValue("@status", objItem.Status);
            comando.Parameters.AddWithValue("@atendimentoID", objItem.ObjAtendimento.Id);
            comando.Parameters.AddWithValue("@exameID", objItem.ObjExame.Id);
            Conexao con = new Conexao();
            con.Crud(comando);

        }
        public void Deletar(ExamesDoAtendimento objItem)
        {

            var comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE ExamesDoAtendimento WHERE examesDoAtendimentoID=@examesDoAtendimentoID";
            comando.Parameters.AddWithValue("@examesDoAtendimentoID", objItem.Id);

            Conexao con = new Conexao();
            con.Crud(comando);

        }

        public IList<ExamesDoAtendimento> BuscarExamesDoAtendimento()
        {
            IList<ExamesDoAtendimento> listaExamesDoAtendimentos = new List<ExamesDoAtendimento>();

            var comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM ExamesDoAtendimento";
            Conexao con = new Conexao();
            SqlDataReader dr = con.Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Atendimento objAtendimento = new AtendimentoDAO().BuscarPorID((int) dr["atendimentoID"]);
                    ExamesDoAtendimento objExamesDoAtendimento = new ExamesDoAtendimento(objAtendimento);
                    objExamesDoAtendimento.Id = (int)dr["examesDoAtendimentoID"];
                    objExamesDoAtendimento.DataExame = (DateTime)dr["dataExame"];
                    objExamesDoAtendimento.Status = (string)dr["status"];
                    objExamesDoAtendimento.ObjAtendimento = objAtendimento;
                    objExamesDoAtendimento.ObjExame = new ExameDAO().SelecionaPorID((int)dr["exameID"]);    
                    listaExamesDoAtendimentos.Add(objExamesDoAtendimento);
                }//fim while
            }//fim if
            else
            {
                listaExamesDoAtendimentos = null;
            }//fim else

            dr.Close();
            return listaExamesDoAtendimentos;
        }

        public IList<ExamesDoAtendimento> BuscarExamesDoAtendimento(Atendimento objAtendimento)
        {
            IList<ExamesDoAtendimento> listaExamesDoAtendimentos = new List<ExamesDoAtendimento>();

            var comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM ExamesDoAtendimento  Where atendimentoID=@IdAtendimento";
            comando.Parameters.AddWithValue("@IdAtendimento", objAtendimento.Id);
            Conexao con = new Conexao();
            SqlDataReader dr = con.Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ExamesDoAtendimento objExamesDoAtendimento = new ExamesDoAtendimento(objAtendimento);
                    objExamesDoAtendimento.Id = (int)dr["examesDoAtendimentoID"];
                    objExamesDoAtendimento.DataExame = (DateTime)dr["dataExame"];
                    objExamesDoAtendimento.Status = (string)dr["status"];
                    objExamesDoAtendimento.ObjAtendimento = objAtendimento;
                    objExamesDoAtendimento.ObjExame = new ExameDAO().SelecionaPorID((int)dr["exameID"]);
                    listaExamesDoAtendimentos.Add(objExamesDoAtendimento);
                }//fim while
            }//fim if
            else
            {
                listaExamesDoAtendimentos = null;
            }//fim else

            dr.Close();
            return listaExamesDoAtendimentos;
        }

        public ExamesDoAtendimento BuscaPorAtendimento(Atendimento objAtendimento)
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * From ExamesDoAtendimento Where examesDoAtendimentoID=@id";
            comando.Parameters.AddWithValue("@id", objAtendimento.Id);
            Conexao con = new Conexao();
            SqlDataReader dr = con.Selecionar(comando);
            ExamesDoAtendimento objExamesDoAtendimento = new ExamesDoAtendimento(objAtendimento);
            if (dr.HasRows)
            {
                dr.Read();

                //preenche o objeto
                objExamesDoAtendimento.Id = (int)dr["examesDoAtendimentoID"];
                objExamesDoAtendimento.DataExame = (DateTime)dr["dataExame"];
                objExamesDoAtendimento.Status = (string)dr["status"];
                objExamesDoAtendimento.ObjAtendimento = objAtendimento;
                objExamesDoAtendimento.ObjExame = new ExameDAO().SelecionaPorID((int)dr["exameID"]);

            }
            else
            {
                objExamesDoAtendimento = null;
            }
            return objExamesDoAtendimento;

        }

    }
}