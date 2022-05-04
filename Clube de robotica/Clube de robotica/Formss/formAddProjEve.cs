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
using System.Net;
using System.Net.Mail;
using Clube_de_robotica.DAO;

namespace Clube_de_robotica.Formss
{
    public partial class formAddProjEve : Form
    {
        public formAddProjEve()
        {
            InitializeComponent();
            showdatacomboproj();
            showdataEvent();
        }

        private void showdatacomboproj()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from eventos";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);



            //Assign DataTable as DataSource.
            cbproj.ValueMember = "ID_evento";

            cbproj.DisplayMember = "Nome_Evento";

            cbproj.DataSource = dt;

        }

        public void showdataEvent()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"SELECT projectos_eventos.ID_projectos, projectos.Nome, projectos.Data_inicio, projectos.Data_fim , projectos.descricao  FROM ((projectos_eventos INNER JOIN eventos ON projectos_eventos.ID_eventos = eventos.ID_evento) INNER JOIN projectos ON projectos_eventos.ID_projectos = projectos.ID_projecto) where eventos.ID_evento ='" + eveid.Text + "'";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataEve.DataSource = dt;
        }

        private void formAddProjEve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectosDataSet.projectos' table. You can move, or remove it, as needed.

        }

        private void cbproj_SelectedIndexChanged(object sender, EventArgs e)
        {
            eveid.Text = cbproj.SelectedValue.ToString();
            showdataEvent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            formAddProjToEve myForm = new formAddProjToEve();
            this.Show();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
