namespace PlanoDeSaude.Formularios
{
    partial class frmAtendimentoBuscar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.gvListaDeExames = new System.Windows.Forms.DataGridView();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarAtendimento = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaDeExames)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarTodos);
            this.groupBox1.Controls.Add(this.gvListaDeExames);
            this.groupBox1.Controls.Add(this.dtpDataFim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpDataInicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBuscarAtendimento);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Atendimento";
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Location = new System.Drawing.Point(441, 34);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(65, 23);
            this.btnBuscarTodos.TabIndex = 16;
            this.btnBuscarTodos.Text = "Todos";
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // gvListaDeExames
            // 
            this.gvListaDeExames.AllowUserToAddRows = false;
            this.gvListaDeExames.AllowUserToDeleteRows = false;
            this.gvListaDeExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListaDeExames.Location = new System.Drawing.Point(20, 80);
            this.gvListaDeExames.Name = "gvListaDeExames";
            this.gvListaDeExames.ReadOnly = true;
            this.gvListaDeExames.Size = new System.Drawing.Size(489, 171);
            this.gvListaDeExames.TabIndex = 1;
            this.gvListaDeExames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvListaDeExames_CellClick);
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.Location = new System.Drawing.Point(237, 34);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(97, 20);
            this.dtpDataFim.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "à:";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(112, 35);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(97, 20);
            this.dtpDataInicio.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Atendimentos de:";
            // 
            // btnBuscarAtendimento
            // 
            this.btnBuscarAtendimento.Location = new System.Drawing.Point(352, 33);
            this.btnBuscarAtendimento.Name = "btnBuscarAtendimento";
            this.btnBuscarAtendimento.Size = new System.Drawing.Size(83, 23);
            this.btnBuscarAtendimento.TabIndex = 10;
            this.btnBuscarAtendimento.Text = "Pesquisar";
            this.btnBuscarAtendimento.UseVisualStyleBackColor = true;
            this.btnBuscarAtendimento.Click += new System.EventHandler(this.btnBuscarAtendimento_Click);
            // 
            // frmAtendimentoBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 325);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAtendimentoBuscar";
            this.Text = "Pesquisa de atendimento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaDeExames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarAtendimento;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvListaDeExames;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarTodos;
    }
}