using System;
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
    } //end ExamesDoAtendimento
}