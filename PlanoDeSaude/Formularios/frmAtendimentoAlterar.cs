using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanoDeSaude.Model;

namespace PlanoDeSaude.Formularios
{
    public partial class frmAtendimentoAlterar : Form
    {
        private Atendimento objAtendimento;
        public frmAtendimentoAlterar(Atendimento atendimento)
        {
            objAtendimento = atendimento;
            InitializeComponent();
            CarregaPaciente();
            CarregaGridExamesDoAtendimento();
        }

        public void CarregaPaciente()
        {
            txNometPaciente.Text = objAtendimento.ObjPaciente.Nome;
            txtDtNascimentoPaciente.Text = objAtendimento.ObjPaciente.DataNascimento.ToString();
            txtPlanoPaciente.Text = objAtendimento.ObjPaciente.ObjPlanoDeSaude.Nome;
        }

        public void CarregaGridExamesDoAtendimento()
        {
            gvListaDeExames.DataSource = ExamesDoAtendimento.FormatarLista(objAtendimento.ListaExamesDoAtendimento);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (
               MessageBox.Show("Deseja excluir esse atendimento? Caso confirme, todos os exames cadastrados neles também serão excluídos", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
               DialogResult.Yes)
            {
                objAtendimento.Remove();
                if (MessageBox.Show("Excluido com Sucesso!", "", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            
        }
    }
}
