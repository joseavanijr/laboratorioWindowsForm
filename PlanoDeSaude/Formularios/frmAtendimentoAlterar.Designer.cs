namespace PlanoDeSaude.Formularios
{
    partial class frmAtendimentoAlterar
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
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.gboxListaExames = new System.Windows.Forms.GroupBox();
            this.gvListaDeExames = new System.Windows.Forms.DataGridView();
            this.btnAddExame = new System.Windows.Forms.Button();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.dpDataAtendimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataAtendimento = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.gboxListaExames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaDeExames)).BeginInit();
            this.gbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFinalizar.Location = new System.Drawing.Point(461, 15);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 8;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // gboxListaExames
            // 
            this.gboxListaExames.Controls.Add(this.gvListaDeExames);
            this.gboxListaExames.Controls.Add(this.btnAddExame);
            this.gboxListaExames.Location = new System.Drawing.Point(12, 183);
            this.gboxListaExames.Name = "gboxListaExames";
            this.gboxListaExames.Size = new System.Drawing.Size(524, 192);
            this.gboxListaExames.TabIndex = 7;
            this.gboxListaExames.TabStop = false;
            this.gboxListaExames.Text = "Lista de Exames";
            // 
            // gvListaDeExames
            // 
            this.gvListaDeExames.AllowUserToAddRows = false;
            this.gvListaDeExames.AllowUserToDeleteRows = false;
            this.gvListaDeExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListaDeExames.Location = new System.Drawing.Point(20, 54);
            this.gvListaDeExames.Name = "gvListaDeExames";
            this.gvListaDeExames.ReadOnly = true;
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
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.dpDataAtendimento);
            this.gbDados.Controls.Add(this.lblDataAtendimento);
            this.gbDados.Controls.Add(this.txtPaciente);
            this.gbDados.Controls.Add(this.lblPaciente);
            this.gbDados.Location = new System.Drawing.Point(12, 44);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(524, 133);
            this.gbDados.TabIndex = 6;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados do Atendimento";
            // 
            // dpDataAtendimento
            // 
            this.dpDataAtendimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDataAtendimento.Location = new System.Drawing.Point(150, 80);
            this.dpDataAtendimento.Name = "dpDataAtendimento";
            this.dpDataAtendimento.Size = new System.Drawing.Size(97, 20);
            this.dpDataAtendimento.TabIndex = 13;
            // 
            // lblDataAtendimento
            // 
            this.lblDataAtendimento.AutoSize = true;
            this.lblDataAtendimento.Location = new System.Drawing.Point(18, 86);
            this.lblDataAtendimento.Name = "lblDataAtendimento";
            this.lblDataAtendimento.Size = new System.Drawing.Size(92, 13);
            this.lblDataAtendimento.TabIndex = 12;
            this.lblDataAtendimento.Text = "Data Atendimento";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Enabled = false;
            this.txtPaciente.Location = new System.Drawing.Point(150, 34);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(246, 20);
            this.txtPaciente.TabIndex = 11;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(70, 41);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(49, 13);
            this.lblPaciente.TabIndex = 9;
            this.lblPaciente.Text = "Paciente";
            // 
            // frmAtendimentoAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 390);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.gboxListaExames);
            this.Controls.Add(this.gbDados);
            this.Name = "frmAtendimentoAlterar";
            this.Text = "Alteração de Atendimento";
            this.gboxListaExames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvListaDeExames)).EndInit();
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.GroupBox gboxListaExames;
        private System.Windows.Forms.DataGridView gvListaDeExames;
        private System.Windows.Forms.Button btnAddExame;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.DateTimePicker dpDataAtendimento;
        private System.Windows.Forms.Label lblDataAtendimento;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblPaciente;
    }
}