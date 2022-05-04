namespace Clube_de_robotica
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.SideMenu = new System.Windows.Forms.Panel();
            this.AdminSubMenu = new System.Windows.Forms.Panel();
            this.eventosSubMenu = new System.Windows.Forms.Panel();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnAddEv = new System.Windows.Forms.Button();
            this.btnProfEventos = new System.Windows.Forms.Button();
            this.btnAlunosEventos = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.projectosSubMenu = new System.Windows.Forms.Panel();
            this.btnAddMatProj = new System.Windows.Forms.Button();
            this.btnAddProj = new System.Windows.Forms.Button();
            this.btnProfProjectos = new System.Windows.Forms.Button();
            this.btnAlunosProjectos = new System.Windows.Forms.Button();
            this.btnProjectos = new System.Windows.Forms.Button();
            this.gerirSubMenu = new System.Windows.Forms.Panel();
            this.btnMat = new System.Windows.Forms.Button();
            this.btnGerirProfessores = new System.Windows.Forms.Button();
            this.btnGerirAlunos = new System.Windows.Forms.Button();
            this.btnGerir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsProj = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.SideMenuLogo = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtadmincheck = new System.Windows.Forms.TextBox();
            this.txtIsAdmin = new System.Windows.Forms.TextBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.SideMenu.SuspendLayout();
            this.AdminSubMenu.SuspendLayout();
            this.eventosSubMenu.SuspendLayout();
            this.projectosSubMenu.SuspendLayout();
            this.gerirSubMenu.SuspendLayout();
            this.SideMenuLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenu
            // 
            this.SideMenu.AutoScroll = true;
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SideMenu.Controls.Add(this.AdminSubMenu);
            this.SideMenu.Controls.Add(this.btnSair);
            this.SideMenu.Controls.Add(this.btnConsProj);
            this.SideMenu.Controls.Add(this.btnPerfil);
            this.SideMenu.Controls.Add(this.SideMenuLogo);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(250, 676);
            this.SideMenu.TabIndex = 0;
            // 
            // AdminSubMenu
            // 
            this.AdminSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.AdminSubMenu.Controls.Add(this.eventosSubMenu);
            this.AdminSubMenu.Controls.Add(this.btnEventos);
            this.AdminSubMenu.Controls.Add(this.projectosSubMenu);
            this.AdminSubMenu.Controls.Add(this.btnProjectos);
            this.AdminSubMenu.Controls.Add(this.gerirSubMenu);
            this.AdminSubMenu.Controls.Add(this.btnGerir);
            this.AdminSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminSubMenu.Location = new System.Drawing.Point(0, 180);
            this.AdminSubMenu.Name = "AdminSubMenu";
            this.AdminSubMenu.Size = new System.Drawing.Size(250, 374);
            this.AdminSubMenu.TabIndex = 14;
            // 
            // eventosSubMenu
            // 
            this.eventosSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.eventosSubMenu.Controls.Add(this.btnAddProject);
            this.eventosSubMenu.Controls.Add(this.btnAddEv);
            this.eventosSubMenu.Controls.Add(this.btnProfEventos);
            this.eventosSubMenu.Controls.Add(this.btnAlunosEventos);
            this.eventosSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventosSubMenu.Location = new System.Drawing.Point(0, 414);
            this.eventosSubMenu.Name = "eventosSubMenu";
            this.eventosSubMenu.Size = new System.Drawing.Size(250, 179);
            this.eventosSubMenu.TabIndex = 13;
            // 
            // btnAddProject
            // 
            this.btnAddProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddProject.FlatAppearance.BorderSize = 0;
            this.btnAddProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProject.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProject.Location = new System.Drawing.Point(0, 120);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddProject.Size = new System.Drawing.Size(250, 40);
            this.btnAddProject.TabIndex = 5;
            this.btnAddProject.Text = "Adicionar Projectos";
            this.btnAddProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnAddEv
            // 
            this.btnAddEv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEv.FlatAppearance.BorderSize = 0;
            this.btnAddEv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEv.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddEv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEv.Location = new System.Drawing.Point(0, 80);
            this.btnAddEv.Name = "btnAddEv";
            this.btnAddEv.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddEv.Size = new System.Drawing.Size(250, 40);
            this.btnAddEv.TabIndex = 4;
            this.btnAddEv.Text = "Adicionar Eventos";
            this.btnAddEv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEv.UseVisualStyleBackColor = true;
            this.btnAddEv.Click += new System.EventHandler(this.btnAddEv_Click);
            // 
            // btnProfEventos
            // 
            this.btnProfEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfEventos.FlatAppearance.BorderSize = 0;
            this.btnProfEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfEventos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProfEventos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfEventos.Location = new System.Drawing.Point(0, 40);
            this.btnProfEventos.Name = "btnProfEventos";
            this.btnProfEventos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProfEventos.Size = new System.Drawing.Size(250, 40);
            this.btnProfEventos.TabIndex = 3;
            this.btnProfEventos.Text = "Adicionar Professores a eventos";
            this.btnProfEventos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfEventos.UseVisualStyleBackColor = true;
            this.btnProfEventos.Click += new System.EventHandler(this.btnProfEventos_Click);
            // 
            // btnAlunosEventos
            // 
            this.btnAlunosEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlunosEventos.FlatAppearance.BorderSize = 0;
            this.btnAlunosEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlunosEventos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAlunosEventos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlunosEventos.Location = new System.Drawing.Point(0, 0);
            this.btnAlunosEventos.Name = "btnAlunosEventos";
            this.btnAlunosEventos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAlunosEventos.Size = new System.Drawing.Size(250, 40);
            this.btnAlunosEventos.TabIndex = 2;
            this.btnAlunosEventos.Text = "Adicionar Alunos a eventos";
            this.btnAlunosEventos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlunosEventos.UseVisualStyleBackColor = true;
            this.btnAlunosEventos.Click += new System.EventHandler(this.btnAlunosEventos_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEventos.FlatAppearance.BorderSize = 0;
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEventos.Image = ((System.Drawing.Image)(resources.GetObject("btnEventos.Image")));
            this.btnEventos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventos.Location = new System.Drawing.Point(0, 374);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEventos.Size = new System.Drawing.Size(250, 40);
            this.btnEventos.TabIndex = 12;
            this.btnEventos.Text = "Gerir Eventos";
            this.btnEventos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEventos.UseVisualStyleBackColor = false;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click_1);
            // 
            // projectosSubMenu
            // 
            this.projectosSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.projectosSubMenu.Controls.Add(this.btnAddMatProj);
            this.projectosSubMenu.Controls.Add(this.btnAddProj);
            this.projectosSubMenu.Controls.Add(this.btnProfProjectos);
            this.projectosSubMenu.Controls.Add(this.btnAlunosProjectos);
            this.projectosSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectosSubMenu.Location = new System.Drawing.Point(0, 211);
            this.projectosSubMenu.Name = "projectosSubMenu";
            this.projectosSubMenu.Size = new System.Drawing.Size(250, 163);
            this.projectosSubMenu.TabIndex = 11;
            // 
            // btnAddMatProj
            // 
            this.btnAddMatProj.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMatProj.FlatAppearance.BorderSize = 0;
            this.btnAddMatProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMatProj.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddMatProj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMatProj.Location = new System.Drawing.Point(0, 120);
            this.btnAddMatProj.Name = "btnAddMatProj";
            this.btnAddMatProj.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddMatProj.Size = new System.Drawing.Size(250, 40);
            this.btnAddMatProj.TabIndex = 5;
            this.btnAddMatProj.Text = "Adicionar Materiais";
            this.btnAddMatProj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMatProj.UseVisualStyleBackColor = true;
            this.btnAddMatProj.Click += new System.EventHandler(this.btnAddMatProj_Click);
            // 
            // btnAddProj
            // 
            this.btnAddProj.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddProj.FlatAppearance.BorderSize = 0;
            this.btnAddProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProj.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddProj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProj.Location = new System.Drawing.Point(0, 80);
            this.btnAddProj.Name = "btnAddProj";
            this.btnAddProj.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddProj.Size = new System.Drawing.Size(250, 40);
            this.btnAddProj.TabIndex = 4;
            this.btnAddProj.Text = "Adicionar Projectos";
            this.btnAddProj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProj.UseVisualStyleBackColor = true;
            this.btnAddProj.Click += new System.EventHandler(this.btnAddProj_Click);
            // 
            // btnProfProjectos
            // 
            this.btnProfProjectos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfProjectos.FlatAppearance.BorderSize = 0;
            this.btnProfProjectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfProjectos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProfProjectos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfProjectos.Location = new System.Drawing.Point(0, 40);
            this.btnProfProjectos.Name = "btnProfProjectos";
            this.btnProfProjectos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProfProjectos.Size = new System.Drawing.Size(250, 40);
            this.btnProfProjectos.TabIndex = 3;
            this.btnProfProjectos.Text = "Adicionar Professores a projectos\r\n";
            this.btnProfProjectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfProjectos.UseVisualStyleBackColor = true;
            this.btnProfProjectos.Click += new System.EventHandler(this.btnProfProjectos_Click);
            // 
            // btnAlunosProjectos
            // 
            this.btnAlunosProjectos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlunosProjectos.FlatAppearance.BorderSize = 0;
            this.btnAlunosProjectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlunosProjectos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAlunosProjectos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlunosProjectos.Location = new System.Drawing.Point(0, 0);
            this.btnAlunosProjectos.Name = "btnAlunosProjectos";
            this.btnAlunosProjectos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAlunosProjectos.Size = new System.Drawing.Size(250, 40);
            this.btnAlunosProjectos.TabIndex = 2;
            this.btnAlunosProjectos.Text = "Adicionar Alunos a projectos";
            this.btnAlunosProjectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlunosProjectos.UseVisualStyleBackColor = true;
            this.btnAlunosProjectos.Click += new System.EventHandler(this.btnAlunosProjectos_Click);
            // 
            // btnProjectos
            // 
            this.btnProjectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnProjectos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjectos.FlatAppearance.BorderSize = 0;
            this.btnProjectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjectos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProjectos.Image = ((System.Drawing.Image)(resources.GetObject("btnProjectos.Image")));
            this.btnProjectos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjectos.Location = new System.Drawing.Point(0, 171);
            this.btnProjectos.Name = "btnProjectos";
            this.btnProjectos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProjectos.Size = new System.Drawing.Size(250, 40);
            this.btnProjectos.TabIndex = 10;
            this.btnProjectos.Text = "Gerir Projectos";
            this.btnProjectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjectos.UseVisualStyleBackColor = false;
            this.btnProjectos.Click += new System.EventHandler(this.btnProjectos_Click_1);
            // 
            // gerirSubMenu
            // 
            this.gerirSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.gerirSubMenu.Controls.Add(this.btnMat);
            this.gerirSubMenu.Controls.Add(this.btnGerirProfessores);
            this.gerirSubMenu.Controls.Add(this.btnGerirAlunos);
            this.gerirSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gerirSubMenu.Location = new System.Drawing.Point(0, 40);
            this.gerirSubMenu.Name = "gerirSubMenu";
            this.gerirSubMenu.Size = new System.Drawing.Size(250, 131);
            this.gerirSubMenu.TabIndex = 2;
            // 
            // btnMat
            // 
            this.btnMat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMat.FlatAppearance.BorderSize = 0;
            this.btnMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMat.Location = new System.Drawing.Point(0, 80);
            this.btnMat.Name = "btnMat";
            this.btnMat.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMat.Size = new System.Drawing.Size(250, 40);
            this.btnMat.TabIndex = 4;
            this.btnMat.Text = "Gerir Materiais";
            this.btnMat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMat.UseVisualStyleBackColor = true;
            this.btnMat.Click += new System.EventHandler(this.btnMat_Click);
            // 
            // btnGerirProfessores
            // 
            this.btnGerirProfessores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerirProfessores.FlatAppearance.BorderSize = 0;
            this.btnGerirProfessores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerirProfessores.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGerirProfessores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerirProfessores.Location = new System.Drawing.Point(0, 40);
            this.btnGerirProfessores.Name = "btnGerirProfessores";
            this.btnGerirProfessores.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGerirProfessores.Size = new System.Drawing.Size(250, 40);
            this.btnGerirProfessores.TabIndex = 3;
            this.btnGerirProfessores.Text = "Gerir Professores";
            this.btnGerirProfessores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerirProfessores.UseVisualStyleBackColor = true;
            this.btnGerirProfessores.Click += new System.EventHandler(this.btnGerirProfessores_Click);
            // 
            // btnGerirAlunos
            // 
            this.btnGerirAlunos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerirAlunos.FlatAppearance.BorderSize = 0;
            this.btnGerirAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerirAlunos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGerirAlunos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerirAlunos.Location = new System.Drawing.Point(0, 0);
            this.btnGerirAlunos.Name = "btnGerirAlunos";
            this.btnGerirAlunos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGerirAlunos.Size = new System.Drawing.Size(250, 40);
            this.btnGerirAlunos.TabIndex = 2;
            this.btnGerirAlunos.Text = "Gerir Alunos";
            this.btnGerirAlunos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerirAlunos.UseVisualStyleBackColor = true;
            this.btnGerirAlunos.Click += new System.EventHandler(this.btnGerirAlunos_Click);
            // 
            // btnGerir
            // 
            this.btnGerir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnGerir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerir.FlatAppearance.BorderSize = 0;
            this.btnGerir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGerir.Image = ((System.Drawing.Image)(resources.GetObject("btnGerir.Image")));
            this.btnGerir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerir.Location = new System.Drawing.Point(0, 0);
            this.btnGerir.Name = "btnGerir";
            this.btnGerir.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGerir.Size = new System.Drawing.Size(250, 40);
            this.btnGerir.TabIndex = 1;
            this.btnGerir.Text = "Gerir ";
            this.btnGerir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGerir.UseVisualStyleBackColor = false;
            this.btnGerir.Click += new System.EventHandler(this.btnGerir_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 636);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(250, 40);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConsProj
            // 
            this.btnConsProj.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsProj.FlatAppearance.BorderSize = 0;
            this.btnConsProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsProj.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConsProj.Image = ((System.Drawing.Image)(resources.GetObject("btnConsProj.Image")));
            this.btnConsProj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsProj.Location = new System.Drawing.Point(0, 140);
            this.btnConsProj.Name = "btnConsProj";
            this.btnConsProj.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConsProj.Size = new System.Drawing.Size(250, 40);
            this.btnConsProj.TabIndex = 4;
            this.btnConsProj.Text = "Consultar Projectos";
            this.btnConsProj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsProj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsProj.UseVisualStyleBackColor = true;
            this.btnConsProj.Click += new System.EventHandler(this.btnConsProj_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(0, 100);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPerfil.Size = new System.Drawing.Size(250, 40);
            this.btnPerfil.TabIndex = 3;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click_1);
            // 
            // SideMenuLogo
            // 
            this.SideMenuLogo.Controls.Add(this.imgLogo);
            this.SideMenuLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.SideMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.SideMenuLogo.Name = "SideMenuLogo";
            this.SideMenuLogo.Size = new System.Drawing.Size(250, 100);
            this.SideMenuLogo.TabIndex = 0;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.InitialImage = null;
            this.imgLogo.Location = new System.Drawing.Point(35, 15);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(159, 60);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtadmincheck
            // 
            this.txtadmincheck.Location = new System.Drawing.Point(27, 15);
            this.txtadmincheck.Name = "txtadmincheck";
            this.txtadmincheck.Size = new System.Drawing.Size(43, 22);
            this.txtadmincheck.TabIndex = 1;
            this.txtadmincheck.Visible = false;
            this.txtadmincheck.TextChanged += new System.EventHandler(this.txtadmincheck_TextChanged);
            // 
            // txtIsAdmin
            // 
            this.txtIsAdmin.Location = new System.Drawing.Point(27, 54);
            this.txtIsAdmin.Name = "txtIsAdmin";
            this.txtIsAdmin.Size = new System.Drawing.Size(43, 22);
            this.txtIsAdmin.TabIndex = 2;
            this.txtIsAdmin.Visible = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.txtIsAdmin);
            this.panelChildForm.Controls.Add(this.txtadmincheck);
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(650, 676);
            this.panelChildForm.TabIndex = 1;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 676);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.SideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Clube de programação APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SideMenu.ResumeLayout(false);
            this.AdminSubMenu.ResumeLayout(false);
            this.eventosSubMenu.ResumeLayout(false);
            this.projectosSubMenu.ResumeLayout(false);
            this.gerirSubMenu.ResumeLayout(false);
            this.SideMenuLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.Panel SideMenuLogo;
        private System.Windows.Forms.Panel gerirSubMenu;
        private System.Windows.Forms.Button btnGerirProfessores;
        private System.Windows.Forms.Button btnGerirAlunos;
        private System.Windows.Forms.Button btnGerir;
        private System.Windows.Forms.Button btnProfProjectos;
        private System.Windows.Forms.Button btnAlunosProjectos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAddProj;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnConsProj;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Panel projectosSubMenu;
        private System.Windows.Forms.Button btnProjectos;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Panel eventosSubMenu;
        private System.Windows.Forms.Button btnProfEventos;
        private System.Windows.Forms.Button btnAddEv;
        private System.Windows.Forms.Button btnAlunosEventos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtadmincheck;
        private System.Windows.Forms.TextBox txtIsAdmin;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel AdminSubMenu;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnMat;
        private System.Windows.Forms.Button btnAddMatProj;
    }
}

