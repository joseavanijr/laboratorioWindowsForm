using System.Data;
using PlanoDeSaude.DAO;

namespace PlanoDeSaude.Model
{
    public class Exame
    {

        private string descricao;
        private int id;
        private decimal valor;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public void Save()
        {
            ExameDAO eDAO = new ExameDAO();
            if (Id==0)
            {
                eDAO.Inserir(this);
            }
            else
            {
                eDAO.Alterar(this);
            }
        }
        public DataTable Buscar()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof (int));
            dt.Columns.Add("Descrição", typeof(string));
            dt.Columns.Add("Valor", typeof(string));

            foreach (var item in new ExameDAO().BuscarTodos())
            {
                dt.Rows.Add(item.Id, item.descricao, item.Valor.ToString("C"));
            }
            return dt;
        }
        public Exame Buscar(int id)
        {
            return new ExameDAO().SelecionaPorID(id);
        }
    } //end Exame
}