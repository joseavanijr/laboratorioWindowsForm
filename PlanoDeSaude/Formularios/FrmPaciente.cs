using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanoDeSaude.DAO;
using PlanoDeSaude.Model;

namespace PlanoDeSaude.Formularios
{
    public partial class FrmPaciente : Form
    {
        public FrmPaciente()
        {
            InitializeComponent();
            PreencherComboBox();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Salvar();
                LimparDados();
                MessageBox.Show("Opreação realizada com sucesso");
            }
            catch (Exception erroException)
            {
                MessageBox.Show(erroException.Message);
            }

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception erroException)
            {
                MessageBox.Show(erroException.Message);
            }

        }
        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int item = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["Id"].Value);
                PreencheFormulario(new Paciente().Buscar(item));
            }
            catch (Exception erroException)
            {
                MessageBox.Show(erroException.Message);
            }

        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Alterar();
                LimparDados();
            }
            catch (Exception erroException)
            {
                MessageBox.Show(erroException.Message);
            }

        }

        #region MÉTODOS
        public void PreencherComboBox()
        {
            cbxPlanoSaude.DataSource = new PlanoSaude().FindAll();
            cbxPlanoSaude.ValueMember = "Id";
            cbxPlanoSaude.DisplayMember = "Nome";
        }
        private void Salvar()
        {
            Paciente p = new Paciente();

            if (rbTitular.Checked)
            {
                p.TipoConveniado = 1;
            }
            else if (rbDependente.Checked)
            {
                p.TipoConveniado = 2;
            }

            p.Nome = txtNome.Text;
            p.DataNascimento = Convert.ToDateTime(mktxtDataNascimento.Text);
            p.ObjPlanoDeSaude.Id = Convert.ToInt32(cbxPlanoSaude.SelectedValue);

            p.Save();
        }
        private void Buscar()
        {
            dgvPacientes.DataSource = new Paciente().Buscar(txtBuscaNome.Text);

        }
        private void PreencheFormulario(Paciente p)
        {
            lblId.Text = p.Id.ToString();
            txtNome.Text = p.Nome;
            mktxtDataNascimento.Text = p.DataNascimento.ToString();
            cbxPlanoSaude.SelectedValue = p.ObjPlanoDeSaude.Id;

            if (p.TipoConveniado == 1)
            {
                rbTitular.Checked = true;
            }
            else if (p.TipoConveniado == 2)
            {
                rbDependente.Checked = true;
            }

        }
        private void Alterar()
        {
            Paciente p = new Paciente();
            p.Id = Convert.ToInt32(lblId.Text);

            if (rbTitular.Checked)
            {
                p.TipoConveniado = 1;
            }
            else if (rbDependente.Checked)
            {
                p.TipoConveniado = 2;
            }

            p.Nome = txtNome.Text;
            p.DataNascimento = Convert.ToDateTime(mktxtDataNascimento.Text);
            p.ObjPlanoDeSaude.Id = Convert.ToInt32(cbxPlanoSaude.SelectedValue);

            p.Save();

            MessageBox.Show("Opreação realizada com sucesso! é nóix");

        }
        public void LimparDados()
        {
            txtNome.Text = string.Empty;
            mktxtDataNascimento.Text = string.Empty;
            cbxPlanoSaude.SelectedItem = null;
            rbDependente.Checked = false;
            rbTitular.Checked = false;
            lblId.Text = string.Empty;
        }


        #endregion




    }
}
