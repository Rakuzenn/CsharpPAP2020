namespace Clube_de_robotica
{
    partial class formInsAluProj
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
            this.btnCancelarAluProj = new System.Windows.Forms.Button();
            this.btnAddAluProj = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Inseriralunos = new System.Windows.Forms.Label();
            this.cbmat = new System.Windows.Forms.ComboBox();
            this.DataProjAlu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataProjAlu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarAluProj
            // 
            this.btnCancelarAluProj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarAluProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCancelarAluProj.FlatAppearance.BorderSize = 0;
            this.btnCancelarAluProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAluProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAluProj.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelarAluProj.Location = new System.Drawing.Point(584, 337);
            this.btnCancelarAluProj.Name = "btnCancelarAluProj";
            this.btnCancelarAluProj.Size = new System.Drawing.Size(95, 40);
            this.btnCancelarAluProj.TabIndex = 37;
            this.btnCancelarAluProj.Text = "Cancelar";
            this.btnCancelarAluProj.UseVisualStyleBackColor = false;
            // 
            // btnAddAluProj
            // 
            this.btnAddAluProj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAluProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAddAluProj.FlatAppearance.BorderSize = 0;
            this.btnAddAluProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAluProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAluProj.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddAluProj.Location = new System.Drawing.Point(584, 129);
            this.btnAddAluProj.Name = "btnAddAluProj";
            this.btnAddAluProj.Size = new System.Drawing.Size(95, 40);
            this.btnAddAluProj.TabIndex = 36;
            this.btnAddAluProj.Text = "Adicionar";
            this.btnAddAluProj.UseVisualStyleBackColor = false;
            this.btnAddAluProj.Click += new System.EventHandler(this.btnAddAluProj_Click_1);
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
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // Inseriralunos
            // 
            this.Inseriralunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Inseriralunos.AutoSize = true;
            this.Inseriralunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inseriralunos.ForeColor = System.Drawing.Color.White;
            this.Inseriralunos.Location = new System.Drawing.Point(154, 9);
            this.Inseriralunos.Name = "Inseriralunos";
            this.Inseriralunos.Size = new System.Drawing.Size(433, 25);
            this.Inseriralunos.TabIndex = 34;
            this.Inseriralunos.Text = "Consultar em que projectos estão os alunos";
            // 
            // cbmat
            // 
            this.cbmat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbmat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmat.FormattingEnabled = true;
            this.cbmat.Location = new System.Drawing.Point(256, 53);
            this.cbmat.Name = "cbmat";
            this.cbmat.Size = new System.Drawing.Size(210, 21);
            this.cbmat.TabIndex = 0;
            this.cbmat.SelectedIndexChanged += new System.EventHandler(this.cbalu_SelectedIndexChanged);
            // 
            // DataProjAlu
            // 
            this.DataProjAlu.AllowUserToAddRows = false;
            this.DataProjAlu.AllowUserToDeleteRows = false;
            this.DataProjAlu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataProjAlu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DataProjAlu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataProjAlu.Location = new System.Drawing.Point(12, 129);
            this.DataProjAlu.Name = "DataProjAlu";
            this.DataProjAlu.ReadOnly = true;
            this.DataProjAlu.RowHeadersVisible = false;
            this.DataProjAlu.Size = new System.Drawing.Size(566, 248);
            this.DataProjAlu.TabIndex = 38;
            // 
            // formInsAluProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.DataProjAlu);
            this.Controls.Add(this.btnCancelarAluProj);
            this.Controls.Add(this.btnAddAluProj);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Inseriralunos);
            this.Controls.Add(this.cbmat);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "formInsAluProj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSSS";
            this.Load += new System.EventHandler(this.formInsAluProj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataProjAlu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelarAluProj;
        private System.Windows.Forms.Button btnAddAluProj;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label Inseriralunos;
        private System.Windows.Forms.ComboBox cbmat;
        private System.Windows.Forms.DataGridView DataProjAlu;
    }
}