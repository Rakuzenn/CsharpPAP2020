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
    public partial class formProfInsEve : Form
    {
        public formProfInsEve()
        {
            InitializeComponent();
            showdataProj();
            showdatacomboAlu();
        }

        private void showdatacomboAlu()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from utilizador where Administrador = 1";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);


           

            //Assign DataTable as DataSource.
            cbprof.ValueMember = "UserID";

            cbprof.DisplayMember = "Nome";

            cbprof.DataSource = dt;

        }
     

        public void showdataProj()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from eventos";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataProj.DataSource = dt;
        }

       


        public void insert()
        {
            SqlCommand com = new SqlCommand();
            connection connection = new connection();


            com.CommandText = @"SELECT * FROM user_projectos where UserID = '" + lbluserNameAlu.Text + "' AND ID_projecto ='" + eveid.Text + "'";
            SqlDataAdapter da = connection.Selectt(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Alunos ja está a inserido no evento");
            }
            else
            {

                com.CommandText = @"INSERT INTO user_eventos ( UserID, ID_evento, Data_entrada) values (@userid, @eveid, @dataen)";
                com.Parameters.AddWithValue("@userid", lbluserNameAlu.Text);
                com.Parameters.AddWithValue("@eveid", eveid.Text);
                SqlParameter sqlParameter = com.Parameters.AddWithValue("@dataen", DateTime.Now.ToString("M/d/yyyy"));


                connection.CRUD(com);

                MessageBox.Show("Aluno inserido com sucesso");
            }
        
    }


        private void formProfInsEve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventosDataSet.eventos' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet_Eventos.eventos' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet_Eventos.eventos' table. You can move, or remove it, as needed.



        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbprof_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lbluserNameAlu.Text = cbprof.SelectedValue.ToString();
        }

        private void DataProj_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataProj.Rows[e.RowIndex];
                eveid.Text = row.Cells[0].Value.ToString();
            }
        }

        private void DataProj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
