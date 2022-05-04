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
    public partial class formInsProfEve : Form
    {
        public formInsProfEve()
        {
            InitializeComponent();
            showdatacomboProf();
            showdataProf();
        }

        private void showdatacomboProf()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from utilizador where Administrador = 1";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);


            //Insert the Default Item to DataTable.
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[4] = "Please select";
            dt.Rows.InsertAt(row, 0);

            //Assign DataTable as DataSource.
            cbprof.ValueMember = "UserID";

            cbprof.DisplayMember = "Nome";

            cbprof.DataSource = dt;

        }



        public void showdataProf()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"SELECT user_eventos.ID_evento, eventos.Nome_evento, eventos.local_evento, eventos.    FROM ((user_eventos INNER JOIN utilizador ON user_eventos.UserID = utilizador.UserID) INNER JOIN eventos ON user_eventos.ID_evento = eventos.ID_evento) where utilizador.UserID = '" + lbluserNameAlu.Text + "'";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataEveProf.DataSource = dt;
        }

        private void cbprof_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbluserNameAlu.Text = cbprof.SelectedValue.ToString();
            showdataProf();
        }

        private void btnAddProfEve_Click(object sender, EventArgs e)
        {
            formProfInsEve myForm = new formProfInsEve();
            this.Show();
            myForm.ShowDialog();
            this.Close();
        }

        private void formInsProfEve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mostrarEventosUtilizadorDataSet.eventos' table. You can move, or remove it, as needed.
            this.eventosTableAdapter.Fill(this.mostrarEventosUtilizadorDataSet.eventos);

        }
    }
}
