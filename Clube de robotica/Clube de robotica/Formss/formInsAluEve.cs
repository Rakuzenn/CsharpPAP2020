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

        private string EventID;

        public formInsAluEve()
        {
            InitializeComponent();
            showdatacomboAlu();
            showdataAlu(null);
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
            cbalu.ValueMember = "UserID";

            cbalu.DisplayMember = "Nome";

            cbalu.DataSource = dt;

        }



        public void showdataAlu(string id)
        {

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"SELECT user_eventos.ID_evento, eventos.Nome_evento, eventos.Data_evento, eventos.local_evento, eventos.descricao FROM ((user_eventos INNER JOIN utilizador ON user_eventos.UserID = utilizador.UserID) INNER JOIN eventos ON user_eventos.ID_evento = eventos.ID_evento) where utilizador.UserID = '" + id + "'";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataEveAlu.DataSource = dt;
        }

       

        private void cbalu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                showdataAlu(cbalu.SelectedValue.ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o formulario! ----> " + ex.Message.ToString());
            }
        }
        
        

        
        private void btnAddAluEve_Click(object sender, EventArgs e)
        {
            formAluInsEve myForm = new formAluInsEve();
            this.Show();
            myForm.ShowDialog();
            this.Close();
        }

        private void formInsAluEve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventosDataSet.eventos' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet_Eventos.eventos' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet_Eventos.eventos' table. You can move, or remove it, as needed.

        }
    }
}
