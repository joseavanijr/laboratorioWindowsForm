using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;
using PlanoDeSaude.DAO;

namespace PlanoDeSaude.Model
{
    public class Atendimento
    {

        private DateTime dataAtendimento;
        private int id;
        private string status;
        private decimal valorAPagar;
        private IList<ExamesDoAtendimento> listaExamesDoAtendimento = new List<ExamesDoAtendimento>();
        private Paciente objPaciente = new Paciente();

        public DateTime DataAtendimento
        {
            get { return dataAtendimento; }
            set { dataAtendimento = value; }
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
        public decimal ValorAPagar
        {
            get
            {
                return listaExamesDoAtendimento.Sum(x => x.ObjExame.Valor);
            }
        }

        public Paciente ObjPaciente
        {
            get { return objPaciente; }
            set { objPaciente = value; }
        }

        public void AddItem(Exame exame, string status, DateTime data)
        {
            ExamesDoAtendimento item = new ExamesDoAtendimento(this);
            item.DataExame = data;
            item.ObjExame = exame;
            item.Status = status;

            ListaExamesDoAtendimento.Add(item);
        }

        public void RemoveItem(int index)
        {
            ListaExamesDoAtendimento.RemoveAt(index);
        }

        public IList<ExamesDoAtendimento> ListaExamesDoAtendimento
        {
            get { return listaExamesDoAtendimento; }
            set { listaExamesDoAtendimento = value; }
        }


        public void Save()
        {

            Validar();
            AtendimentoDAO aDAO = new AtendimentoDAO();
            if (Id == 0)
            {
                using (TransactionScope scopo = new TransactionScope())
                {
                    valorAPagar = Convert.ToDecimal(listaExamesDoAtendimento.Sum(x => x.ObjExame.Valor));
                    this.Id = aDAO.Inserir(this);

                    foreach (var item in ListaExamesDoAtendimento)
                    {
                        item.Save();
                    }
                    scopo.Complete();
                }
            }

        }

        public void Remove()
        {
            using (TransactionScope scopo = new TransactionScope())
            {
                foreach (var item in listaExamesDoAtendimento)
                {
                    item.Remove();
                }

                new AtendimentoDAO().Apagar(this);

                scopo.Complete();
            }

        }

        public IList<Atendimento> Buscar(DateTime inicio, DateTime fim)
        {
            return new AtendimentoDAO().BuscarEntreDatas(inicio, fim);
        }

        public IList<Atendimento> Buscar()
        {
            return new AtendimentoDAO().BuscarTodos();
        }

        public Atendimento Buscar(int id)
        {
            return new AtendimentoDAO().BuscarPorID(id);
        }

        public DataTable FormatarParaExibir(IList<Atendimento> listaAtendimento)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Código do Atendimento", typeof(int));
            dt.Columns.Add("Paciente", typeof(string));
            dt.Columns.Add("Data do Atendimento", typeof(DateTime));
            dt.Columns.Add("Valor à Pagar", typeof(decimal));
            dt.Columns.Add("Status", typeof(string));

            if (listaAtendimento != null)
            {
                DataRow dr;
                foreach (var item in listaAtendimento)
                {
                    dt.Rows.Add(item.Id, item.ObjPaciente.Nome, item.DataAtendimento, item.ValorAPagar, item.Status);
                }
            }
            else
            {
                dt = null;
            }
            return dt;
        }

        public void Validar()
        {
            if (listaExamesDoAtendimento.Count == 0)
                throw new Exception("Não há exames nesse atendimento");
            if (objPaciente.Id == 0)
                throw new Exception("Não há paciente nesse atendimento");
            if (dataAtendimento.Date < DateTime.Now.Date)
                throw new Exception("A data do atendimento é inferior ao dia de hoje");

        }
    } //end Atendimento
}