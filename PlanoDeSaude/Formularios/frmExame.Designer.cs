namespace PlanoDeSaude.Formularios
{
    partial class frmExame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvExames = new System.Windows.Forms.DataGridView();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbAcoes = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.gbBusca = new System.Windows.Forms.GroupBox();
            this.gbDadosExames = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvExames)).BeginInit();
            this.gbAcoes.SuspendLayout();
            this.gbBusca.SuspendLayout();
            this.gbDadosExames.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvExames
            // 
            this.gvExames.AllowUserToAddRows = false;
            this.gvExames.AllowUserToDeleteRows = false;
            this.gvExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExames.Location = new System.Drawing.Point(30, 19);
            this.gvExames.Name = "gvExames";
            this.gvExames.ReadOnly = true;
            this.gvExames.RowTemplate.ReadOnly = true;
            this.gvExames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExames.Size = new System.Drawing.Size(318, 211);
            this.gvExames.TabIndex = 4;
            this.gvExames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExames_CellClick);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(122, 32);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(206, 20);
            this.txtDescricao.TabIndex = 4;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(81, 65);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(192, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(111, 19);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(30, 20);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(58, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(58, 13);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Descrição:";
            // 
            // gbAcoes
            // 
            this.gbAcoes.Controls.Add(this.btnBuscar);
            this.gbAcoes.Controls.Add(this.btnExcluir);
            this.gbAcoes.Controls.Add(this.btnAlterar);
            this.gbAcoes.Controls.Add(this.btnSalvar);
            this.gbAcoes.Location = new System.Drawing.Point(9, 164);
            this.gbAcoes.Name = "gbAcoes";
            this.gbAcoes.Size = new System.Drawing.Size(381, 58);
            this.gbAcoes.TabIndex = 4;
            this.gbAcoes.TabStop = false;
            this.gbAcoes.Text = "Ações";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(273, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(7, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "id";
            // 
            // gbBusca
            // 
            this.gbBusca.Controls.Add(this.gvExames);
            this.gbBusca.Location = new System.Drawing.Point(9, 238);
            this.gbBusca.Name = "gbBusca";
            this.gbBusca.Size = new System.Drawing.Size(381, 251);
            this.gbBusca.TabIndex = 5;
            this.gbBusca.TabStop = false;
            this.gbBusca.Text = "Busca";
            this.gbBusca.Visible = false;
            // 
            // gbDadosExames
            // 
            this.gbDadosExames.Controls.Add(this.txtValor);
            this.gbDadosExames.Controls.Add(this.txtDescricao);
            this.gbDadosExames.Controls.Add(this.lblValor);
            this.gbDadosExames.Controls.Add(this.lblTitulo);
            this.gbDadosExames.Controls.Add(this.lblId);
            this.gbDadosExames.Location = new System.Drawing.Point(9, 12);
            this.gbDadosExames.Name = "gbDadosExames";
            this.gbDadosExames.Size = new System.Drawing.Size(381, 121);
            this.gbDadosExames.TabIndex = 3;
            this.gbDadosExames.TabStop = false;
            this.gbDadosExames.Text = "Dados dos Exame";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(122, 62);
            this.txtValor.MaxLength = 4;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(206, 20);
            this.txtValor.TabIndex = 12;
            // 
            // frmExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 513);
            this.Controls.Add(this.gbAcoes);
            this.Controls.Add(this.gbBusca);
            this.Controls.Add(this.gbDadosExames);
            this.Name = "frmExame";
            this.Text = "frmExame";
            ((System.ComponentModel.ISupportInitialize)(this.gvExames)).EndInit();
            this.gbAcoes.ResumeLayout(false);
            this.gbBusca.ResumeLayout(false);
            this.gbDadosExames.ResumeLayout(false);
            this.gbDadosExames.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvExames;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbAcoes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox gbBusca;
        private System.Windows.Forms.GroupBox gbDadosExames;
        private System.Windows.Forms.TextBox txtValor;
    }
}