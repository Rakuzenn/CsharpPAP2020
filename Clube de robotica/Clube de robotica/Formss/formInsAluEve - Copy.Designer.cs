namespace Clube_de_robotica
{
    partial class formInsAluEve
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
            this.cbalu = new System.Windows.Forms.ComboBox();
            this.DataEveAlu = new System.Windows.Forms.DataGridView();
            this.btnAddAluEve = new System.Windows.Forms.Button();
            this.v = new System.Windows.Forms.Button();
            this.Inseriralunos = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbluserNameAlu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataEveAlu)).BeginInit();
            this.SuspendLayout();
            // 
            // cbalu
            // 
            this.cbalu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbalu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbalu.FormattingEnabled = true;
            this.cbalu.Location = new System.Drawing.Point(256, 53);
            this.cbalu.Name = "cbalu";
            this.cbalu.Size = new System.Drawing.Size(210, 21);
            this.cbalu.TabIndex = 1;
            this.cbalu.SelectedIndexChanged += new System.EventHandler(this.cbalu_SelectedIndexChanged);
            // 
            // DataEveAlu
            // 
            this.DataEveAlu.AllowUserToAddRows = false;
            this.DataEveAlu.AllowUserToDeleteRows = false;
            this.DataEveAlu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataEveAlu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DataEveAlu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataEveAlu.Location = new System.Drawing.Point(24, 118);
            this.DataEveAlu.Name = "DataEveAlu";
            this.DataEveAlu.ReadOnly = true;
            this.DataEveAlu.RowHeadersVisible = false;
            this.DataEveAlu.Size = new System.Drawing.Size(513, 248);
            this.DataEveAlu.TabIndex = 39;
            // 
            // btnAddAluEve
            // 
            this.btnAddAluEve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAluEve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnAddAluEve.FlatAppearance.BorderSize = 0;
            this.btnAddAluEve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAluEve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAluEve.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddAluEve.Location = new System.Drawing.Point(584, 118);
            this.btnAddAluEve.Name = "btnAddAluEve";
            this.btnAddAluEve.Size = new System.Drawing.Size(95, 40);
            this.btnAddAluEve.TabIndex = 40;
            this.btnAddAluEve.Text = "Adicionar";
            this.btnAddAluEve.UseVisualStyleBackColor = false;
            this.btnAddAluEve.Click += new System.EventHandler(this.btnAddAluEve_Click);
            // 
            // v
            // 
            this.v.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.v.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.v.FlatAppearance.BorderSize = 0;
            this.v.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v.ForeColor = System.Drawing.Color.LightGray;
            this.v.Location = new System.Drawing.Point(584, 326);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(95, 40);
            this.v.TabIndex = 41;
            this.v.Text = "Cancelar";
            this.v.UseVisualStyleBackColor = false;
            // 
            // Inseriralunos
            // 
            this.Inseriralunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Inseriralunos.AutoSize = true;
            this.Inseriralunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inseriralunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.Inseriralunos.Location = new System.Drawing.Point(220, 9);
            this.Inseriralunos.Name = "Inseriralunos";
            this.Inseriralunos.Size = new System.Drawing.Size(268, 25);
            this.Inseriralunos.TabIndex = 42;
            this.Inseriralunos.Text = "Inserir Alunos em Eventos ";
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
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lbluserNameAlu
            // 
            this.lbluserNameAlu.AutoSize = true;
            this.lbluserNameAlu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbluserNameAlu.Location = new System.Drawing.Point(336, 92);
            this.lbluserNameAlu.Name = "lbluserNameAlu";
            this.lbluserNameAlu.Size = new System.Drawing.Size(13, 13);
            this.lbluserNameAlu.TabIndex = 44;
            this.lbluserNameAlu.Text = "1";
            this.lbluserNameAlu.Visible = false;
            // 
            // formInsAluEve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.lbluserNameAlu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Inseriralunos);
            this.Controls.Add(this.v);
            this.Controls.Add(this.btnAddAluEve);
            this.Controls.Add(this.DataEveAlu);
            this.Controls.Add(this.cbalu);
            this.Name = "formInsAluEve";
            this.Text = "formInsAluEve";
            ((System.ComponentModel.ISupportInitialize)(this.DataEveAlu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbalu;
        private System.Windows.Forms.DataGridView DataEveAlu;
        private System.Windows.Forms.Button btnAddAluEve;
        private System.Windows.Forms.Button v;
        private System.Windows.Forms.Label Inseriralunos;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbluserNameAlu;
    }
}