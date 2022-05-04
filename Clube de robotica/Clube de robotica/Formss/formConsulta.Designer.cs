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
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataEve = new System.Windows.Forms.DataGridView();
            this.nomeeventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localeventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataeventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Inseriralunos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataEve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataProj
            // 
            this.DataProj.AllowUserToAddRows = false;
            this.DataProj.AllowUserToDeleteRows = false;
            this.DataProj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataProj.AutoGenerateColumns = false;
            this.DataProj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataProj.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DataProj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataProj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.datainicioDataGridViewTextBoxColumn,
            this.datafimDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.DataProj.DataSource = this.projectosBindingSource;
            this.DataProj.Location = new System.Drawing.Point(65, 90);
            this.DataProj.Name = "DataProj";
            this.DataProj.ReadOnly = true;
            this.DataProj.RowHeadersVisible = false;
            this.DataProj.Size = new System.Drawing.Size(586, 188);
            this.DataProj.TabIndex = 47;
            this.DataProj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataProj_CellContentClick);
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
            // datafimDataGridViewTextBoxColumn
            // 
            this.datafimDataGridViewTextBoxColumn.DataPropertyName = "Data_fim";
            this.datafimDataGridViewTextBoxColumn.HeaderText = "Data final";
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
            // DataEve
            // 
            this.DataEve.AllowUserToAddRows = false;
            this.DataEve.AllowUserToDeleteRows = false;
            this.DataEve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataEve.AutoGenerateColumns = false;
            this.DataEve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataEve.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DataEve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataEve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeeventoDataGridViewTextBoxColumn,
            this.localeventoDataGridViewTextBoxColumn,
            this.dataeventoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn1});
            this.DataEve.DataSource = this.eventosBindingSource;
            this.DataEve.Location = new System.Drawing.Point(65, 309);
            this.DataEve.Name = "DataEve";
            this.DataEve.ReadOnly = true;
            this.DataEve.RowHeadersVisible = false;
            this.DataEve.Size = new System.Drawing.Size(586, 191);
            this.DataEve.TabIndex = 48;
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
            this.localeventoDataGridViewTextBoxColumn.HeaderText = "Local Do evento";
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
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataMember = "eventos";
            // 
            // eventosDataSet
            // 
            // 
            // Inseriralunos
            // 
            this.Inseriralunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Inseriralunos.AutoSize = true;
            this.Inseriralunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inseriralunos.ForeColor = System.Drawing.Color.White;
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
            this.label1.ForeColor = System.Drawing.Color.White;
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
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(323, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Consulta";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblID.Location = new System.Drawing.Point(117, 35);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 52;
            this.lblID.Text = "1";
            this.lblID.Visible = false;
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
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVal.Location = new System.Drawing.Point(117, 22);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(13, 13);
            this.lblVal.TabIndex = 54;
            this.lblVal.Text = "1";
            this.lblVal.Visible = false;
            // 
            // projectosTableAdapter
            // 
            // 
            // eventosTableAdapter
            // 
            // 
            // formConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(719, 547);
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inseriralunos);
            this.Controls.Add(this.DataEve);
            this.Controls.Add(this.DataProj);
            this.Name = "formConsulta";
            this.Text = "formConsulta";
            this.Load += new System.EventHandler(this.formConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataEve)).EndInit();
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
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.BindingSource projectosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeeventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localeventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataeventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn1;
    }
}