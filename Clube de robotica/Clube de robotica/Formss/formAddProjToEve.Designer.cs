
namespace Clube_de_robotica.Formss
{
    partial class formAddProjToEve
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
            this.eveid = new System.Windows.Forms.Label();
            this.DataProj = new System.Windows.Forms.DataGridView();
            this.cbeve = new System.Windows.Forms.ComboBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.projectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDprojectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projid
            // 
            this.projid.AutoSize = true;
            this.projid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.projid.Location = new System.Drawing.Point(351, 93);
            this.projid.Name = "projid";
            this.projid.Size = new System.Drawing.Size(13, 13);
            this.projid.TabIndex = 56;
            this.projid.Text = "1";
            this.projid.Visible = false;
            // 
            // eveid
            // 
            this.eveid.AutoSize = true;
            this.eveid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eveid.Location = new System.Drawing.Point(332, 93);
            this.eveid.Name = "eveid";
            this.eveid.Size = new System.Drawing.Size(13, 13);
            this.eveid.TabIndex = 55;
            this.eveid.Text = "1";
            this.eveid.Visible = false;
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
            this.nomeDataGridViewTextBoxColumn,
            this.datainicioDataGridViewTextBoxColumn,
            this.materiaisDataGridViewTextBoxColumn,
            this.datafimDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.DataProj.DataSource = this.projectosBindingSource;
            this.DataProj.Location = new System.Drawing.Point(27, 129);
            this.DataProj.Name = "DataProj";
            this.DataProj.ReadOnly = true;
            this.DataProj.RowHeadersVisible = false;
            this.DataProj.Size = new System.Drawing.Size(513, 248);
            this.DataProj.TabIndex = 54;
            this.DataProj.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataProj_CellClick);
            this.DataProj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataProj_CellContentClick);
            // 
            // cbeve
            // 
            this.cbeve.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbeve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbeve.FormattingEnabled = true;
            this.cbeve.Location = new System.Drawing.Point(256, 53);
            this.cbeve.Name = "cbeve";
            this.cbeve.Size = new System.Drawing.Size(210, 21);
            this.cbeve.TabIndex = 49;
            this.cbeve.SelectedIndexChanged += new System.EventHandler(this.cbeve_SelectedIndexChanged);
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
            this.btncancelar.TabIndex = 53;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Inserir projectos em eventos";
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
            this.btnADD.TabIndex = 52;
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
            this.button1.TabIndex = 51;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // projectosDataSet
            // 
            // 
            // projectosBindingSource
            // 
            this.projectosBindingSource.DataMember = "projectos";
            // 
            // projectosTableAdapter
            // 
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
            this.datainicioDataGridViewTextBoxColumn.HeaderText = "Data_inicio";
            this.datainicioDataGridViewTextBoxColumn.Name = "datainicioDataGridViewTextBoxColumn";
            this.datainicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.datainicioDataGridViewTextBoxColumn.Visible = false;
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
            this.datafimDataGridViewTextBoxColumn.HeaderText = "Data_fim";
            this.datafimDataGridViewTextBoxColumn.Name = "datafimDataGridViewTextBoxColumn";
            this.datafimDataGridViewTextBoxColumn.ReadOnly = true;
            this.datafimDataGridViewTextBoxColumn.Visible = false;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formAddProjToEve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(703, 411);
            this.Controls.Add(this.projid);
            this.Controls.Add(this.eveid);
            this.Controls.Add(this.DataProj);
            this.Controls.Add(this.cbeve);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.button1);
            this.Name = "formAddProjToEve";
            this.Text = "formAddProjToEve";
            this.Load += new System.EventHandler(this.formAddProjToEve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projid;
        private System.Windows.Forms.Label eveid;
        private System.Windows.Forms.DataGridView DataProj;
        private System.Windows.Forms.ComboBox cbeve;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource projectosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDprojectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}