namespace Clube_de_robotica
{
    partial class formProfInsProj
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
            this.projid = new System.Windows.Forms.Label();
            this.lbluserNameAlu = new System.Windows.Forms.Label();
            this.DataProj = new System.Windows.Forms.DataGridView();
            this.projectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbprof = new System.Windows.Forms.ComboBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clube_informaticaDataSet = new Clube_de_robotica.Clube_informaticaDataSet();
            this.projectosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectosTableAdapter = new Clube_de_robotica.Clube_informaticaDataSetTableAdapters.projectosTableAdapter();
            this.iDprojectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clube_informaticaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // projid
            // 
            this.projid.AutoSize = true;
            this.projid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.projid.Location = new System.Drawing.Point(8, 61);
            this.projid.Name = "projid";
            this.projid.Size = new System.Drawing.Size(13, 13);
            this.projid.TabIndex = 48;
            this.projid.Text = "1";
            // 
            // lbluserNameAlu
            // 
            this.lbluserNameAlu.AutoSize = true;
            this.lbluserNameAlu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbluserNameAlu.Location = new System.Drawing.Point(20, 61);
            this.lbluserNameAlu.Name = "lbluserNameAlu";
            this.lbluserNameAlu.Size = new System.Drawing.Size(13, 13);
            this.lbluserNameAlu.TabIndex = 47;
            this.lbluserNameAlu.Text = "1";
            // 
            // DataProj
            // 
            this.DataProj.AllowUserToAddRows = false;
            this.DataProj.AllowUserToDeleteRows = false;
            this.DataProj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataProj.AutoGenerateColumns = false;
            this.DataProj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataProj.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DataProj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataProj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDprojectoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.materiaisDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.DataProj.DataSource = this.projectosBindingSource1;
            this.DataProj.Location = new System.Drawing.Point(23, 129);
            this.DataProj.Name = "DataProj";
            this.DataProj.ReadOnly = true;
            this.DataProj.RowHeadersVisible = false;
            this.DataProj.Size = new System.Drawing.Size(513, 248);
            this.DataProj.TabIndex = 46;
            this.DataProj.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataProj_CellClick);
            this.DataProj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataProj_CellContentClick_1);
            // 
            // projectosBindingSource
            // 
            this.projectosBindingSource.DataMember = "projectos";
            // 
            // cbprof
            // 
            this.cbprof.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbprof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbprof.FormattingEnabled = true;
            this.cbprof.Location = new System.Drawing.Point(222, 53);
            this.cbprof.Name = "cbprof";
            this.cbprof.Size = new System.Drawing.Size(314, 21);
            this.cbprof.TabIndex = 41;
            this.cbprof.SelectedIndexChanged += new System.EventHandler(this.cbprof_SelectedIndexChanged);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btncancelar.Location = new System.Drawing.Point(587, 337);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(95, 40);
            this.btncancelar.TabIndex = 45;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Inserir professores em projectos";
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
            this.btnADD.TabIndex = 44;
            this.btnADD.Text = "Adicionar";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(3, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 43;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // clube_informaticaDataSet
            // 
            this.clube_informaticaDataSet.DataSetName = "Clube_informaticaDataSet";
            this.clube_informaticaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectosBindingSource1
            // 
            this.projectosBindingSource1.DataMember = "projectos";
            this.projectosBindingSource1.DataSource = this.clube_informaticaDataSet;
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
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Data_inicio";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data_inicio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // materiaisDataGridViewTextBoxColumn
            // 
            this.materiaisDataGridViewTextBoxColumn.DataPropertyName = "Materiais";
            this.materiaisDataGridViewTextBoxColumn.HeaderText = "Materiais";
            this.materiaisDataGridViewTextBoxColumn.Name = "materiaisDataGridViewTextBoxColumn";
            this.materiaisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Data_fim";
            this.dataGridViewTextBoxColumn7.HeaderText = "Data_fim";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn8.HeaderText = "descricao";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // formProfInsProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(703, 411);
            this.Controls.Add(this.projid);
            this.Controls.Add(this.lbluserNameAlu);
            this.Controls.Add(this.DataProj);
            this.Controls.Add(this.cbprof);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formProfInsProj";
            this.Text = "formProfInsProj";
            this.Load += new System.EventHandler(this.formProfInsProj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clube_informaticaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projid;
        private System.Windows.Forms.Label lbluserNameAlu;
        private System.Windows.Forms.DataGridView DataProj;
        private System.Windows.Forms.ComboBox cbprof;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource projectosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Clube_informaticaDataSet clube_informaticaDataSet;
        private System.Windows.Forms.BindingSource projectosBindingSource1;
        private Clube_informaticaDataSetTableAdapters.projectosTableAdapter projectosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDprojectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}