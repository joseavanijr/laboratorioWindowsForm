using System;
using System.Data;
using System.Windows.Forms;
using PlanoDeSaude.Model;

namespace PlanoDeSaude.Formularios
{
    public partial class frmAtendimento : Form
    {
        public Atendimento ObjAtendimento = new Atendimento();
        public frmAtendimento()
        {
            InitializeComponent();
        }

        #region MÉTODOS

        public void CarregaPaciente()
        {
            txNometPaciente.Text = ObjAtendimento.ObjPaciente.Nome;
            txtDtNascimentoPaciente.Text = ObjAtendimento.ObjPaciente.DataNascimento.ToString();
            txtPlanoPaciente.Text = ObjAtendimento.ObjPaciente.ObjPlanoDeSaude.Nome;
        }

        public void CarregaGridExamesDoAtendimento()
        {
            gvListaDeExames.DataSource = ObjAtendimento.FormatarParaExibir();
            if (ObjAtendimento.ListaExamesDoAtendimento.Count>0)
            {
                btnRemover.Visible = true;
            }
            else
            {
                btnRemover.Visible = false;
            }
        }

       #endregion

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            frmBuscaPacienteAtendimento busca = new frmBuscaPacienteAtendimento(this);
            busca.Show();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                ObjAtendimento.DataAtendimento = Convert.ToDateTime(dpDataAtendimento.Text);
                ObjAtendimento.Status = "Agendando";
                ObjAtendimento.Save();

                MessageBox.Show("Atendimento salvo com sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }

        private void btnAddExame_Click(object sender, EventArgs e)
        {
            frmBuscaExamePedido busca = new frmBuscaExamePedido(this);
            busca.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(gvListaDeExames.CurrentRow.Index);
            ObjAtendimento.RemoveItem(index);
            CarregaGridExamesDoAtendimento();
        }
    }
}
