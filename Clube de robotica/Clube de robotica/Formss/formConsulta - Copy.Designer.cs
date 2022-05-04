namespace Clube_de_robotica
{
    partial class formConsulta
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
            this.DataProj = new System.Windows.Forms.DataGridView();
            this.DataEve = new System.Windows.Forms.DataGridView();
            this.Inseriralunos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbluserNameAlu = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.mostrarProjectosDataSet = new Clube_de_robotica.MostrarProjectosDataSet();
            this.projectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectosTableAdapter = new Clube_de_robotica.MostrarProjectosDataSetTableAdapters.projectosTableAdapter();
            this.mostrarEventoDataSet = new Clube_de_robotica.MostrarEventoDataSet();
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventosTableAdapter = new Clube_de_robotica.MostrarEventoDataSetTableAdapters.eventosTableAdapter();
            this.iDprojectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDeventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeeventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localeventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataeventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataEve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProjectosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarEventoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.iDprojectoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.datainicioDataGridViewTextBoxColumn,
            this.materiaisDataGridViewTextBoxColumn,
            this.datafimDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.DataProj.DataSource = this.projectosBindingSource;
            this.DataProj.Location = new System.Drawing.Point(65, 90);
            this.DataProj.Name = "DataProj";
            this.DataProj.ReadOnly = true;
            this.DataProj.RowHeadersVisible = false;
            this.DataProj.Size = new System.Drawing.Size(586, 87);
            this.DataProj.TabIndex = 47;
            // 
            // DataEve
            // 
            this.DataEve.AllowUserToAddRows = false;
            this.DataEve.AllowUserToDeleteRows = false;
            this.DataEve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataEve.AutoGenerateColumns = false;
            this.DataEve.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DataEve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataEve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDeventoDataGridViewTextBoxColumn,
            this.nomeeventoDataGridViewTextBoxColumn,
            this.localeventoDataGridViewTextBoxColumn,
            this.dataeventoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn1});
            this.DataEve.DataSource = this.eventosBindingSource;
            this.DataEve.Location = new System.Drawing.Point(65, 309);
            this.DataEve.Name = "DataEve";
            this.DataEve.ReadOnly = true;
            this.DataEve.RowHeadersVisible = false;
            this.DataEve.Size = new System.Drawing.Size(586, 81);
            this.DataEve.TabIndex = 48;
            // 
            // Inseriralunos
            // 
            this.Inseriralunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Inseriralunos.AutoSize = true;
            this.Inseriralunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inseriralunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.Inseriralunos.Location = new System.Drawing.Point(323, 62);
            this.Inseriralunos.Name = "Inseriralunos";
            this.Inseriralunos.Size = new System.Drawing.Size(102, 25);
            this.Inseriralunos.TabIndex = 49;
            this.Inseriralunos.Text = "Projectos";
            this.Inseriralunos.Click += new System.EventHandler(this.Inseriralunos_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(323, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = " Eventos ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(323, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Consulta";
            // 
            // lbluserNameAlu
            // 
            this.lbluserNameAlu.AutoSize = true;
            this.lbluserNameAlu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbluserNameAlu.Location = new System.Drawing.Point(368, 49);
            this.lbluserNameAlu.Name = "lbluserNameAlu";
            this.lbluserNameAlu.Size = new System.Drawing.Size(13, 13);
            this.lbluserNameAlu.TabIndex = 52;
            this.lbluserNameAlu.Text = "1";
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
            this.btnClose.TabIndex = 53;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblID.Location = new System.Drawing.Point(238, 49);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 54;
            this.lblID.Text = "1";
            // 
            // mostrarProjectosDataSet
            // 
            this.mostrarProjectosDataSet.DataSetName = "MostrarProjectosDataSet";
            this.mostrarProjectosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectosBindingSource
            // 
            this.projectosBindingSource.DataMember = "projectos";
            this.projectosBindingSource.DataSource = this.mostrarProjectosDataSet;
            // 
            // projectosTableAdapter
            // 
            this.projectosTableAdapter.ClearBeforeFill = true;
            // 
            // mostrarEventoDataSet
            // 
            this.mostrarEventoDataSet.DataSetName = "MostrarEventoDataSet";
            this.mostrarEventoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataMember = "eventos";
            this.eventosBindingSource.DataSource = this.mostrarEventoDataSet;
            // 
            // eventosTableAdapter
            // 
            this.eventosTableAdapter.ClearBeforeFill = true;
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
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
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
            // iDeventoDataGridViewTextBoxColumn
            // 
            this.iDeventoDataGridViewTextBoxColumn.DataPropertyName = "ID_evento";
            this.iDeventoDataGridViewTextBoxColumn.HeaderText = "ID_evento";
            this.iDeventoDataGridViewTextBoxColumn.Name = "iDeventoDataGridViewTextBoxColumn";
            this.iDeventoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDeventoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeeventoDataGridViewTextBoxColumn
            // 
            this.nomeeventoDataGridViewTextBoxColumn.DataPropertyName = "Nome_evento";
            this.nomeeventoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeeventoDataGridViewTextBoxColumn.Name = "nomeeventoDataGridViewTextBoxColumn";
            this.nomeeventoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localeventoDataGridViewTextBoxColumn
            // 
            this.localeventoDataGridViewTextBoxColumn.DataPropertyName = "local_evento";
            this.localeventoDataGridViewTextBoxColumn.HeaderText = "local";
            this.localeventoDataGridViewTextBoxColumn.Name = "localeventoDataGridViewTextBoxColumn";
            this.localeventoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataeventoDataGridViewTextBoxColumn
            // 
            this.dataeventoDataGridViewTextBoxColumn.DataPropertyName = "Data_evento";
            this.dataeventoDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataeventoDataGridViewTextBoxColumn.Name = "dataeventoDataGridViewTextBoxColumn";
            this.dataeventoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn1
            // 
            this.descricaoDataGridViewTextBoxColumn1.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn1.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn1.Name = "descricaoDataGridViewTextBoxColumn1";
            this.descricaoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // formConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbluserNameAlu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inseriralunos);
            this.Controls.Add(this.DataEve);
            this.Controls.Add(this.DataProj);
            this.Name = "formConsulta";
            this.Text = "formConsulta";
            this.Load += new System.EventHandler(this.formConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataEve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProjectosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarEventoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataProj;
        private System.Windows.Forms.DataGridView DataEve;
        private System.Windows.Forms.Label Inseriralunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbluserNameAlu;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblID;
        private MostrarProjectosDataSet mostrarProjectosDataSet;
        private System.Windows.Forms.BindingSource projectosBindingSource;
        private MostrarProjectosDataSetTableAdapters.projectosTableAdapter projectosTableAdapter;
        private MostrarEventoDataSet mostrarEventoDataSet;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private MostrarEventoDataSetTableAdapters.eventosTableAdapter eventosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDprojectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDeventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeeventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localeventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataeventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn1;
    }
}