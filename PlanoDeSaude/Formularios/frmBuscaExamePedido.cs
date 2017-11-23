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
    public partial class frmBuscaExamePedido : Form
    {
        private frmAtendimento frmAtendimento = null;
        public frmBuscaExamePedido(frmAtendimento frmAtendemcintoPrincipal)
        {
            InitializeComponent();
            frmAtendimento = frmAtendemcintoPrincipal;
            CarregaGridExames();
        }

        private void gvExames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(gvExames.CurrentRow.Cells["Id"].Value);

            var exame = new ExameDAO().SelecionaPorID(id);

            ExamesDoAtendimento item = new ExamesDoAtendimento(frmAtendimento.ObjAtendimento);
            item.DataExame = DateTime.Now;
            item.ObjExame = exame;
            item.Status = "Exame Por fazer"; 

            frmAtendimento.ObjAtendimento.ListaExamesDoAtendimento.Add(item);
            frmAtendimento.CarregaGridExamesDoAtendimento();
            this.Close();
        }

        private void CarregaGridExames()
        {
            gvExames.DataSource = new Exame().Buscar();
        }
    }
}
