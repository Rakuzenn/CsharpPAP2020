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
            this.DataEve = new System.Windows.Forms.DataGridView();
            this.iDeventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeeventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localeventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataeventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrarEventoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrarEventoDataSet = new Clube_de_robotica.MostrarEventoDataSet();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.Inseriralunos = new System.Windows.Forms.Label();
            this.cbalu = new System.Windows.Forms.ComboBox();
            this.eveid = new System.Windows.Forms.Label();
            this.lbluserNameAlu = new System.Windows.Forms.Label();
            this.eventosTableAdapter = new Clube_de_robotica.MostrarEventoDataSetTableAdapters.eventosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataEve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarEventoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarEventoDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.descricaoDataGridViewTextBoxColumn});
            this.DataEve.DataSource = this.eventosBindingSource;
            this.DataEve.Location = new System.Drawing.Point(23, 129);
            this.DataEve.Name = "DataEve";
            this.DataEve.ReadOnly = true;
            this.DataEve.RowHeadersVisible = false;
            this.DataEve.Size = new System.Drawing.Size(513, 248);
            this.DataEve.TabIndex = 45;
            this.DataEve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataProj_CellContentClick);
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
            this.nomeeventoDataGridViewTextBoxColumn.HeaderText = "Nome do Evento";
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
            this.dataeventoDataGridViewTextBoxColumn.HeaderText = "Data do Evento";
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
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataMember = "eventos";
            this.eventosBindingSource.DataSource = this.mostrarEventoDataSetBindingSource;
            // 
            // mostrarEventoDataSetBindingSource
            // 
            this.mostrarEventoDataSetBindingSource.DataSource = this.mostrarEventoDataSet;
            this.mostrarEventoDataSetBindingSource.Position = 0;
            // 
            // mostrarEventoDataSet
            // 
            this.mostrarEventoDataSet.DataSetName = "MostrarEventoDataSet";
            this.mostrarEventoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Location = new System.Drawing.Point(587, 325);
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
            this.Inseriralunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
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
            this.cbalu.Location = new System.Drawing.Point(256, 53);
            this.cbalu.Name = "cbalu";
            this.cbalu.Size = new System.Drawing.Size(210, 21);
            this.cbalu.TabIndex = 40;
            // 
            // eveid
            // 
            this.eveid.AutoSize = true;
            this.eveid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eveid.Location = new System.Drawing.Point(557, 53);
            this.eveid.Name = "eveid";
            this.eveid.Size = new System.Drawing.Size(13, 13);
            this.eveid.TabIndex = 47;
            this.eveid.Text = "1";
            this.eveid.Visible = false;
            // 
            // lbluserNameAlu
            // 
            this.lbluserNameAlu.AutoSize = true;
            this.lbluserNameAlu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbluserNameAlu.Location = new System.Drawing.Point(596, 53);
            this.lbluserNameAlu.Name = "lbluserNameAlu";
            this.lbluserNameAlu.Size = new System.Drawing.Size(13, 13);
            this.lbluserNameAlu.TabIndex = 46;
            this.lbluserNameAlu.Text = "1";
            this.lbluserNameAlu.Visible = false;
            // 
            // eventosTableAdapter
            // 
            this.eventosTableAdapter.ClearBeforeFill = true;
            // 
            // formAluInsEve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.eveid);
            this.Controls.Add(this.lbluserNameAlu);
            this.Controls.Add(this.DataEve);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.Inseriralunos);
            this.Controls.Add(this.cbalu);
            this.Name = "formAluInsEve";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "formAluInsEve";
            this.Load += new System.EventHandler(this.formAluInsEve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataEve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarEventoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarEventoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataEve;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label Inseriralunos;
        private System.Windows.Forms.ComboBox cbalu;
        private System.Windows.Forms.Label eveid;
        private System.Windows.Forms.Label lbluserNameAlu;
        private System.Windows.Forms.BindingSource mostrarEventoDataSetBindingSource;
        private MostrarEventoDataSet mostrarEventoDataSet;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private MostrarEventoDataSetTableAdapters.eventosTableAdapter eventosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDeventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeeventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localeventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataeventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}