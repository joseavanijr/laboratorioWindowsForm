namespace PlanoDeSaude.Formularios
{
    partial class frmBuscaPacienteAtendimento
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
            this.gvPacienteDoAtendimento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvPacienteDoAtendimento)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPacienteDoAtendimento
            // 
            this.gvPacienteDoAtendimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPacienteDoAtendimento.Location = new System.Drawing.Point(12, 48);
            this.gvPacienteDoAtendimento.Name = "gvPacienteDoAtendimento";
            this.gvPacienteDoAtendimento.Size = new System.Drawing.Size(606, 238);
            this.gvPacienteDoAtendimento.TabIndex = 0;
            this.gvPacienteDoAtendimento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPacienteDoAtendimento_CellClick);
            // 
            // frmBuscaPacienteAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 317);
            this.Controls.Add(this.gvPacienteDoAtendimento);
            this.Name = "frmBuscaPacienteAtendimento";
            this.Text = "frmBuscaPacienteAtendimento";
            ((System.ComponentModel.ISupportInitialize)(this.gvPacienteDoAtendimento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvPacienteDoAtendimento;
    }
}