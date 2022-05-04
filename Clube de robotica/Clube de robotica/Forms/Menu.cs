using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clube_de_robotica
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            CostumizeDesign();
        }
        
        private void CostumizeDesign()
        {
            gerirSubMenu.Visible = false;
            eventosSubMenu.Visible = false;
            projectosSubMenu.Visible = false;

        }

        private void hideSubMenu()
        {
            if (gerirSubMenu.Visible == true)
                gerirSubMenu.Visible = false;
            if (eventosSubMenu.Visible == true)
                eventosSubMenu.Visible = false;
            if (projectosSubMenu.Visible == true)
                projectosSubMenu.Visible = false;
        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }        

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        #region Gerir


        private void btnGerir_Click(object sender, EventArgs e)
        {
            showSubMenu(gerirSubMenu);
        }

        private void btnGerirAlunos_Click(object sender, EventArgs e)
        {
            openChildForm(new formInsAlu());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnGerirProfessores_Click(object sender, EventArgs e)
        {
            openChildForm(new formInsProf());
            //..
            //Your codes
            //..
            hideSubMenu();
        }


        #endregion

        #region Projectos


        private void btnProjectos_Click(object sender, EventArgs e)
        {
            showSubMenu(projectosSubMenu);
        }

        private void btnAlunosProjectos_Click(object sender, EventArgs e)
        {
            
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnProfProjectos_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

         private void btnAddProj_Click(object sender, EventArgs e)
        {
            openChildForm(new formInsProj());
            //..
            //Your codes
            //..
            hideSubMenu();
        }


        #endregion

        #region Eventos


        private void btnEventos_Click(object sender, EventArgs e)
        {
            showSubMenu(eventosSubMenu);
        }

        private void btnAlunosEventos_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnProfEventos_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }


        #endregion

        #region Ajuda


        private void btnAjuda_Click(object sender, EventArgs e)
        {
            openChildForm(new ajuda());
            //..
            //Your codes
            //..
            hideSubMenu();
        }


        #endregion

        #region Sobre


        private void btnSobre_Click(object sender, EventArgs e)
        {

            openChildForm(new sobre());
            //..
            //Your codes
            //..
            hideSubMenu();
        }


        #endregion

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

       
    }
}
