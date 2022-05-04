namespace Clube_de_robotica
{
    partial class formAluInsProj
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
            this.cbalu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lbluserNameAlu = new System.Windows.Forms.Label();
            this.projid = new System.Windows.Forms.Label();
            this.mostrarProjectosDataSet = new Clube_de_robotica.MostrarProjectosDataSet();
            this.projectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectosTableAdapter = new Clube_de_robotica.MostrarProjectosDataSetTableAdapters.projectosTableAdapter();
            this.ID_projecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDprojectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProjectosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource)).BeginInit();
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
            this.ID_projecto,
            this.iDprojectoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.datainicioDataGridViewTextBoxColumn,
            this.materiaisDataGridViewTextBoxColumn,
            this.datafimDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.DataProj.DataSource = this.projectosBindingSource;
            this.DataProj.Location = new System.Drawing.Point(23, 129);
            this.DataProj.Name = "DataProj";
            this.DataProj.ReadOnly = true;
            this.DataProj.RowHeadersVisible = false;
            this.DataProj.Size = new System.Drawing.Size(513, 248);
            this.DataProj.TabIndex = 38;
            this.DataProj.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataProj_CellClick);
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Inserir alunos em projectos";
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
            this.button1.TabIndex = 35;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btnADD.TabIndex = 36;
            this.btnADD.Text = "Adicionar";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
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
            this.btncancelar.TabIndex = 37;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lbluserNameAlu
            // 
            this.lbluserNameAlu.AutoSize = true;
            this.lbluserNameAlu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbluserNameAlu.Location = new System.Drawing.Point(694, 21);
            this.lbluserNameAlu.Name = "lbluserNameAlu";
            this.lbluserNameAlu.Size = new System.Drawing.Size(13, 13);
            this.lbluserNameAlu.TabIndex = 39;
            this.lbluserNameAlu.Text = "1";
            this.lbluserNameAlu.Visible = false;
            // 
            // projid
            // 
            this.projid.AutoSize = true;
            this.projid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.projid.Location = new System.Drawing.Point(694, -1);
            this.projid.Name = "projid";
            this.projid.Size = new System.Drawing.Size(13, 13);
            this.projid.TabIndex = 40;
            this.projid.Text = "1";
            this.projid.Visible = false;
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
            // ID_projecto
            // 
            this.ID_projecto.DataPropertyName = "ID_projecto";
            this.ID_projecto.HeaderText = "ID_projecto";
            this.ID_projecto.Name = "ID_projecto";
            this.ID_projecto.ReadOnly = true;
            this.ID_projecto.Visible = false;
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
            // formAluInsProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.projid);
            this.Controls.Add(this.lbluserNameAlu);
            this.Controls.Add(this.DataProj);
            this.Controls.Add(this.cbalu);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAluInsProj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formAluInsProj";
            this.Load += new System.EventHandler(this.formAluInsProj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProjectosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataProj;
        private System.Windows.Forms.ComboBox cbalu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lbluserNameAlu;
        private System.Windows.Forms.Label projid;
        private MostrarProjectosDataSet mostrarProjectosDataSet;
        private System.Windows.Forms.BindingSource projectosBindingSource;
        private MostrarProjectosDataSetTableAdapters.projectosTableAdapter projectosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_projecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDprojectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}