
namespace Clube_de_robotica.Formss
{
    partial class formInsMat
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
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.Inseriralunos = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtNomeMat = new System.Windows.Forms.TextBox();
            this.DataMateriais = new System.Windows.Forms.DataGridView();
            this.materiaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
           this.btnAdd = new System.Windows.Forms.Button();
            this.iDartigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeartigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataMateriais)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.materiaisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nome do Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(40, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Quantidade";
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
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // Inseriralunos
            // 
            this.Inseriralunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Inseriralunos.AutoSize = true;
            this.Inseriralunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inseriralunos.ForeColor = System.Drawing.Color.White;
            this.Inseriralunos.Location = new System.Drawing.Point(209, 9);
            this.Inseriralunos.Name = "Inseriralunos";
            this.Inseriralunos.Size = new System.Drawing.Size(306, 25);
            this.Inseriralunos.TabIndex = 47;
            this.Inseriralunos.Text = "Inserir e consultar os Materiais";
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(43, 108);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(199, 20);
            this.txtQuant.TabIndex = 43;
            // 
            // txtNomeMat
            // 
            this.txtNomeMat.Location = new System.Drawing.Point(43, 68);
            this.txtNomeMat.Name = "txtNomeMat";
            this.txtNomeMat.Size = new System.Drawing.Size(199, 20);
            this.txtNomeMat.TabIndex = 42;
            // 
            // DataMateriais
            // 
            this.DataMateriais.AllowUserToAddRows = false;
            this.DataMateriais.AllowUserToDeleteRows = false;
            this.DataMateriais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataMateriais.AutoGenerateColumns = false;
            this.DataMateriais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataMateriais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DataMateriais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMateriais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDartigoDataGridViewTextBoxColumn,
            this.nomeartigoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn});
            this.DataMateriais.DataSource = this.materiaisBindingSource;
            this.DataMateriais.Location = new System.Drawing.Point(43, 220);
            this.DataMateriais.Name = "DataMateriais";
            this.DataMateriais.ReadOnly = true;
            this.DataMateriais.RowHeadersVisible = false;
            this.DataMateriais.Size = new System.Drawing.Size(627, 201);
            this.DataMateriais.TabIndex = 41;
            // 
            // dataSetMateriais
            // 
            // 
            // materiaisBindingSource
            // 
            this.materiaisBindingSource.DataMember = "Materiais";
            // 
            // materiaisTableAdapter
            // 
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.LightGray;
            this.btnAdd.Location = new System.Drawing.Point(286, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 40);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // iDartigoDataGridViewTextBoxColumn
            // 
            this.iDartigoDataGridViewTextBoxColumn.DataPropertyName = "ID_artigo";
            this.iDartigoDataGridViewTextBoxColumn.HeaderText = "ID_artigo";
            this.iDartigoDataGridViewTextBoxColumn.Name = "iDartigoDataGridViewTextBoxColumn";
            this.iDartigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDartigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeartigoDataGridViewTextBoxColumn
            // 
            this.nomeartigoDataGridViewTextBoxColumn.DataPropertyName = "Nome_artigo";
            this.nomeartigoDataGridViewTextBoxColumn.HeaderText = "Nome do Material";
            this.nomeartigoDataGridViewTextBoxColumn.Name = "nomeartigoDataGridViewTextBoxColumn";
            this.nomeartigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoDataGridViewTextBoxColumn.Visible = false;
            // 
            // formInsMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Inseriralunos);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.txtNomeMat);
            this.Controls.Add(this.DataMateriais);
            this.Name = "formInsMat";
            this.Text = "formInsMat";
            this.Load += new System.EventHandler(this.formInsMat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataMateriais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label Inseriralunos;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtNomeMat;
        private System.Windows.Forms.DataGridView DataMateriais;
        private System.Windows.Forms.BindingSource materiaisBindingSource;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeartigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
    }
}