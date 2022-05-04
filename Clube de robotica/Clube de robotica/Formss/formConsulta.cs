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
            // TODO: This line of code loads data into the 'eventosDataSet.eventos' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'projectosDataSet.projectos' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet_Eventos.eventos' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dataSet_Eventos.eventos' table. You can move, or remove it, as needed.

            lblVal.Text = Login.setvalueforadmincheck;
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select UserID from utilizador where NProcesso =  @NProcesso or NIF = @nif ";
                command.Parameters.AddWithValue("@NProcesso", lblVal.Text);
                command.Parameters.AddWithValue("@nif", lblVal.Text);
                connection connection = new connection();
                connection.CRUD(command);
                SqlDataReader dr = connection.Select(command);
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            lblID.Text = dr["UserID"].ToString();
                        }
                    }
            showdataProj();
            showdataEve();
        }

       
        
        public formConsulta()
        {
            InitializeComponent();
        }
        public void showdataProj()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"SELECT user_projectos.ID_projecto, projectos.Nome, projectos.Data_inicio, projectos.Data_fim , projectos.descricao  FROM ((user_projectos INNER JOIN utilizador ON user_projectos.UserID = utilizador.UserID) INNER JOIN projectos ON user_projectos.ID_projecto = projectos.ID_projecto) where utilizador.UserID ='" + lblID.Text + "'";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataProj.DataSource = dt;
        } 
        public void showdataEve()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"SELECT user_eventos.ID_evento, eventos.Nome_evento, eventos.Data_evento, eventos.local_evento, eventos.descricao FROM ((user_eventos INNER JOIN utilizador ON user_eventos.UserID = utilizador.UserID) INNER JOIN eventos ON user_eventos.ID_evento = eventos.ID_evento) where utilizador.UserID = '" + lblID.Text + "'";
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

        private void DataProj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
