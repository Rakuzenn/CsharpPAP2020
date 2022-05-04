namespace Clube_de_robotica
{
    partial class formAluInsEve
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
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.Inseriralunos = new System.Windows.Forms.Label();
            this.cbalu = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEveID = new System.Windows.Forms.Label();
            this.DataEve = new System.Windows.Forms.DataGridView();
            this.ID_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeeventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localeventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataeventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataEve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataMember = "eventos";
            // 
            // eventosDataSet
            // 
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Location = new System.Drawing.Point(587, 337);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 40);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnADD
            // 
            this.btnADD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.LightGray;
            this.btnADD.Location = new System.Drawing.Point(587, 129);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(95, 40);
            this.btnADD.TabIndex = 43;
            this.btnADD.Text = "Adicionar";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // Inseriralunos
            // 
            this.Inseriralunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Inseriralunos.AutoSize = true;
            this.Inseriralunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inseriralunos.ForeColor = System.Drawing.Color.White;
            this.Inseriralunos.Location = new System.Drawing.Point(220, 9);
            this.Inseriralunos.Name = "Inseriralunos";
            this.Inseriralunos.Size = new System.Drawing.Size(260, 25);
            this.Inseriralunos.TabIndex = 41;
            this.Inseriralunos.Text = "Inserir alunos em Eventos";
            // 
            // cbalu
            // 
            this.cbalu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbalu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbalu.FormattingEnabled = true;
            this.cbalu.Location = new System.Drawing.Point(225, 53);
            this.cbalu.Name = "cbalu";
            this.cbalu.Size = new System.Drawing.Size(255, 21);
            this.cbalu.TabIndex = 40;
            this.cbalu.SelectedIndexChanged += new System.EventHandler(this.cbalu_SelectedIndexChanged_1);
            // 
            // eventosTableAdapter
            // 
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblID.Location = new System.Drawing.Point(584, 53);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 48;
            this.lblID.Text = "1";
            this.lblID.Visible = false;
            // 
            // lblEveID
            // 
            this.lblEveID.AutoSize = true;
            this.lblEveID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEveID.Location = new System.Drawing.Point(565, 53);
            this.lblEveID.Name = "lblEveID";
            this.lblEveID.Size = new System.Drawing.Size(13, 13);
            this.lblEveID.TabIndex = 49;
            this.lblEveID.Text = "1";
            this.lblEveID.Visible = false;
            // 
            // DataEve
            // 
            this.DataEve.AllowUserToAddRows = false;
            this.DataEve.AllowUserToDeleteRows = false;
            this.DataEve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataEve.AutoGenerateColumns = false;
            this.DataEve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataEve.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DataEve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataEve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_evento,
            this.nomeeventoDataGridViewTextBoxColumn,
            this.localeventoDataGridViewTextBoxColumn,
            this.dataeventoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.DataEve.DataSource = this.eventosBindingSource1;
            this.DataEve.Location = new System.Drawing.Point(23, 129);
            this.DataEve.Name = "DataEve";
            this.DataEve.ReadOnly = true;
            this.DataEve.RowHeadersVisible = false;
            this.DataEve.Size = new System.Drawing.Size(513, 248);
            this.DataEve.TabIndex = 50;
            this.DataEve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataEve_CellClick);
            this.DataEve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataEve_CellContentClick);
            // 
            // ID_evento
            // 
            this.ID_evento.DataPropertyName = "ID_evento";
            this.ID_evento.HeaderText = "ID_evento";
            this.ID_evento.Name = "ID_evento";
            this.ID_evento.ReadOnly = true;
            this.ID_evento.Visible = false;
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
            this.localeventoDataGridViewTextBoxColumn.HeaderText = "Local do Evento";
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
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventosBindingSource1
            // 
            this.eventosBindingSource1.DataMember = "eventos";
            // 
            // formAluInsEve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.DataEve);
            this.Controls.Add(this.lblEveID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.Inseriralunos);
            this.Controls.Add(this.cbalu);
            this.Name = "formAluInsEve";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "formAluInsEve";
            this.Load += new System.EventHandler(this.formAluInsEve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataEve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label Inseriralunos;
        private System.Windows.Forms.ComboBox cbalu;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEveID;
        private System.Windows.Forms.DataGridView DataEve;
        private System.Windows.Forms.BindingSource eventosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeeventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localeventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataeventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}