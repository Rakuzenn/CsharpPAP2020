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

    public partial class formConsulta : Form
    {
        private void formConsulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mostrarEventoDataSet.eventos' table. You can move, or remove it, as needed.
            this.eventosTableAdapter.Fill(this.mostrarEventoDataSet.eventos);
            // TODO: This line of code loads data into the 'mostrarProjectosDataSet.projectos' table. You can move, or remove it, as needed.
            this.projectosTableAdapter.Fill(this.mostrarProjectosDataSet.projectos);
            lbluserNameAlu.Text = Login.setvalueforadmincheck;
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"SELECT UserID from utilizador where NProcesso or NIF = '" + lbluserNameAlu.Text + "'";
            SqlDataAdapter adpt = connection.Selectt(com);
            lblID.Text = com.ToString();
        }

        public formConsulta()
        {
            InitializeComponent();
            showdataProj();
            showdataEve();

        }
        public void showdataProj()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"SELECT user_projectos.ID_projecto, utilizador.Nome, projectos.Nome FROM ((user_projectos INNER JOIN utilizador ON user_projectos.UserID = utilizador.UserID) INNER JOIN projectos ON user_projectos.ID_projecto = projectos.ID_projecto) where utilizador.NProcesso = '" + lbluserNameAlu.Text + "'";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataProj.DataSource = dt;
        }
        public void showdataEve()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"SELECT user_eventos.ID_evento, utilizador.Nome, eventos.Nome_evento FROM ((user_eventos INNER JOIN utilizador ON user_eventos.UserID = utilizador.UserID) INNER JOIN eventos ON user_eventos.ID_evento = eventos.ID_evento) where utilizador.NProcesso = '" + lbluserNameAlu.Text + "'";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataEve.DataSource = dt;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Inseriralunos_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
