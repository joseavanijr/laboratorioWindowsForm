using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PlanoDeSaude.Model;

namespace PlanoDeSaude.DAO
{
    public class ExameDAO
    {
        public void Inserir(Exame objItem)
        {

            var comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Exame (descricao,valor) VALUES (@descricao, @valor)";

            comando.Parameters.AddWithValue("@descricao", objItem.Descricao);
            comando.Parameters.AddWithValue("@valor", objItem.Valor);
            Conexao con = new Conexao();
            con.Crud(comando);

        }
        public void Alterar(Exame objItem)
        {

            var comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Exame SET descricao=@descricao,valor=@valor WHERE exameid=@exameid";

            comando.Parameters.AddWithValue("@descricao", objItem.Descricao);
            comando.Parameters.AddWithValue("@valor", objItem.Valor);
            comando.Parameters.AddWithValue("@id", objItem.Id);
            Conexao con = new Conexao();
            con.Crud(comando);
        }
        public void Excluir(Exame objItem)
        {

            var comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE Exame WHERE exameid=@exameid";

            comando.Parameters.AddWithValue("@id", objItem.Id);
            Conexao con = new Conexao();
            con.Crud(comando);

        }
        public Exame SelecionaPorID(int exameId)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * From Exame Where exameID=@id";
            comando.Parameters.AddWithValue("@id", exameId);
            Conexao con = new Conexao();
            SqlDataReader dr = con.Selecionar(comando);
            Exame objExame = new Exame();
            if (dr.HasRows)
            {
                dr.Read();   
                //preenche o objeto
                objExame.Id = (int)dr["exameID"];
                objExame.Descricao = (string)dr["descricao"];
                objExame.Valor = (decimal)dr["valor"];
            }
            else
            {
                objExame = null;
            }
            return objExame;

        }
        public IList<Exame> BuscarTodos()
        {
            IList<Exame> exames = new List<Exame>();

            var comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Exame";
            Conexao con = new Conexao();
            SqlDataReader dr = con.Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Exame objExame = new Exame();
                    objExame.Id = (int)dr["exameID"];
                    objExame.Descricao = (string)dr["descricao"];
                    objExame.Valor = (decimal)dr["valor"];  
                    exames.Add(objExame);
                }//fim while
            }//fim if
            else
            {
                exames = null;
            }//fim else
            return exames;
        }
    }
}