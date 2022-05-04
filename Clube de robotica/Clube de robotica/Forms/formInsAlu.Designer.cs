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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataAlunos = new System.Windows.Forms.DataGridView();
            this.utilizadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clube_informaticaDataSet = new Clube_de_robotica.Clube_informaticaDataSet();
            this.Inseriralunos = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtNascAlu = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarAlu = new System.Windows.Forms.Button();
            this.btnAceitarAlu = new System.Windows.Forms.Button();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtNProc = new System.Windows.Forms.TextBox();
            this.txtNomeAlu = new System.Windows.Forms.TextBox();
            this.txtEmailAlu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.utilizadorTableAdapter = new Clube_de_robotica.Clube_informaticaDataSetTableAdapters.utilizadorTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nProcessoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clube_informaticaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DataAlunos
            // 
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
            this.nomeDataGridViewTextBoxColumn,
            this.nProcessoDataGridViewTextBoxColumn,
            this.cursoDataGridViewTextBoxColumn});
            this.DataAlunos.DataSource = this.utilizadorBindingSource;
            this.DataAlunos.Location = new System.Drawing.Point(43, 82);
            this.DataAlunos.Name = "DataAlunos";
            this.DataAlunos.Size = new System.Drawing.Size(427, 339);
            this.DataAlunos.TabIndex = 0;
            // 
            // utilizadorBindingSource
            // 
            this.utilizadorBindingSource.DataMember = "utilizador";
            this.utilizadorBindingSource.DataSource = this.clube_informaticaDataSet;
            // 
            // clube_informaticaDataSet
            // 
            this.clube_informaticaDataSet.DataSetName = "Clube_informaticaDataSet";
            this.clube_informaticaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dtNascAlu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNascAlu.Location = new System.Drawing.Point(508, 182);
            this.dtNascAlu.Name = "dtNascAlu";
            this.dtNascAlu.Size = new System.Drawing.Size(199, 20);
            this.dtNascAlu.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(506, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Curso";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(505, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data de nascimento";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(505, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Numero Processo";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(505, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome";
            // 
            // btnCancelarAlu
            // 
            this.btnCancelarAlu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarAlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCancelarAlu.FlatAppearance.BorderSize = 0;
            this.btnCancelarAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAlu.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelarAlu.Location = new System.Drawing.Point(508, 299);
            this.btnCancelarAlu.Name = "btnCancelarAlu";
            this.btnCancelarAlu.Size = new System.Drawing.Size(95, 40);
            this.btnCancelarAlu.TabIndex = 20;
            this.btnCancelarAlu.Text = "Cancelar";
            this.btnCancelarAlu.UseVisualStyleBackColor = false;
            // 
            // btnAceitarAlu
            // 
            this.btnAceitarAlu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceitarAlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAceitarAlu.FlatAppearance.BorderSize = 0;
            this.btnAceitarAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceitarAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceitarAlu.ForeColor = System.Drawing.Color.LightGray;
            this.btnAceitarAlu.Location = new System.Drawing.Point(612, 299);
            this.btnAceitarAlu.Name = "btnAceitarAlu";
            this.btnAceitarAlu.Size = new System.Drawing.Size(95, 40);
            this.btnAceitarAlu.TabIndex = 19;
            this.btnAceitarAlu.Text = "Adicionar";
            this.btnAceitarAlu.UseVisualStyleBackColor = false;
            this.btnAceitarAlu.Click += new System.EventHandler(this.btnAceitarAlu_Click);
            // 
            // txtCurso
            // 
            this.txtCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurso.Location = new System.Drawing.Point(508, 222);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(199, 20);
            this.txtCurso.TabIndex = 18;
            // 
            // txtNProc
            // 
            this.txtNProc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNProc.Location = new System.Drawing.Point(508, 142);
            this.txtNProc.Name = "txtNProc";
            this.txtNProc.Size = new System.Drawing.Size(199, 20);
            this.txtNProc.TabIndex = 17;
            // 
            // txtNomeAlu
            // 
            this.txtNomeAlu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeAlu.Location = new System.Drawing.Point(508, 102);
            this.txtNomeAlu.Name = "txtNomeAlu";
            this.txtNomeAlu.Size = new System.Drawing.Size(199, 20);
            this.txtNomeAlu.TabIndex = 16;
            // 
            // txtEmailAlu
            // 
            this.txtEmailAlu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailAlu.Location = new System.Drawing.Point(509, 262);
            this.txtEmailAlu.Name = "txtEmailAlu";
            this.txtEmailAlu.Size = new System.Drawing.Size(199, 20);
            this.txtEmailAlu.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label5.Location = new System.Drawing.Point(506, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Email";
            // 
            // utilizadorTableAdapter
            // 
            this.utilizadorTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // nProcessoDataGridViewTextBoxColumn
            // 
            this.nProcessoDataGridViewTextBoxColumn.DataPropertyName = "NProcesso";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nProcessoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nProcessoDataGridViewTextBoxColumn.HeaderText = "Numero Processo";
            this.nProcessoDataGridViewTextBoxColumn.Name = "nProcessoDataGridViewTextBoxColumn";
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "Curso";
            this.cursoDataGridViewTextBoxColumn.HeaderText = "Curso";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
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
            this.Controls.Add(this.btnCancelarAlu);
            this.Controls.Add(this.btnAceitarAlu);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtNProc);
            this.Controls.Add(this.txtNomeAlu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Inseriralunos);
            this.Controls.Add(this.DataAlunos);
            this.Name = "formInsAlu";
            this.Text = "Inserir e consultar alunos";
            this.Load += new System.EventHandler(this.formInsAlu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clube_informaticaDataSet)).EndInit();
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
        private System.Windows.Forms.Button btnCancelarAlu;
        private System.Windows.Forms.Button btnAceitarAlu;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtNProc;
        private System.Windows.Forms.TextBox txtNomeAlu;
        private System.Windows.Forms.TextBox txtEmailAlu;
        private System.Windows.Forms.Label label5;
        private Clube_informaticaDataSet clube_informaticaDataSet;
        private System.Windows.Forms.BindingSource utilizadorBindingSource;
        private Clube_informaticaDataSetTableAdapters.utilizadorTableAdapter utilizadorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nProcessoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
    }
}