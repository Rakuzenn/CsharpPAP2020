namespace Clube_de_robotica
{
    partial class formInsEve
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
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNomeEve = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.dtrez = new System.Windows.Forms.DateTimePicker();
            this.btnCancelarEve = new System.Windows.Forms.Button();
            this.btnAddEve = new System.Windows.Forms.Button();
            this.Inseriralunos = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlocal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataEve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
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
            this.DataEve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataEve.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DataEve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataEve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.DataEve.DataSource = this.eventosBindingSource;
            this.DataEve.Location = new System.Drawing.Point(43, 299);
            this.DataEve.Name = "DataEve";
            this.DataEve.ReadOnly = true;
            this.DataEve.RowHeadersVisible = false;
            this.DataEve.Size = new System.Drawing.Size(627, 122);
            this.DataEve.TabIndex = 26;
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
            // txtNomeEve
            // 
            this.txtNomeEve.Location = new System.Drawing.Point(43, 68);
            this.txtNomeEve.Name = "txtNomeEve";
            this.txtNomeEve.Size = new System.Drawing.Size(199, 20);
            this.txtNomeEve.TabIndex = 28;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(43, 108);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(199, 20);
            this.txtDesc.TabIndex = 29;
            // 
            // dtrez
            // 
            this.dtrez.Location = new System.Drawing.Point(43, 148);
            this.dtrez.Name = "dtrez";
            this.dtrez.Size = new System.Drawing.Size(199, 20);
            this.dtrez.TabIndex = 30;
            // 
            // btnCancelarEve
            // 
            this.btnCancelarEve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCancelarEve.FlatAppearance.BorderSize = 0;
            this.btnCancelarEve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEve.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelarEve.Location = new System.Drawing.Point(292, 168);
            this.btnCancelarEve.Name = "btnCancelarEve";
            this.btnCancelarEve.Size = new System.Drawing.Size(95, 40);
            this.btnCancelarEve.TabIndex = 31;
            this.btnCancelarEve.Text = "Cancelar";
            this.btnCancelarEve.UseVisualStyleBackColor = false;
            // 
            // btnAddEve
            // 
            this.btnAddEve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAddEve.FlatAppearance.BorderSize = 0;
            this.btnAddEve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEve.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddEve.Location = new System.Drawing.Point(292, 64);
            this.btnAddEve.Name = "btnAddEve";
            this.btnAddEve.Size = new System.Drawing.Size(95, 40);
            this.btnAddEve.TabIndex = 32;
            this.btnAddEve.Text = "Adicionar";
            this.btnAddEve.UseVisualStyleBackColor = false;
            this.btnAddEve.Click += new System.EventHandler(this.btnAddEve_Click);
            // 
            // Inseriralunos
            // 
            this.Inseriralunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Inseriralunos.AutoSize = true;
            this.Inseriralunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inseriralunos.ForeColor = System.Drawing.Color.White;
            this.Inseriralunos.Location = new System.Drawing.Point(250, 9);
            this.Inseriralunos.Name = "Inseriralunos";
            this.Inseriralunos.Size = new System.Drawing.Size(267, 25);
            this.Inseriralunos.TabIndex = 33;
            this.Inseriralunos.Text = "Inserir e consultar Eventos";
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
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(40, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Data de realização";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nome do Evento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Local do evento";
            // 
            // txtlocal
            // 
            this.txtlocal.Location = new System.Drawing.Point(43, 190);
            this.txtlocal.Name = "txtlocal";
            this.txtlocal.Size = new System.Drawing.Size(199, 20);
            this.txtlocal.TabIndex = 40;
            // 
            // eventosTableAdapter
            // 
            // 
            // formInsEve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.txtlocal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Inseriralunos);
            this.Controls.Add(this.btnAddEve);
            this.Controls.Add(this.btnCancelarEve);
            this.Controls.Add(this.dtrez);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtNomeEve);
            this.Controls.Add(this.DataEve);
            this.Name = "formInsEve";
            this.Text = "formInsEve";
            this.Load += new System.EventHandler(this.formInsEve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataEve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataEve;
        private System.Windows.Forms.TextBox txtNomeEve;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.DateTimePicker dtrez;
        private System.Windows.Forms.Button btnCancelarEve;
        private System.Windows.Forms.Button btnAddEve;
        private System.Windows.Forms.Label Inseriralunos;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlocal;
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