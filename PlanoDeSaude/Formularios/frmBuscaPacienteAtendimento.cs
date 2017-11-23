using System;
using System.Windows.Forms;
using PlanoDeSaude.DAO;
using PlanoDeSaude.Model;

namespace PlanoDeSaude.Formularios
{
    public partial class frmBuscaPacienteAtendimento : Form
    {
        private frmAtendimento frmAtendimento = null;

        public frmBuscaPacienteAtendimento(frmAtendimento principalAtendimento)
        {
            InitializeComponent();
            this.frmAtendimento = principalAtendimento;
            CarrearPacientes();
        }

        private void gvPacienteDoAtendimento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(gvPacienteDoAtendimento.CurrentRow.Cells["Id"].Value);

            frmAtendimento.ObjAtendimento.ObjPaciente = new Paciente().Buscar(id);
            frmAtendimento.CarregaPaciente();

            this.Close();
        }

        private void CarrearPacientes()
        {
            gvPacienteDoAtendimento.DataSource = new PacienteDAO().SelectAll();
        }
    }
}
