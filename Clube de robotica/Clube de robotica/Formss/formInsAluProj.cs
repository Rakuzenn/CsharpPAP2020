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
using Clube_de_robotica.DAO;


namespace Clube_de_robotica
{
    public partial class formInsAluProj : Form
    {

        private string projid;

        public formInsAluProj()
        {
            InitializeComponent();
            showdatacomboAlu();
            showdataAlu();
        }


        private void showdatacomboAlu()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from utilizador where Administrador = 0";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);


         

            //Assign DataTable as DataSource.
            cbmat.ValueMember = "UserID";

            cbmat.DisplayMember = "Nome";
         
            cbmat.DataSource = dt;
          
        }

        public void showdataAlu()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"SELECT user_projectos.ID_projecto, projectos.Nome, projectos.Data_inicio, projectos.Data_fim , projectos.descricao  FROM ((user_projectos INNER JOIN utilizador ON user_projectos.UserID = utilizador.UserID) INNER JOIN projectos ON user_projectos.ID_projecto = projectos.ID_projecto) where utilizador.UserID = '" + projid  + "'";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataProjAlu.DataSource = dt;
        }

        private void formInsAluProj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Proj.projectos' table. You can move, or remove it, as needed.
            

        }

        private void cbalu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID id = new ID();
            id.IDs = cbmat.SelectedValue.ToString();
            projid = id.IDs;
            showdataAlu();
        }

        private void btnAddAluProj_Click(object sender, EventArgs e)
        {
            formAluInsProj myForm = new formAluInsProj();
            this.Show();
            myForm.ShowDialog();
            this.Close();

        }

        private void btnAddAluProj_Click_1(object sender, EventArgs e)
        {
            formAluInsProj myForm = new formAluInsProj();
            this.Show();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
