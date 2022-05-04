namespace Clube_de_robotica
{
    partial class FormPerfil
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
            this.txtNomeUtilizador = new System.Windows.Forms.TextBox();
            this.txtEmailUtilizador = new System.Windows.Forms.TextBox();
            this.txtNpNi = new System.Windows.Forms.TextBox();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.txtAlterPassword = new System.Windows.Forms.TextBox();
            this.lblNomeUtilizador = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.Nif = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Inseriralunos = new System.Windows.Forms.Label();
            this.btnSalvarPerfil = new System.Windows.Forms.Button();
            this.btnCancelarPerfil = new System.Windows.Forms.Button();
            this.txtdtnasc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNprocesso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomeUtilizador
            // 
            this.txtNomeUtilizador.Location = new System.Drawing.Point(24, 107);
            this.txtNomeUtilizador.Name = "txtNomeUtilizador";
            this.txtNomeUtilizador.ReadOnly = true;
            this.txtNomeUtilizador.Size = new System.Drawing.Size(199, 20);
            this.txtNomeUtilizador.TabIndex = 29;
            // 
            // txtEmailUtilizador
            // 
            this.txtEmailUtilizador.Location = new System.Drawing.Point(24, 153);
            this.txtEmailUtilizador.Name = "txtEmailUtilizador";
            this.txtEmailUtilizador.Size = new System.Drawing.Size(199, 20);
            this.txtEmailUtilizador.TabIndex = 30;
            // 
            // txtNpNi
            // 
            this.txtNpNi.Location = new System.Drawing.Point(1, 9);
            this.txtNpNi.Name = "txtNpNi";
            this.txtNpNi.Size = new System.Drawing.Size(10, 20);
            this.txtNpNi.TabIndex = 33;
            this.txtNpNi.UseSystemPasswordChar = true;
            this.txtNpNi.Visible = false;
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(23, 204);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(199, 20);
            this.txtNif.TabIndex = 34;
            this.txtNif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNif_KeyPress);
            // 
            // txtAlterPassword
            // 
            this.txtAlterPassword.Location = new System.Drawing.Point(259, 243);
            this.txtAlterPassword.Name = "txtAlterPassword";
            this.txtAlterPassword.PasswordChar = '*';
            this.txtAlterPassword.ReadOnly = true;
            this.txtAlterPassword.Size = new System.Drawing.Size(199, 20);
            this.txtAlterPassword.TabIndex = 35;
            this.txtAlterPassword.TextChanged += new System.EventHandler(this.txtAlterPassword_TextChanged);
            // 
            // lblNomeUtilizador
            // 
            this.lblNomeUtilizador.AutoSize = true;
            this.lblNomeUtilizador.ForeColor = System.Drawing.Color.White;
            this.lblNomeUtilizador.Location = new System.Drawing.Point(21, 88);
            this.lblNomeUtilizador.Name = "lblNomeUtilizador";
            this.lblNomeUtilizador.Size = new System.Drawing.Size(94, 13);
            this.lblNomeUtilizador.TabIndex = 38;
            this.lblNomeUtilizador.Text = "Nome do utilizador";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.ForeColor = System.Drawing.Color.White;
            this.lblemail.Location = new System.Drawing.Point(21, 137);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(91, 13);
            this.lblemail.TabIndex = 39;
            this.lblemail.Text = "Email do utilizador";
            // 
            // Nif
            // 
            this.Nif.AutoSize = true;
            this.Nif.ForeColor = System.Drawing.Color.White;
            this.Nif.Location = new System.Drawing.Point(21, 183);
            this.Nif.Name = "Nif";
            this.Nif.Size = new System.Drawing.Size(24, 13);
            this.Nif.TabIndex = 40;
            this.Nif.Text = "NIF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(256, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Password";
            // 
            // Inseriralunos
            // 
            this.Inseriralunos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Inseriralunos.AutoSize = true;
            this.Inseriralunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inseriralunos.ForeColor = System.Drawing.Color.White;
            this.Inseriralunos.Location = new System.Drawing.Point(173, 9);
            this.Inseriralunos.Name = "Inseriralunos";
            this.Inseriralunos.Size = new System.Drawing.Size(187, 25);
            this.Inseriralunos.TabIndex = 44;
            this.Inseriralunos.Text = "Perfil do Utilizador";
            // 
            // btnSalvarPerfil
            // 
            this.btnSalvarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnSalvarPerfil.FlatAppearance.BorderSize = 0;
            this.btnSalvarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarPerfil.ForeColor = System.Drawing.Color.LightGray;
            this.btnSalvarPerfil.Location = new System.Drawing.Point(24, 320);
            this.btnSalvarPerfil.Name = "btnSalvarPerfil";
            this.btnSalvarPerfil.Size = new System.Drawing.Size(95, 40);
            this.btnSalvarPerfil.TabIndex = 45;
            this.btnSalvarPerfil.Text = "Salvar";
            this.btnSalvarPerfil.UseVisualStyleBackColor = false;
            this.btnSalvarPerfil.Click += new System.EventHandler(this.btnSalvarPerfil_Click);
            // 
            // btnCancelarPerfil
            // 
            this.btnCancelarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCancelarPerfil.FlatAppearance.BorderSize = 0;
            this.btnCancelarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPerfil.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelarPerfil.Location = new System.Drawing.Point(363, 320);
            this.btnCancelarPerfil.Name = "btnCancelarPerfil";
            this.btnCancelarPerfil.Size = new System.Drawing.Size(95, 40);
            this.btnCancelarPerfil.TabIndex = 46;
            this.btnCancelarPerfil.Text = "Cancelar";
            this.btnCancelarPerfil.UseVisualStyleBackColor = false;
            // 
            // txtdtnasc
            // 
            this.txtdtnasc.Location = new System.Drawing.Point(259, 107);
            this.txtdtnasc.Name = "txtdtnasc";
            this.txtdtnasc.ReadOnly = true;
            this.txtdtnasc.Size = new System.Drawing.Size(199, 20);
            this.txtdtnasc.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(256, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Data de Nascimento";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(259, 153);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.ReadOnly = true;
            this.txtCurso.Size = new System.Drawing.Size(199, 20);
            this.txtCurso.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(256, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Curso";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(259, 199);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(199, 20);
            this.txtArea.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(256, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Area";
            // 
            // txtNprocesso
            // 
            this.txtNprocesso.Location = new System.Drawing.Point(24, 243);
            this.txtNprocesso.Name = "txtNprocesso";
            this.txtNprocesso.ReadOnly = true;
            this.txtNprocesso.Size = new System.Drawing.Size(199, 20);
            this.txtNprocesso.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Numero Processo";
            // 
            // FormPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNprocesso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdtnasc);
            this.Controls.Add(this.btnCancelarPerfil);
            this.Controls.Add(this.btnSalvarPerfil);
            this.Controls.Add(this.Inseriralunos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Nif);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblNomeUtilizador);
            this.Controls.Add(this.txtAlterPassword);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.txtNpNi);
            this.Controls.Add(this.txtEmailUtilizador);
            this.Controls.Add(this.txtNomeUtilizador);
            this.Name = "FormPerfil";
            this.Text = "FormPerfil";
            this.Load += new System.EventHandler(this.FormPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeUtilizador;
        private System.Windows.Forms.TextBox txtEmailUtilizador;
        private System.Windows.Forms.TextBox txtNpNi;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.TextBox txtAlterPassword;
        private System.Windows.Forms.Label lblNomeUtilizador;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label Nif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Inseriralunos;
        private System.Windows.Forms.Button btnSalvarPerfil;
        private System.Windows.Forms.Button btnCancelarPerfil;
        private System.Windows.Forms.TextBox txtdtnasc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNprocesso;
        private System.Windows.Forms.Label label4;
    }
}