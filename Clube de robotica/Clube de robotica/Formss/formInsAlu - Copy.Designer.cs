namespace Clube_de_robotica
{
    partial class formInsAlu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataAlunos = new System.Windows.Forms.DataGridView();
            this.utilizadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrarUtilizadoresDataSet = new Clube_de_robotica.MostrarUtilizadoresDataSet();
            this.Inseriralunos = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtNascAlu = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceitarAlu = new System.Windows.Forms.Button();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtNProc = new System.Windows.Forms.TextBox();
            this.txtNomeAlu = new System.Windows.Forms.TextBox();
            this.txtEmailAlu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.utilizadorTableAdapter = new Clube_de_robotica.MostrarUtilizadoresDataSetTableAdapters.utilizadorTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarUtilizadoresDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DataAlunos
            // 
            this.DataAlunos.AllowUserToAddRows = false;
            this.DataAlunos.AllowUserToDeleteRows = false;
            this.DataAlunos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataAlunos.AutoGenerateColumns = false;
            this.DataAlunos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nIFDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dataentradaDataGridViewTextBoxColumn});
            this.DataAlunos.DataSource = this.utilizadorBindingSource;
            this.DataAlunos.Location = new System.Drawing.Point(43, 299);
            this.DataAlunos.Name = "DataAlunos";
            this.DataAlunos.ReadOnly = true;
            this.DataAlunos.RowHeadersVisible = false;
            this.DataAlunos.Size = new System.Drawing.Size(627, 122);
            this.DataAlunos.TabIndex = 0;
            this.DataAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataAlunos_CellContentClick);
            // 
            // utilizadorBindingSource
            // 
            this.utilizadorBindingSource.DataMember = "utilizador";
            this.utilizadorBindingSource.DataSource = this.mostrarUtilizadoresDataSet;
            // 
            // mostrarUtilizadoresDataSet
            // 
            this.mostrarUtilizadoresDataSet.DataSetName = "MostrarUtilizadoresDataSet";
            this.mostrarUtilizadoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Inseriralunos
            // 
            this.Inseriralunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Inseriralunos.AutoSize = true;
            this.Inseriralunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inseriralunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.Inseriralunos.Location = new System.Drawing.Point(250, 9);
            this.Inseriralunos.Name = "Inseriralunos";
            this.Inseriralunos.Size = new System.Drawing.Size(253, 25);
            this.Inseriralunos.TabIndex = 5;
            this.Inseriralunos.Text = "Inserir e consultar alunos";
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
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtNascAlu
            // 
            this.dtNascAlu.Location = new System.Drawing.Point(43, 148);
            this.dtNascAlu.Name = "dtNascAlu";
            this.dtNascAlu.Size = new System.Drawing.Size(199, 20);
            this.dtNascAlu.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(41, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(40, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data de nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(40, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Numero Processo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome";
            // 
            // btnAceitarAlu
            // 
            this.btnAceitarAlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAceitarAlu.FlatAppearance.BorderSize = 0;
            this.btnAceitarAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceitarAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceitarAlu.ForeColor = System.Drawing.Color.LightGray;
            this.btnAceitarAlu.Location = new System.Drawing.Point(289, 140);
            this.btnAceitarAlu.Name = "btnAceitarAlu";
            this.btnAceitarAlu.Size = new System.Drawing.Size(95, 40);
            this.btnAceitarAlu.TabIndex = 19;
            this.btnAceitarAlu.Text = "Adicionar";
            this.btnAceitarAlu.UseVisualStyleBackColor = false;
            this.btnAceitarAlu.Click += new System.EventHandler(this.btnAceitarAlu_Click);
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(43, 188);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(199, 20);
            this.txtCurso.TabIndex = 18;
            // 
            // txtNProc
            // 
            this.txtNProc.Location = new System.Drawing.Point(43, 108);
            this.txtNProc.Name = "txtNProc";
            this.txtNProc.Size = new System.Drawing.Size(199, 20);
            this.txtNProc.TabIndex = 17;
            // 
            // txtNomeAlu
            // 
            this.txtNomeAlu.Location = new System.Drawing.Point(43, 68);
            this.txtNomeAlu.Name = "txtNomeAlu";
            this.txtNomeAlu.Size = new System.Drawing.Size(199, 20);
            this.txtNomeAlu.TabIndex = 16;
            // 
            // txtEmailAlu
            // 
            this.txtEmailAlu.Location = new System.Drawing.Point(44, 228);
            this.txtEmailAlu.Name = "txtEmailAlu";
            this.txtEmailAlu.Size = new System.Drawing.Size(199, 20);
            this.txtEmailAlu.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label5.Location = new System.Drawing.Point(41, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Email";
            // 
            // utilizadorTableAdapter
            // 
            this.utilizadorTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NProcesso";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nº de Processo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // nIFDataGridViewTextBoxColumn
            // 
            this.nIFDataGridViewTextBoxColumn.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn.Name = "nIFDataGridViewTextBoxColumn";
            this.nIFDataGridViewTextBoxColumn.ReadOnly = true;
            this.nIFDataGridViewTextBoxColumn.Visible = false;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Curso";
            this.dataGridViewTextBoxColumn3.HeaderText = "Curso";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "Data_Nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataentradaDataGridViewTextBoxColumn
            // 
            this.dataentradaDataGridViewTextBoxColumn.DataPropertyName = "Data_entrada";
            this.dataentradaDataGridViewTextBoxColumn.HeaderText = "Data de Entrada";
            this.dataentradaDataGridViewTextBoxColumn.Name = "dataentradaDataGridViewTextBoxColumn";
            this.dataentradaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataentradaDataGridViewTextBoxColumn.Visible = false;
            // 
            // formInsAlu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmailAlu);
            this.Controls.Add(this.dtNascAlu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceitarAlu);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtNProc);
            this.Controls.Add(this.txtNomeAlu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Inseriralunos);
            this.Controls.Add(this.DataAlunos);
            this.Name = "formInsAlu";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.DataAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarUtilizadoresDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataAlunos;
        private System.Windows.Forms.Label Inseriralunos;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtNascAlu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceitarAlu;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtNProc;
        private System.Windows.Forms.TextBox txtNomeAlu;
        private System.Windows.Forms.TextBox txtEmailAlu;
        private System.Windows.Forms.Label label5;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nProcessoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private MostrarUtilizadoresDataSet mostrarUtilizadoresDataSet;
        private System.Windows.Forms.BindingSource utilizadorBindingSource;
        private MostrarUtilizadoresDataSetTableAdapters.utilizadorTableAdapter utilizadorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentradaDataGridViewTextBoxColumn;
    }
}