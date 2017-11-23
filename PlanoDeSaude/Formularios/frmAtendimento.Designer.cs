namespace PlanoDeSaude.Formularios
{
    partial class frmAtendimento
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
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.txtPlanoPaciente = new System.Windows.Forms.TextBox();
            this.txtDtNascimentoPaciente = new System.Windows.Forms.TextBox();
            this.txNometPaciente = new System.Windows.Forms.TextBox();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.dpDataAtendimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataAtendimento = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.gboxListaExames = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.gvListaDeExames = new System.Windows.Forms.DataGridView();
            this.btnAddExame = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.gbDados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboxListaExames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaDeExames)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.groupBox1);
            this.gbDados.Controls.Add(this.dpDataAtendimento);
            this.gbDados.Controls.Add(this.lblDataAtendimento);
            this.gbDados.Controls.Add(this.lblFuncionario);
            this.gbDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDados.Location = new System.Drawing.Point(11, 30);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(524, 153);
            this.gbDados.TabIndex = 0;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados do Atendimento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNomePaciente);
            this.groupBox1.Controls.Add(this.txtPlanoPaciente);
            this.groupBox1.Controls.Add(this.txtDtNascimentoPaciente);
            this.groupBox1.Controls.Add(this.txNometPaciente);
            this.groupBox1.Controls.Add(this.btnBuscarPaciente);
            this.groupBox1.Location = new System.Drawing.Point(139, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 95);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Plano:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nascido em:";
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Location = new System.Drawing.Point(37, 22);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(38, 13);
            this.lblNomePaciente.TabIndex = 15;
            this.lblNomePaciente.Text = "Nome:";
            // 
            // txtPlanoPaciente
            // 
            this.txtPlanoPaciente.Enabled = false;
            this.txtPlanoPaciente.Location = new System.Drawing.Point(90, 69);
            this.txtPlanoPaciente.Name = "txtPlanoPaciente";
            this.txtPlanoPaciente.ReadOnly = true;
            this.txtPlanoPaciente.Size = new System.Drawing.Size(168, 20);
            this.txtPlanoPaciente.TabIndex = 13;
            // 
            // txtDtNascimentoPaciente
            // 
            this.txtDtNascimentoPaciente.Enabled = false;
            this.txtDtNascimentoPaciente.Location = new System.Drawing.Point(90, 41);
            this.txtDtNascimentoPaciente.Name = "txtDtNascimentoPaciente";
            this.txtDtNascimentoPaciente.ReadOnly = true;
            this.txtDtNascimentoPaciente.Size = new System.Drawing.Size(168, 20);
            this.txtDtNascimentoPaciente.TabIndex = 12;
            // 
            // txNometPaciente
            // 
            this.txNometPaciente.Enabled = false;
            this.txNometPaciente.Location = new System.Drawing.Point(90, 15);
            this.txNometPaciente.Name = "txNometPaciente";
            this.txNometPaciente.ReadOnly = true;
            this.txNometPaciente.Size = new System.Drawing.Size(168, 20);
            this.txNometPaciente.TabIndex = 11;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(267, 14);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPaciente.TabIndex = 6;
            this.btnBuscarPaciente.Text = "Buscar";
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // dpDataAtendimento
            // 
            this.dpDataAtendimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDataAtendimento.Location = new System.Drawing.Point(139, 19);
            this.dpDataAtendimento.Name = "dpDataAtendimento";
            this.dpDataAtendimento.Size = new System.Drawing.Size(97, 20);
            this.dpDataAtendimento.TabIndex = 13;
            // 
            // lblDataAtendimento
            // 
            this.lblDataAtendimento.AutoSize = true;
            this.lblDataAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAtendimento.Location = new System.Drawing.Point(28, 25);
            this.lblDataAtendimento.Name = "lblDataAtendimento";
            this.lblDataAtendimento.Size = new System.Drawing.Size(108, 13);
            this.lblDataAtendimento.TabIndex = 12;
            this.lblDataAtendimento.Text = "Data Atendimento";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.Location = new System.Drawing.Point(70, 86);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(57, 13);
            this.lblFuncionario.TabIndex = 9;
            this.lblFuncionario.Text = "Paciente";
            // 
            // gboxListaExames
            // 
            this.gboxListaExames.Controls.Add(this.btnRemover);
            this.gboxListaExames.Controls.Add(this.gvListaDeExames);
            this.gboxListaExames.Controls.Add(this.btnAddExame);
            this.gboxListaExames.Location = new System.Drawing.Point(11, 187);
            this.gboxListaExames.Name = "gboxListaExames";
            this.gboxListaExames.Size = new System.Drawing.Size(524, 192);
            this.gboxListaExames.TabIndex = 1;
            this.gboxListaExames.TabStop = false;
            this.gboxListaExames.Text = "Lista de Exames";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemover.Location = new System.Drawing.Point(410, 30);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(99, 23);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Visible = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // gvListaDeExames
            // 
            this.gvListaDeExames.AllowUserToAddRows = false;
            this.gvListaDeExames.AllowUserToDeleteRows = false;
            this.gvListaDeExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListaDeExames.Location = new System.Drawing.Point(20, 54);
            this.gvListaDeExames.Name = "gvListaDeExames";
            this.gvListaDeExames.ReadOnly = true;
            this.gvListaDeExames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvListaDeExames.Size = new System.Drawing.Size(489, 122);
            this.gvListaDeExames.TabIndex = 1;
            // 
            // btnAddExame
            // 
            this.btnAddExame.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddExame.Location = new System.Drawing.Point(20, 30);
            this.btnAddExame.Name = "btnAddExame";
            this.btnAddExame.Size = new System.Drawing.Size(99, 23);
            this.btnAddExame.TabIndex = 4;
            this.btnAddExame.Text = "AdicionarExame";
            this.btnAddExame.UseVisualStyleBackColor = false;
            this.btnAddExame.Click += new System.EventHandler(this.btnAddExame_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFinalizar.Location = new System.Drawing.Point(460, 12);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // frmAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 390);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.gboxListaExames);
            this.Controls.Add(this.gbDados);
            this.Name = "frmAtendimento";
            this.Text = "Atendimento";
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboxListaExames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvListaDeExames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.TextBox txNometPaciente;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.GroupBox gboxListaExames;
        private System.Windows.Forms.DateTimePicker dpDataAtendimento;
        private System.Windows.Forms.Label lblDataAtendimento;
        private System.Windows.Forms.DataGridView gvListaDeExames;
        private System.Windows.Forms.Button btnAddExame;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPlanoPaciente;
        private System.Windows.Forms.TextBox txtDtNascimentoPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomePaciente;
    }
}