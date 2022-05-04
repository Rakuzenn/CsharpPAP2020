namespace Clube_de_robotica
{
    partial class formInsProj
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
            this.components = new System.ComponentModel.Container();
            this.Inseriralunos = new System.Windows.Forms.Label();
            this.DataProj = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNomeProj = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.dtIn = new System.Windows.Forms.DateTimePicker();
            this.btnCancelarProj = new System.Windows.Forms.Button();
            this.btnAceitarProj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Inseriralunos
            // 
            this.Inseriralunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Inseriralunos.AutoSize = true;
            this.Inseriralunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inseriralunos.ForeColor = System.Drawing.Color.White;
            this.Inseriralunos.Location = new System.Drawing.Point(250, 9);
            this.Inseriralunos.Name = "Inseriralunos";
            this.Inseriralunos.Size = new System.Drawing.Size(279, 25);
            this.Inseriralunos.TabIndex = 6;
            this.Inseriralunos.Text = "Inserir e consultar Projectos";
            // 
            // DataProj
            // 
            this.DataProj.AllowUserToAddRows = false;
            this.DataProj.AllowUserToDeleteRows = false;
            this.DataProj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataProj.AutoGenerateColumns = false;
            this.DataProj.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DataProj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataProj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.datainicioDataGridViewTextBoxColumn,
            this.datafimDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.DataProj.DataSource = this.projectosBindingSource;
            this.DataProj.Location = new System.Drawing.Point(44, 307);
            this.DataProj.Name = "DataProj";
            this.DataProj.ReadOnly = true;
            this.DataProj.RowHeadersVisible = false;
            this.DataProj.Size = new System.Drawing.Size(627, 122);
            this.DataProj.TabIndex = 25;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datainicioDataGridViewTextBoxColumn
            // 
            this.datainicioDataGridViewTextBoxColumn.DataPropertyName = "Data_inicio";
            this.datainicioDataGridViewTextBoxColumn.HeaderText = "Data_Inicio";
            this.datainicioDataGridViewTextBoxColumn.Name = "datainicioDataGridViewTextBoxColumn";
            this.datainicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datafimDataGridViewTextBoxColumn
            // 
            this.datafimDataGridViewTextBoxColumn.DataPropertyName = "Data_fim";
            this.datafimDataGridViewTextBoxColumn.HeaderText = "Data Final";
            this.datafimDataGridViewTextBoxColumn.Name = "datafimDataGridViewTextBoxColumn";
            this.datafimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectosBindingSource
            // 
            this.projectosBindingSource.DataMember = "projectos";
            // 
            // projectosDataSet
            // 
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.LightGray;
            this.btnClose.Location = new System.Drawing.Point(3, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNomeProj
            // 
            this.txtNomeProj.Location = new System.Drawing.Point(43, 68);
            this.txtNomeProj.Name = "txtNomeProj";
            this.txtNomeProj.Size = new System.Drawing.Size(199, 20);
            this.txtNomeProj.TabIndex = 27;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(43, 108);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(199, 20);
            this.txtDesc.TabIndex = 28;
            // 
            // dtIn
            // 
            this.dtIn.Location = new System.Drawing.Point(43, 148);
            this.dtIn.Name = "dtIn";
            this.dtIn.Size = new System.Drawing.Size(199, 20);
            this.dtIn.TabIndex = 29;
            // 
            // btnCancelarProj
            // 
            this.btnCancelarProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCancelarProj.FlatAppearance.BorderSize = 0;
            this.btnCancelarProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProj.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelarProj.Location = new System.Drawing.Point(292, 174);
            this.btnCancelarProj.Name = "btnCancelarProj";
            this.btnCancelarProj.Size = new System.Drawing.Size(95, 40);
            this.btnCancelarProj.TabIndex = 30;
            this.btnCancelarProj.Text = "Cancelar";
            this.btnCancelarProj.UseVisualStyleBackColor = false;
            // 
            // btnAceitarProj
            // 
            this.btnAceitarProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAceitarProj.FlatAppearance.BorderSize = 0;
            this.btnAceitarProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceitarProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceitarProj.ForeColor = System.Drawing.Color.LightGray;
            this.btnAceitarProj.Location = new System.Drawing.Point(292, 68);
            this.btnAceitarProj.Name = "btnAceitarProj";
            this.btnAceitarProj.Size = new System.Drawing.Size(95, 40);
            this.btnAceitarProj.TabIndex = 31;
            this.btnAceitarProj.Text = "Adicionar";
            this.btnAceitarProj.UseVisualStyleBackColor = false;
            this.btnAceitarProj.Click += new System.EventHandler(this.btnAceitarProj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Data de inicialização";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(40, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Nome do projecto";
            // 
            // dtFim
            // 
            this.dtFim.Location = new System.Drawing.Point(43, 188);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(199, 20);
            this.dtFim.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Data de Termino";
            // 
            // projectosTableAdapter
            // 
            // 
            // formInsProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAceitarProj);
            this.Controls.Add(this.btnCancelarProj);
            this.Controls.Add(this.dtIn);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtNomeProj);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.DataProj);
            this.Controls.Add(this.Inseriralunos);
            this.Name = "formInsProj";
            this.Text = "formInsProj";
            this.Load += new System.EventHandler(this.formInsProj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Inseriralunos;
        private System.Windows.Forms.DataGridView DataProj;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNomeProj;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.DateTimePicker dtIn;
        private System.Windows.Forms.Button btnCancelarProj;
        private System.Windows.Forms.Button btnAceitarProj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource projectosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}