namespace Clube_de_robotica
{
    partial class formInsProf
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
            this.Inseriralunos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceitarProf = new System.Windows.Forms.Button();
            this.btnCancelarProf = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.dtNascProf = new System.Windows.Forms.DateTimePicker();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.txtnomeprof = new System.Windows.Forms.TextBox();
            this.DataProf = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilizadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose1 = new System.Windows.Forms.Button();
            this.txtEmailProf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataProf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Inseriralunos
            // 
            this.Inseriralunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Inseriralunos.AutoSize = true;
            this.Inseriralunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inseriralunos.ForeColor = System.Drawing.Color.White;
            this.Inseriralunos.Location = new System.Drawing.Point(252, 9);
            this.Inseriralunos.Name = "Inseriralunos";
            this.Inseriralunos.Size = new System.Drawing.Size(302, 25);
            this.Inseriralunos.TabIndex = 37;
            this.Inseriralunos.Text = "Inserir e consultar professores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Data de nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "NIF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nome";
            // 
            // btnAceitarProf
            // 
            this.btnAceitarProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAceitarProf.FlatAppearance.BorderSize = 0;
            this.btnAceitarProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceitarProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceitarProf.ForeColor = System.Drawing.Color.LightGray;
            this.btnAceitarProf.Location = new System.Drawing.Point(292, 64);
            this.btnAceitarProf.Name = "btnAceitarProf";
            this.btnAceitarProf.Size = new System.Drawing.Size(95, 40);
            this.btnAceitarProf.TabIndex = 32;
            this.btnAceitarProf.Text = "Adicionar";
            this.btnAceitarProf.UseVisualStyleBackColor = false;
            this.btnAceitarProf.Click += new System.EventHandler(this.btnAceitarProf_Click);
            // 
            // btnCancelarProf
            // 
            this.btnCancelarProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCancelarProf.FlatAppearance.BorderSize = 0;
            this.btnCancelarProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProf.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelarProf.Location = new System.Drawing.Point(292, 208);
            this.btnCancelarProf.Name = "btnCancelarProf";
            this.btnCancelarProf.Size = new System.Drawing.Size(95, 40);
            this.btnCancelarProf.TabIndex = 31;
            this.btnCancelarProf.Text = "Cancelar";
            this.btnCancelarProf.UseVisualStyleBackColor = false;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(43, 188);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(199, 20);
            this.txtArea.TabIndex = 30;
            // 
            // dtNascProf
            // 
            this.dtNascProf.Location = new System.Drawing.Point(43, 148);
            this.dtNascProf.Name = "dtNascProf";
            this.dtNascProf.Size = new System.Drawing.Size(199, 20);
            this.dtNascProf.TabIndex = 29;
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(43, 108);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(199, 20);
            this.txtNIF.TabIndex = 28;
            // 
            // txtnomeprof
            // 
            this.txtnomeprof.Location = new System.Drawing.Point(43, 68);
            this.txtnomeprof.Name = "txtnomeprof";
            this.txtnomeprof.Size = new System.Drawing.Size(199, 20);
            this.txtnomeprof.TabIndex = 27;
            // 
            // DataProf
            // 
            this.DataProf.AllowUserToAddRows = false;
            this.DataProf.AllowUserToDeleteRows = false;
            this.DataProf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataProf.AutoGenerateColumns = false;
            this.DataProf.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DataProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataProf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.areaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10});
            this.DataProf.DataSource = this.utilizadorBindingSource;
            this.DataProf.Location = new System.Drawing.Point(43, 299);
            this.DataProf.Name = "DataProf";
            this.DataProf.ReadOnly = true;
            this.DataProf.RowHeadersVisible = false;
            this.DataProf.Size = new System.Drawing.Size(627, 122);
            this.DataProf.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NIF";
            this.dataGridViewTextBoxColumn5.HeaderText = "NIF";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn9.HeaderText = "Email";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Data_Nascimento";
            this.dataGridViewTextBoxColumn8.HeaderText = "Data de Nascimento";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Data_entrada";
            this.dataGridViewTextBoxColumn10.HeaderText = "Data de Entrada";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 120;
            // 
            // utilizadorBindingSource
            // 
            this.utilizadorBindingSource.DataMember = "utilizador";
            // 
            // userDataSet
            // 
            // 
            // btnClose1
            // 
            this.btnClose1.FlatAppearance.BorderSize = 0;
            this.btnClose1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnClose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose1.ForeColor = System.Drawing.Color.LightGray;
            this.btnClose1.Location = new System.Drawing.Point(3, 9);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(25, 25);
            this.btnClose1.TabIndex = 25;
            this.btnClose1.Text = "X";
            this.btnClose1.UseVisualStyleBackColor = true;
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // txtEmailProf
            // 
            this.txtEmailProf.Location = new System.Drawing.Point(44, 228);
            this.txtEmailProf.Name = "txtEmailProf";
            this.txtEmailProf.Size = new System.Drawing.Size(199, 20);
            this.txtEmailProf.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Email";
            // 
            // utilizadorTableAdapter
            // 
            // 
            // formInsProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmailProf);
            this.Controls.Add(this.Inseriralunos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceitarProf);
            this.Controls.Add(this.btnCancelarProf);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.dtNascProf);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.txtnomeprof);
            this.Controls.Add(this.DataProf);
            this.Controls.Add(this.btnClose1);
            this.Name = "formInsProf";
            this.Text = "Inserir e consulta professores";
            this.Load += new System.EventHandler(this.formInsProf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataProf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Inseriralunos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceitarProf;
        private System.Windows.Forms.Button btnCancelarProf;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.DateTimePicker dtNascProf;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.TextBox txtnomeprof;
        private System.Windows.Forms.DataGridView DataProf;
        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.TextBox txtEmailProf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nProcessoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource utilizadorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}