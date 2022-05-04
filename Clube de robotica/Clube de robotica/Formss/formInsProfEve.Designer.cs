namespace Clube_de_robotica
{
    partial class formInsProfEve
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
            this.Inseriralunos = new System.Windows.Forms.Label();
            this.DataEveProf = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddProfEve = new System.Windows.Forms.Button();
            this.btnCancelarProfEve = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataEveProf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
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
            this.cbprof.TabIndex = 2;
            this.cbprof.SelectedIndexChanged += new System.EventHandler(this.cbprof_SelectedIndexChanged);
            // 
            // Inseriralunos
            // 
            this.Inseriralunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Inseriralunos.AutoSize = true;
            this.Inseriralunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inseriralunos.ForeColor = System.Drawing.Color.White;
            this.Inseriralunos.Location = new System.Drawing.Point(120, 9);
            this.Inseriralunos.Name = "Inseriralunos";
            this.Inseriralunos.Size = new System.Drawing.Size(470, 25);
            this.Inseriralunos.TabIndex = 43;
            this.Inseriralunos.Text = "Consultar em que eventos estão os professores";
            this.Inseriralunos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DataEveProf
            // 
            this.DataEveProf.AllowUserToAddRows = false;
            this.DataEveProf.AllowUserToDeleteRows = false;
            this.DataEveProf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataEveProf.AutoGenerateColumns = false;
            this.DataEveProf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataEveProf.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DataEveProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataEveProf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.DataEveProf.DataSource = this.eventosBindingSource;
            this.DataEveProf.Location = new System.Drawing.Point(25, 118);
            this.DataEveProf.Name = "DataEveProf";
            this.DataEveProf.ReadOnly = true;
            this.DataEveProf.RowHeadersVisible = false;
            this.DataEveProf.Size = new System.Drawing.Size(513, 248);
            this.DataEveProf.TabIndex = 46;
            this.DataEveProf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataEveProf_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome_evento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "local_evento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Local do Evento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data_evento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataMember = "eventos";
            // 
            // eventosDataSet
            // 
            // 
            // btnAddProfEve
            // 
            this.btnAddProfEve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProfEve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAddProfEve.FlatAppearance.BorderSize = 0;
            this.btnAddProfEve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProfEve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProfEve.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddProfEve.Location = new System.Drawing.Point(584, 118);
            this.btnAddProfEve.Name = "btnAddProfEve";
            this.btnAddProfEve.Size = new System.Drawing.Size(95, 40);
            this.btnAddProfEve.TabIndex = 47;
            this.btnAddProfEve.Text = "Adicionar";
            this.btnAddProfEve.UseVisualStyleBackColor = false;
            this.btnAddProfEve.Click += new System.EventHandler(this.btnAddProfEve_Click);
            // 
            // btnCancelarProfEve
            // 
            this.btnCancelarProfEve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarProfEve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCancelarProfEve.FlatAppearance.BorderSize = 0;
            this.btnCancelarProfEve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarProfEve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProfEve.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelarProfEve.Location = new System.Drawing.Point(584, 326);
            this.btnCancelarProfEve.Name = "btnCancelarProfEve";
            this.btnCancelarProfEve.Size = new System.Drawing.Size(95, 40);
            this.btnCancelarProfEve.TabIndex = 48;
            this.btnCancelarProfEve.Text = "Cancelar";
            this.btnCancelarProfEve.UseVisualStyleBackColor = false;
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
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // eventosTableAdapter
            // 
            // 
            // formInsProfEve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancelarProfEve);
            this.Controls.Add(this.btnAddProfEve);
            this.Controls.Add(this.DataEveProf);
            this.Controls.Add(this.Inseriralunos);
            this.Controls.Add(this.cbprof);
            this.Name = "formInsProfEve";
            this.Text = "formInsProfEve";
            this.Load += new System.EventHandler(this.formInsProfEve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataEveProf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbprof;
        private System.Windows.Forms.Label Inseriralunos;
        private System.Windows.Forms.DataGridView DataEveProf;
        private System.Windows.Forms.Button btnAddProfEve;
        private System.Windows.Forms.Button btnCancelarProfEve;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDeventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeeventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localeventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataeventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}