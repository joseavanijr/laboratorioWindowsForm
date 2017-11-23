using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanoDeSaude.DAO;

namespace PlanoDeSaude.Model
{
    public class Paciente
    {
        #region ATRIBUTOS
        private string nome;
        private DateTime dtNascimento;
        private PlanoSaude objPlanoDeSaude = new PlanoSaude();
        private int tipoConveniado;
        private int id;
        #endregion

        #region PROPRIEDADES
        public PlanoSaude ObjPlanoDeSaude
        {
            get { return objPlanoDeSaude; }
            set { objPlanoDeSaude = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime DataNascimento
        {
            get { return dtNascimento; }
            set { dtNascimento = value; }
        }
        public int TipoConveniado
        {
            get { return tipoConveniado; }
            set { tipoConveniado = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion

        #region MÉTODOS
        public void Save()
        {
            PacienteDAO pDAO = new PacienteDAO();
            if (Id == 0)
            {
                pDAO.Insert(this);
            }
            else
            {
                pDAO.Update(this);
            }
        }
        public DataTable Buscar(string nome)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Data de Nascimento", typeof(DateTime));
            dt.Columns.Add("Plano de Saúde", typeof(string));

            foreach (var item in new PacienteDAO().SelectForName(nome))
            {
                dt.Rows.Add(item.id, item.Nome, item.dtNascimento, item.ObjPlanoDeSaude.Nome);
            }
            return dt;
        }
        public Paciente Buscar(int id)
        {
            return new PacienteDAO().SelectForId(id);
        }

        public DataTable Buscar()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Data de Nascimento", typeof(DateTime));
            dt.Columns.Add("Plano de Saúde", typeof(string));

            foreach (var item in new PacienteDAO().SelectAll())
            {
                dt.Rows.Add(item.id, item.Nome, item.dtNascimento, item.ObjPlanoDeSaude.Nome);
            }
            return dt;
        }
        #endregion
    }
}
