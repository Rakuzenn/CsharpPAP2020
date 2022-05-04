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
    public partial class formAluInsEve : Form
    {
        public formAluInsEve()
        {
            InitializeComponent();
            showdataProj();
            showdatacomboAlu();
        }

        private void formAluInsEve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mostrarEventoDataSet.eventos' table. You can move, or remove it, as needed.
            this.eventosTableAdapter.Fill(this.mostrarEventoDataSet.eventos);

        }

        private void showdatacomboAlu()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from utilizador where Administrador = 0";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);


            //Insert the Default Item to DataTable.
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[4] = "Please select";
            dt.Rows.InsertAt(row, 0);

            //Assign DataTable as DataSource.
            cbalu.ValueMember = "UserID";

            cbalu.DisplayMember = "Nome";

            cbalu.DataSource = dt;

        }

        public void showdataProj()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from eventos";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataEve.DataSource = dt;
        }

        private void DataProj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataEve.Rows[e.RowIndex];
                eveid.Text = row.Cells[0].Value.ToString();

            }
        }

        private void cbalu_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbluserNameAlu.Text = cbalu.SelectedValue.ToString();

        }

        public void insert()
        {
            SqlCommand com = new SqlCommand();
            connection connection = new connection();

            com.CommandText = @"INSERT INTO user_eventos ( UserID, ID_evento, Data_entrada) values (@userid, @eveid, @dataen)";
            com.Parameters.AddWithValue("@userid", lbluserNameAlu.Text);
            com.Parameters.AddWithValue("@eveid", eveid.Text);
            SqlParameter sqlParameter = com.Parameters.AddWithValue("@dataen", DateTime.Now.ToString("M/d/yyyy"));


            connection.CRUD(com);

            MessageBox.Show("Aluno inserido com sucesso");
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
