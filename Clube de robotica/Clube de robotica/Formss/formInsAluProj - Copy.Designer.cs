namespace Clube_de_robotica
{
    partial class formInsAluProj
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
            this.lbluserNameAlu = new System.Windows.Forms.Label();
            this.btnCancelarAluProj = new System.Windows.Forms.Button();
            this.btnAddAluProj = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Inseriralunos = new System.Windows.Forms.Label();
            this.cbalu = new System.Windows.Forms.ComboBox();
            this.DataProjAlu = new System.Windows.Forms.DataGridView();
            this.projectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrarProjectosUtilizadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrarProjectosUtilizador = new Clube_de_robotica.MostrarProjectosUtilizador();
            this.projectosTableAdapter = new Clube_de_robotica.MostrarProjectosUtilizadorTableAdapters.projectosTableAdapter();
            this.iDprojectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataProjAlu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProjectosUtilizadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProjectosUtilizador)).BeginInit();
            this.SuspendLayout();
            // 
            // lbluserNameAlu
            // 
            this.lbluserNameAlu.AutoSize = true;
            this.lbluserNameAlu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbluserNameAlu.Location = new System.Drawing.Point(332, 93);
            this.lbluserNameAlu.Name = "lbluserNameAlu";
            this.lbluserNameAlu.Size = new System.Drawing.Size(13, 13);
            this.lbluserNameAlu.TabIndex = 39;
            this.lbluserNameAlu.Text = "1";
            this.lbluserNameAlu.Visible = false;
            // 
            // btnCancelarAluProj
            // 
            this.btnCancelarAluProj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarAluProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCancelarAluProj.FlatAppearance.BorderSize = 0;
            this.btnCancelarAluProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAluProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAluProj.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelarAluProj.Location = new System.Drawing.Point(584, 326);
            this.btnCancelarAluProj.Name = "btnCancelarAluProj";
            this.btnCancelarAluProj.Size = new System.Drawing.Size(95, 40);
            this.btnCancelarAluProj.TabIndex = 37;
            this.btnCancelarAluProj.Text = "Cancelar";
            this.btnCancelarAluProj.UseVisualStyleBackColor = false;
            // 
            // btnAddAluProj
            // 
            this.btnAddAluProj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAluProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAddAluProj.FlatAppearance.BorderSize = 0;
            this.btnAddAluProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAluProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAluProj.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddAluProj.Location = new System.Drawing.Point(584, 118);
            this.btnAddAluProj.Name = "btnAddAluProj";
            this.btnAddAluProj.Size = new System.Drawing.Size(95, 40);
            this.btnAddAluProj.TabIndex = 36;
            this.btnAddAluProj.Text = "Adicionar";
            this.btnAddAluProj.UseVisualStyleBackColor = false;
            this.btnAddAluProj.Click += new System.EventHandler(this.btnAddAluProj_Click_1);
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
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // Inseriralunos
            // 
            this.Inseriralunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Inseriralunos.AutoSize = true;
            this.Inseriralunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inseriralunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.Inseriralunos.Location = new System.Drawing.Point(220, 9);
            this.Inseriralunos.Name = "Inseriralunos";
            this.Inseriralunos.Size = new System.Drawing.Size(270, 25);
            this.Inseriralunos.TabIndex = 34;
            this.Inseriralunos.Text = "Inserir alunos em projectos";
            // 
            // cbalu
            // 
            this.cbalu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbalu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbalu.FormattingEnabled = true;
            this.cbalu.Location = new System.Drawing.Point(256, 53);
            this.cbalu.Name = "cbalu";
            this.cbalu.Size = new System.Drawing.Size(210, 21);
            this.cbalu.TabIndex = 0;
            this.cbalu.SelectedIndexChanged += new System.EventHandler(this.cbalu_SelectedIndexChanged);
            // 
            // DataProjAlu
            // 
            this.DataProjAlu.AllowUserToAddRows = false;
            this.DataProjAlu.AllowUserToDeleteRows = false;
            this.DataProjAlu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataProjAlu.AutoGenerateColumns = false;
            this.DataProjAlu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DataProjAlu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataProjAlu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDprojectoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.datainicioDataGridViewTextBoxColumn,
            this.materiaisDataGridViewTextBoxColumn,
            this.datafimDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.DataProjAlu.DataSource = this.projectosBindingSource;
            this.DataProjAlu.Location = new System.Drawing.Point(23, 129);
            this.DataProjAlu.Name = "DataProjAlu";
            this.DataProjAlu.ReadOnly = true;
            this.DataProjAlu.RowHeadersVisible = false;
            this.DataProjAlu.Size = new System.Drawing.Size(513, 248);
            this.DataProjAlu.TabIndex = 38;
            // 
            // projectosBindingSource
            // 
            this.projectosBindingSource.DataMember = "projectos";
            this.projectosBindingSource.DataSource = this.mostrarProjectosUtilizadorBindingSource;
            // 
            // mostrarProjectosUtilizadorBindingSource
            // 
            this.mostrarProjectosUtilizadorBindingSource.DataSource = this.mostrarProjectosUtilizador;
            this.mostrarProjectosUtilizadorBindingSource.Position = 0;
            // 
            // mostrarProjectosUtilizador
            // 
            this.mostrarProjectosUtilizador.DataSetName = "MostrarProjectosUtilizador";
            this.mostrarProjectosUtilizador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectosTableAdapter
            // 
            this.projectosTableAdapter.ClearBeforeFill = true;
            // 
            // iDprojectoDataGridViewTextBoxColumn
            // 
            this.iDprojectoDataGridViewTextBoxColumn.DataPropertyName = "ID_projecto";
            this.iDprojectoDataGridViewTextBoxColumn.HeaderText = "ID_projecto";
            this.iDprojectoDataGridViewTextBoxColumn.Name = "iDprojectoDataGridViewTextBoxColumn";
            this.iDprojectoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDprojectoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome do Projecto";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datainicioDataGridViewTextBoxColumn
            // 
            this.datainicioDataGridViewTextBoxColumn.DataPropertyName = "Data_inicio";
            this.datainicioDataGridViewTextBoxColumn.HeaderText = "Data de Inicio";
            this.datainicioDataGridViewTextBoxColumn.Name = "datainicioDataGridViewTextBoxColumn";
            this.datainicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materiaisDataGridViewTextBoxColumn
            // 
            this.materiaisDataGridViewTextBoxColumn.DataPropertyName = "Materiais";
            this.materiaisDataGridViewTextBoxColumn.HeaderText = "Materiais";
            this.materiaisDataGridViewTextBoxColumn.Name = "materiaisDataGridViewTextBoxColumn";
            this.materiaisDataGridViewTextBoxColumn.ReadOnly = true;
            this.materiaisDataGridViewTextBoxColumn.Visible = false;
            // 
            // datafimDataGridViewTextBoxColumn
            // 
            this.datafimDataGridViewTextBoxColumn.DataPropertyName = "Data_fim";
            this.datafimDataGridViewTextBoxColumn.HeaderText = "Data de Finalização";
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
            // formInsAluProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.lbluserNameAlu);
            this.Controls.Add(this.DataProjAlu);
            this.Controls.Add(this.btnCancelarAluProj);
            this.Controls.Add(this.btnAddAluProj);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Inseriralunos);
            this.Controls.Add(this.cbalu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "formInsAluProj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formInsAluProj";
            this.Load += new System.EventHandler(this.formInsAluProj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataProjAlu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProjectosUtilizadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProjectosUtilizador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbluserNameAlu;
        private System.Windows.Forms.Button btnCancelarAluProj;
        private System.Windows.Forms.Button btnAddAluProj;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label Inseriralunos;
        private System.Windows.Forms.ComboBox cbalu;
        private System.Windows.Forms.DataGridView DataProjAlu;
        private System.Windows.Forms.BindingSource mostrarProjectosUtilizadorBindingSource;
        private MostrarProjectosUtilizador mostrarProjectosUtilizador;
        private System.Windows.Forms.BindingSource projectosBindingSource;
        private MostrarProjectosUtilizadorTableAdapters.projectosTableAdapter projectosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDprojectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}