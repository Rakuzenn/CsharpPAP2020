namespace Clube_de_robotica
{
    partial class formInsProj
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataProj = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNomeProj = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.dtIn = new System.Windows.Forms.DateTimePicker();
            this.btnCancelarProj = new System.Windows.Forms.Button();
            this.btnAceitarProj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.clube_informaticaDataSet1 = new Clube_de_robotica.Clube_informaticaDataSet1();
            this.projectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectosTableAdapter = new Clube_de_robotica.Clube_informaticaDataSet1TableAdapters.projectosTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clube_informaticaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Inseriralunos
            // 
            this.Inseriralunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Inseriralunos.AutoSize = true;
            this.Inseriralunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inseriralunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.Inseriralunos.Location = new System.Drawing.Point(250, 9);
            this.Inseriralunos.Name = "Inseriralunos";
            this.Inseriralunos.Size = new System.Drawing.Size(279, 25);
            this.Inseriralunos.TabIndex = 6;
            this.Inseriralunos.Text = "Inserir e consultar Projectos";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(302, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(310, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(318, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nome";
            // 
            // DataProj
            // 
            this.DataProj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataProj.AutoGenerateColumns = false;
            this.DataProj.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DataProj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataProj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.datafimDataGridViewTextBoxColumn});
            this.DataProj.DataSource = this.projectosBindingSource;
            this.DataProj.Location = new System.Drawing.Point(43, 82);
            this.DataProj.Name = "DataProj";
            this.DataProj.Size = new System.Drawing.Size(427, 339);
            this.DataProj.TabIndex = 25;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.LightGray;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtNomeProj
            // 
            this.txtNomeProj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeProj.Location = new System.Drawing.Point(508, 102);
            this.txtNomeProj.Name = "txtNomeProj";
            this.txtNomeProj.Size = new System.Drawing.Size(199, 20);
            this.txtNomeProj.TabIndex = 27;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Location = new System.Drawing.Point(508, 142);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(199, 20);
            this.txtDesc.TabIndex = 28;
            // 
            // dtIn
            // 
            this.dtIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtIn.Location = new System.Drawing.Point(508, 182);
            this.dtIn.Name = "dtIn";
            this.dtIn.Size = new System.Drawing.Size(199, 20);
            this.dtIn.TabIndex = 29;
            // 
            // btnCancelarProj
            // 
            this.btnCancelarProj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCancelarProj.FlatAppearance.BorderSize = 0;
            this.btnCancelarProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProj.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelarProj.Location = new System.Drawing.Point(508, 256);
            this.btnCancelarProj.Name = "btnCancelarProj";
            this.btnCancelarProj.Size = new System.Drawing.Size(95, 40);
            this.btnCancelarProj.TabIndex = 30;
            this.btnCancelarProj.Text = "Cancelar";
            this.btnCancelarProj.UseVisualStyleBackColor = false;
            // 
            // btnAceitarProj
            // 
            this.btnAceitarProj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceitarProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAceitarProj.FlatAppearance.BorderSize = 0;
            this.btnAceitarProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceitarProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceitarProj.ForeColor = System.Drawing.Color.LightGray;
            this.btnAceitarProj.Location = new System.Drawing.Point(612, 256);
            this.btnAceitarProj.Name = "btnAceitarProj";
            this.btnAceitarProj.Size = new System.Drawing.Size(95, 40);
            this.btnAceitarProj.TabIndex = 31;
            this.btnAceitarProj.Text = "Adicionar";
            this.btnAceitarProj.UseVisualStyleBackColor = false;
            this.btnAceitarProj.Click += new System.EventHandler(this.btnAceitarProj_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(505, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label5.Location = new System.Drawing.Point(505, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Data de inicialização";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label6.Location = new System.Drawing.Point(505, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Nome do projecto";
            // 
            // dtFim
            // 
            this.dtFim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFim.Location = new System.Drawing.Point(508, 222);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(199, 20);
            this.dtFim.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label7.Location = new System.Drawing.Point(506, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Data de Termino";
            // 
            // clube_informaticaDataSet1
            // 
            this.clube_informaticaDataSet1.DataSetName = "Clube_informaticaDataSet1";
            this.clube_informaticaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectosBindingSource
            // 
            this.projectosBindingSource.DataMember = "projectos";
            this.projectosBindingSource.DataSource = this.clube_informaticaDataSet1;
            // 
            // projectosTableAdapter
            // 
            this.projectosTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // datafimDataGridViewTextBoxColumn
            // 
            this.datafimDataGridViewTextBoxColumn.DataPropertyName = "Data_fim";
            this.datafimDataGridViewTextBoxColumn.HeaderText = "Data_fim";
            this.datafimDataGridViewTextBoxColumn.Name = "datafimDataGridViewTextBoxColumn";
            // 
            // formInsProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAceitarProj);
            this.Controls.Add(this.btnCancelarProj);
            this.Controls.Add(this.dtIn);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtNomeProj);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.DataProj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inseriralunos);
            this.Name = "formInsProj";
            this.Text = "formInsProj";
            this.Load += new System.EventHandler(this.formInsProj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clube_informaticaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Inseriralunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataProj;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNomeProj;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.DateTimePicker dtIn;
        private System.Windows.Forms.Button btnCancelarProj;
        private System.Windows.Forms.Button btnAceitarProj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Label label7;
        private Clube_informaticaDataSet1 clube_informaticaDataSet1;
        private System.Windows.Forms.BindingSource projectosBindingSource;
        private Clube_informaticaDataSet1TableAdapters.projectosTableAdapter projectosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafimDataGridViewTextBoxColumn;
    }
}