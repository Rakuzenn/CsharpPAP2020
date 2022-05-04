using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Clube_de_robotica;
using Clube_de_robotica.Formss;
using Clube_de_robotica.DAO;


namespace Clube_de_robotica
{

    public partial class Menu : Form
    {
     
      

        public Menu()
        {
            InitializeComponent();
            CostumizeDesign();
         
            checkadmin();
        }
        
        private void CostumizeDesign()
        {
            gerirSubMenu.Visible = false;
            eventosSubMenu.Visible = false;
            projectosSubMenu.Visible = false;

        }

        public void checkadmin()
        {
            if (txtIsAdmin.Text == Convert.ToString(1))
            {
                AdminSubMenu.Visible = true;
            }
            else
            {
                AdminSubMenu.Visible = false;
            }
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

        public void Form1_Load(object sender, EventArgs e)
        {
            txtadmincheck.Text = Login.setvalueforadmincheck;

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select Administrador from utilizador where NProcesso =  @NProcesso or NIF = @nif ";
            command.Parameters.AddWithValue("@NProcesso", txtadmincheck.Text);
            command.Parameters.AddWithValue("@nif", txtadmincheck.Text);
            connection connection = new connection();
            connection.CRUD(command);
            SqlDataReader dr = connection.Select(command);

            if(dr.HasRows)
            {
                if(dr.Read())
                {
                    txtIsAdmin.Text = dr["Administrador"].ToString();
                    checkadmin();
                }
            }
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

        private void btnProjectos_Click_1(object sender, EventArgs e)
        {
            showSubMenu(projectosSubMenu);
        }

        private void btnAlunosProjectos_Click(object sender, EventArgs e)
        {
            openChildForm(new formInsAluProj());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnProfProjectos_Click(object sender, EventArgs e)
        {
            openChildForm(new formInsProfProj());
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

        private void btnEventos_Click_1(object sender, EventArgs e)
        {
            showSubMenu(eventosSubMenu);
        }
     

        private void btnAlunosEventos_Click(object sender, EventArgs e)
        {
            openChildForm(new formInsAluEve());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnProfEventos_Click(object sender, EventArgs e)
        {
            openChildForm(new formInsProfEve());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnAddEv_Click(object sender, EventArgs e)
        {
            openChildForm(new formInsEve());
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

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {

        }

        private void txtadmincheck_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void btnPerfil_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormPerfil());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnConsProj_Click(object sender, EventArgs e)
        {
            openChildForm(new formConsulta());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            openChildForm(new formAddProjEve());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnMat_Click(object sender, EventArgs e)
        {
            openChildForm(new formInsMat());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnAddMatProj_Click(object sender, EventArgs e)
        {
            openChildForm(new formInsMatProj());
            //..
            //Your codes
            //..
            hideSubMenu();
        }
    }

  
}
