using System;
using System.Collections.Generic;
using System.Data;
using PlanoDeSaude.DAO;

namespace PlanoDeSaude.Model
{

    public class ExamesDoAtendimento
    {
        private DateTime dataExame;
        private int id;
        private string status;
        private Exame objExame;
        private Atendimento objAtendimento;

        public ExamesDoAtendimento(Atendimento atendimento)
        {
            objExame = new Exame();
            objAtendimento = atendimento;
        }
        public DateTime DataExame
        {
            get { return dataExame; }
            set { dataExame = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public Atendimento ObjAtendimento
        {
            get { return objAtendimento; }
            set { objAtendimento = value; }
        }
        public Exame ObjExame
        {
            get { return objExame; }
            set { objExame = value; }
        }

        public void Save()
        {
            new ExamesDoAtendimentoDAO().Inserir(this);
        }
        public void Remove()
        {
            new ExamesDoAtendimentoDAO().Deletar(this);
        }
         public static DataTable FormatarLista(IList<ExamesDoAtendimento> ListaExamesDoAtendimento)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Código do Exame", typeof(int));
            dt.Columns.Add("Descrição", typeof(string));
            dt.Columns.Add("Data", typeof(DateTime));
            dt.Columns.Add("Valor do Exame", typeof(decimal));

            if (ListaExamesDoAtendimento != null)
            {
                DataRow dr;
                foreach (var item in ListaExamesDoAtendimento)
                {
                    dt.Rows.Add(item.ObjExame.Id, item.ObjExame.Descricao, item.DataExame, item.ObjExame.Valor);
                }
            }
            else
            {
                dt = null;
            }
            return dt;
        }

        public static void RemoveExamesDoAtendimento(Atendimento atendimento)
        {
            new ExamesDoAtendimentoDAO().Deletar(atendimento);
        }
    } //end ExamesDoAtendimento
}