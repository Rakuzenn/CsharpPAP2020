namespace Clube_de_robotica
{
    partial class formInsProfProj
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
            this.cbprof = new System.Windows.Forms.ComboBox();
            this.DataProjProf = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancelarEve = new System.Windows.Forms.Button();
            this.InserirProfs = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbluserNameProf = new System.Windows.Forms.Label();
            this.mostrarProjectosUtilizador = new Clube_de_robotica.MostrarProjectosUtilizador();
            this.mostrarProjectosUtilizadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectosTableAdapter = new Clube_de_robotica.MostrarProjectosUtilizadorTableAdapters.projectosTableAdapter();
            this.iDprojectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataProjProf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProjectosUtilizador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProjectosUtilizadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbprof
            // 
            this.cbprof.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbprof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbprof.FormattingEnabled = true;
            this.cbprof.Location = new System.Drawing.Point(256, 53);
            this.cbprof.Name = "cbprof";
            this.cbprof.Size = new System.Drawing.Size(210, 21);
            this.cbprof.TabIndex = 1;
            this.cbprof.SelectedIndexChanged += new System.EventHandler(this.cbprof_SelectedIndexChanged);
            // 
            // DataProjProf
            // 
            this.DataProjProf.AllowUserToAddRows = false;
            this.DataProjProf.AllowUserToDeleteRows = false;
            this.DataProjProf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataProjProf.AutoGenerateColumns = false;
            this.DataProjProf.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DataProjProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataProjProf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDprojectoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.datainicioDataGridViewTextBoxColumn,
            this.materiaisDataGridViewTextBoxColumn,
            this.datafimDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.DataProjProf.DataSource = this.projectosBindingSource;
            this.DataProjProf.Location = new System.Drawing.Point(24, 118);
            this.DataProjProf.Name = "DataProjProf";
            this.DataProjProf.ReadOnly = true;
            this.DataProjProf.RowHeadersVisible = false;
            this.DataProjProf.Size = new System.Drawing.Size(513, 248);
            this.DataProjProf.TabIndex = 39;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.LightGray;
            this.btnAdd.Location = new System.Drawing.Point(584, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 40);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancelarEve
            // 
            this.btnCancelarEve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarEve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCancelarEve.FlatAppearance.BorderSize = 0;
            this.btnCancelarEve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEve.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelarEve.Location = new System.Drawing.Point(584, 326);
            this.btnCancelarEve.Name = "btnCancelarEve";
            this.btnCancelarEve.Size = new System.Drawing.Size(95, 40);
            this.btnCancelarEve.TabIndex = 41;
            this.btnCancelarEve.Text = "Cancelar";
            this.btnCancelarEve.UseVisualStyleBackColor = false;
            // 
            // InserirProfs
            // 
            this.InserirProfs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InserirProfs.AutoSize = true;
            this.InserirProfs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InserirProfs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.InserirProfs.Location = new System.Drawing.Point(220, 9);
            this.InserirProfs.Name = "InserirProfs";
            this.InserirProfs.Size = new System.Drawing.Size(321, 25);
            this.InserirProfs.TabIndex = 42;
            this.InserirProfs.Text = "Inserir Professores em projectos";
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
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lbluserNameProf
            // 
            this.lbluserNameProf.AutoSize = true;
            this.lbluserNameProf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbluserNameProf.Location = new System.Drawing.Point(332, 93);
            this.lbluserNameProf.Name = "lbluserNameProf";
            this.lbluserNameProf.Size = new System.Drawing.Size(13, 13);
            this.lbluserNameProf.TabIndex = 44;
            this.lbluserNameProf.Text = "1";
            this.lbluserNameProf.Visible = false;
            // 
            // mostrarProjectosUtilizador
            // 
            this.mostrarProjectosUtilizador.DataSetName = "MostrarProjectosUtilizador";
            this.mostrarProjectosUtilizador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mostrarProjectosUtilizadorBindingSource
            // 
            this.mostrarProjectosUtilizadorBindingSource.DataSource = this.mostrarProjectosUtilizador;
            this.mostrarProjectosUtilizadorBindingSource.Position = 0;
            // 
            // projectosBindingSource
            // 
            this.projectosBindingSource.DataMember = "projectos";
            this.projectosBindingSource.DataSource = this.mostrarProjectosUtilizadorBindingSource;
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
            this.datafimDataGridViewTextBoxColumn.HeaderText = "Data de finalização";
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
            // formInsProfProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.lbluserNameProf);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.InserirProfs);
            this.Controls.Add(this.btnCancelarEve);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DataProjProf);
            this.Controls.Add(this.cbprof);
            this.Name = "formInsProfProj";
            this.Text = "formInsProfProj";
            this.Load += new System.EventHandler(this.formInsProfProj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataProjProf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProjectosUtilizador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProjectosUtilizadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbprof;
        private System.Windows.Forms.DataGridView DataProjProf;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancelarEve;
        private System.Windows.Forms.Label InserirProfs;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbluserNameProf;
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