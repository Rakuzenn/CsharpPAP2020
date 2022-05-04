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
    public partial class formInsAluEve : Form
    {
        public formInsAluEve()
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



        public void showdataAlu()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"SELECT user_eventos.ID_evento, utilizador.Nome, eventos.Nome_evento FROM ((user_eventos INNER JOIN utilizador ON user_eventos.UserID = utilizador.UserID) INNER JOIN eventos ON user_eventos.ID_evento = eventos.ID_evento) where utilizador.UserID = '" + lbluserNameAlu.Text + "'";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataEveAlu.DataSource = dt;
        }
      

        private void cbalu_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbluserNameAlu.Text = cbalu.SelectedValue.ToString();
            showdataAlu();
        }

        private void btnAddAluEve_Click(object sender, EventArgs e)
        {
            formAluInsEve myForm = new formAluInsEve();
            this.Show();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
