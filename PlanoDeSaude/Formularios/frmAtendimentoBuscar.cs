using System;
using System.Data;
using System.Windows.Forms;
using PlanoDeSaude.DAO;
using PlanoDeSaude.Model;

namespace PlanoDeSaude.Formularios
{
    public partial class frmAtendimentoBuscar : Form
    {

        private Atendimento ObjAtendimento = new Atendimento();
        public frmAtendimentoBuscar()
        {
            InitializeComponent();
        }

        #region MÉTODOS

      

        public void CarregaGridExamesDoAtendimento()
        {
            gvListaDeExames.DataSource = ObjAtendimento.FormatarParaExibir(new AtendimentoDAO().BuscarTodos());
        }

       #endregion

       

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }


        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            Atendimento a = new Atendimento();

            gvListaDeExames.DataSource = a.FormatarParaExibir(a.Buscar());
        }

        private void btnBuscarAtendimento_Click(object sender, EventArgs e)
        {
            Atendimento a = new Atendimento();

            gvListaDeExames.DataSource = a.FormatarParaExibir(a.Buscar(Convert.ToDateTime(dtpDataInicio.Value), Convert.ToDateTime(dtpDataFim.Value)));
        }

        private void gvListaDeExames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(gvListaDeExames.CurrentRow.Cells["Id"].Value);
            Atendimento a = new Atendimento();
            a = a.Buscar(id);

            frmAtendimentoAlterar formAlterar = new frmAtendimentoAlterar(a);
            formAlterar.Show();
        }
    }
}
