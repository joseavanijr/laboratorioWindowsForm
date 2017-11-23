namespace PlanoDeSaude.Formularios
{
    partial class frmBuscaExamePedido
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
            ((System.ComponentModel.ISupportInitialize)(this.gvExames)).BeginInit();
            this.SuspendLayout();
            // 
            // gvExames
            // 
            this.gvExames.AllowUserToAddRows = false;
            this.gvExames.AllowUserToDeleteRows = false;
            this.gvExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExames.Location = new System.Drawing.Point(22, 76);
            this.gvExames.Name = "gvExames";
            this.gvExames.ReadOnly = true;
            this.gvExames.Size = new System.Drawing.Size(563, 221);
            this.gvExames.TabIndex = 1;
            this.gvExames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExames_CellClick);
            // 
            // frmBuscaExamePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 372);
            this.Controls.Add(this.gvExames);
            this.Name = "frmBuscaExamePedido";
            this.Text = "frmBuscaExamePedido";
            ((System.ComponentModel.ISupportInitialize)(this.gvExames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvExames;
    }
}