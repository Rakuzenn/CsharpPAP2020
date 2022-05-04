
namespace Clube_de_robotica.Formss
{
    partial class formInsMatInProj
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
            this.btnClose = new System.Windows.Forms.Button();
            this.Inseriralunos = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.DataMat = new System.Windows.Forms.DataGridView();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbproj = new System.Windows.Forms.ComboBox();
            this.lblproj = new System.Windows.Forms.Label();
            this.lblmateriais = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // Inseriralunos
            // 
            this.Inseriralunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Inseriralunos.AutoSize = true;
            this.Inseriralunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inseriralunos.ForeColor = System.Drawing.Color.White;
            this.Inseriralunos.Location = new System.Drawing.Point(219, 9);
            this.Inseriralunos.Name = "Inseriralunos";
            this.Inseriralunos.Size = new System.Drawing.Size(294, 25);
            this.Inseriralunos.TabIndex = 48;
            this.Inseriralunos.Text = "Inserir materias nos projectos";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancel.Location = new System.Drawing.Point(584, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 40);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.LightGray;
            this.btnAdd.Location = new System.Drawing.Point(584, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 40);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DataMat
            // 
            this.DataMat.AllowUserToAddRows = false;
            this.DataMat.AllowUserToDeleteRows = false;
            this.DataMat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataMat.AutoGenerateColumns = false;
            this.DataMat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataMat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DataMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMat.DataSource = this.materialBindingSource;
            this.DataMat.Location = new System.Drawing.Point(12, 129);
            this.DataMat.Name = "DataMat";
            this.DataMat.ReadOnly = true;
            this.DataMat.RowHeadersVisible = false;
            this.DataMat.Size = new System.Drawing.Size(566, 248);
            this.DataMat.TabIndex = 45;
            this.DataMat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMat_CellClick);
            this.DataMat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMat_CellContentClick);
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            // 
            // cbproj
            // 
            this.cbproj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbproj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbproj.FormattingEnabled = true;
            this.cbproj.Location = new System.Drawing.Point(256, 53);
            this.cbproj.Name = "cbproj";
            this.cbproj.Size = new System.Drawing.Size(210, 21);
            this.cbproj.TabIndex = 44;
            this.cbproj.SelectedIndexChanged += new System.EventHandler(this.cbproj_SelectedIndexChanged);
            // 
            // lblproj
            // 
            this.lblproj.AutoSize = true;
            this.lblproj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblproj.Location = new System.Drawing.Point(340, 96);
            this.lblproj.Name = "lblproj";
            this.lblproj.Size = new System.Drawing.Size(13, 13);
            this.lblproj.TabIndex = 51;
            this.lblproj.Text = "1";
            this.lblproj.Visible = false;
            // 
            // lblmateriais
            // 
            this.lblmateriais.AutoSize = true;
            this.lblmateriais.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmateriais.Location = new System.Drawing.Point(359, 96);
            this.lblmateriais.Name = "lblmateriais";
            this.lblmateriais.Size = new System.Drawing.Size(13, 13);
            this.lblmateriais.TabIndex = 50;
            this.lblmateriais.Text = "1";
            this.lblmateriais.Visible = false;
            // 
            // formInsMatInProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.lblproj);
            this.Controls.Add(this.lblmateriais);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Inseriralunos);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DataMat);
            this.Controls.Add(this.cbproj);
            this.Name = "formInsMatInProj";
            this.Text = "formInsMatInProj";
            this.Load += new System.EventHandler(this.formInsMatInProj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label Inseriralunos;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView DataMat;
        private System.Windows.Forms.ComboBox cbproj;
        private System.Windows.Forms.Label lblproj;
        private System.Windows.Forms.Label lblmateriais;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeartigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
    }
}