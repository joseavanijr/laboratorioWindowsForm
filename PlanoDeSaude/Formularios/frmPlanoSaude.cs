using PlanoDeSaude.DAO;
using PlanoDeSaude.Model;
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
    public partial class frmPlanoSaude : Form
    {
        public frmPlanoSaude()
        {
            InitializeComponent();
        }

        #region METODOS

        private void Salvar()
        {
            // 1) Cria o objeto MODEL
            PlanoSaude plano = new PlanoSaude();

            // 2) Preenche o objeto da MODEL com os dados do formulário
            plano.Nome = txtNome.Text;

            // 3) Cria o objeto da DAO para levar o objeto da MODEL para o banco
            PlanoSaudeDAO planoDAO = new PlanoSaudeDAO();

            // 4) entregar o objeto da MODEL para o objeto da DAO
            planoDAO.Insert(plano);
        }
        private void Alterar()
        {
            PlanoSaude plano = new PlanoSaude();
            plano.Id =Convert.ToInt32(lblId.Text);
            plano.Nome = txtNome.Text;

            PlanoSaudeDAO pDAO = new PlanoSaudeDAO();
            pDAO.Update(plano);
        }
        private void Excluir()
        {
            PlanoSaude plano = new PlanoSaude();
            plano.Id = Convert.ToInt32(lblId.Text);

            PlanoSaudeDAO pDAO = new PlanoSaudeDAO();
            pDAO.Delete(plano);
        }
        private void CarregarGrid()
        {
            // Cria o objeto DAO para realizar a busca no banco
            PlanoSaudeDAO pDAO = new PlanoSaudeDAO();

            // Cria a lista de planos para receber o retorno do método da DAO
            IList<PlanoSaude> listaDePlano = new List<PlanoSaude>();

            //Coloca o resultado da busca na DAO na lista
            listaDePlano = pDAO.Selecionar(txtBusca.Text);

            // Coloca o resultado no DataGridView
            dgPlanos.DataSource = listaDePlano;
        }
        private void PreencheFormulario()
        {
            int id =Convert.ToInt32(dgPlanos.CurrentRow.Cells["Id"].Value);

            PlanoSaudeDAO pDAO = new PlanoSaudeDAO();
            PlanoSaude plano = new PlanoSaude();

            plano = pDAO.Selecionar(id);

            txtNome.Text = plano.Nome;
            lblId.Text = plano.Id.ToString();
        }
        #endregion

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Chamar o método salvar
            Salvar();
        }
               
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dgPlanos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PreencheFormulario();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }
    }
}
