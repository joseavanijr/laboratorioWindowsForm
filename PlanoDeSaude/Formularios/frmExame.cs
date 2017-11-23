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
    public partial class frmExame : Form
    {
        public frmExame()
        {
            InitializeComponent();
        }

        private void HabilitaBotao(bool habilita)
        {
            btnSalvar.Enabled = habilita;
            btnAlterar.Enabled = !habilita;
            btnExcluir.Enabled = !habilita;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Salvar();

                //HabilitaBotao(false);
                MessageBox.Show("Operação Realizada com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void Salvar()
        {
            Exame objExame = new Exame();

            objExame.Descricao = txtDescricao.Text;
            objExame.Valor = Convert.ToDecimal(txtValor.Text);

            objExame.Save();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gbBusca.Visible = true;
            gvExames.DataSource = new Exame().Buscar();
        }

        private void gvExames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(gvExames.CurrentRow.Cells["Id"].Value);
                Exame objExame = new Exame().Buscar(id);
                txtDescricao.Text = objExame.Descricao;
                txtValor.Text = objExame.Valor.ToString();
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }


    }
}
