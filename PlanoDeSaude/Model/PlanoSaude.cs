using System.Collections.Generic;
using PlanoDeSaude.DAO;

namespace PlanoDeSaude.Model
{
    public class PlanoSaude
    {

        private int id;
        private string nome;


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public IList<PlanoSaude> FindAll()
        {
            return new PlanoSaudeDAO().Selecionar();
        }
    }
}
