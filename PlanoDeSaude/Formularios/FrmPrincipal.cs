using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanoDeSaude.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();  //Menu Strip é o nome do menu pra chamar + formularios lá na criação dos formularios
        }

        //Evento click pro paciente ↓
        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPaciente frmPaciente = new FrmPaciente();
            frmPaciente.MdiParent = this;
            frmPaciente.Show();
        }

        private void planoDeSaúdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanoSaude form = new frmPlanoSaude();
            form.MdiParent = this;
            form.Show();
        }

        private void exameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExame form = new frmExame();
            form.MdiParent = this;
            form.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtendimento form = new frmAtendimento();
            form.MdiParent = this;
            form.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Deseja fechar o programa?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtendimentoBuscar form = new frmAtendimentoBuscar();
            form.MdiParent = this;
            form.Show();
        }
    }
}
