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
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancelarEve = new System.Windows.Forms.Button();
            this.InserirProfs = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataProjProf)).BeginInit();
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
            this.DataProjProf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataProjProf.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DataProjProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataProjProf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.DataProjProf.DataSource = this.projectosBindingSource;
            this.DataProjProf.Location = new System.Drawing.Point(28, 118);
            this.DataProjProf.Name = "DataProjProf";
            this.DataProjProf.ReadOnly = true;
            this.DataProjProf.RowHeadersVisible = false;
            this.DataProjProf.Size = new System.Drawing.Size(513, 248);
            this.DataProjProf.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data_inicio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data de Inicio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data_fim";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data Final";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // projectosBindingSource
            // 
            this.projectosBindingSource.DataMember = "projectos";
            // 
            // projectosDataSet
            // 
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
            this.InserirProfs.ForeColor = System.Drawing.Color.White;
            this.InserirProfs.Location = new System.Drawing.Point(117, 6);
            this.InserirProfs.Name = "InserirProfs";
            this.InserirProfs.Size = new System.Drawing.Size(482, 25);
            this.InserirProfs.TabIndex = 42;
            this.InserirProfs.Text = "Consultar em que projectos estão os professores";
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
            // projectosTableAdapter
            // 
            // 
            // formInsProfProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDprojectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource projectosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}