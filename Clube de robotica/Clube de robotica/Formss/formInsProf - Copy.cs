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
    public partial class formInsProf : Form
    {


        public formInsProf()
        {
            InitializeComponent();
            showdata();
        }


        public void showdata()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from utilizador where Administrador = 1";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataProf.DataSource = dt;
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceitarProf_Click(object sender, EventArgs e)
        {
            if (txtnomeprof.Text != "" && txtNIF.Text != "" && txtEmailProf.Text != "" && txtArea.Text != "" && dtNascProf.Text != "")
            {
                insert();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        public void insert()
        {
            SqlCommand com = new SqlCommand();
            connection connection = new connection();





            com.CommandText = @"INSERT INTO utilizador ( Nome, NIF, Data_Nascimento, area, Email, administrador) values (@nome, @nif, @DataNasc, @area, @email, 1)";
            com.Parameters.AddWithValue("@nome", txtnomeprof.Text);
            com.Parameters.AddWithValue("@nif", txtNIF.Text);
            com.Parameters.AddWithValue("@DataNasc", DateTime.Parse(dtNascProf.Text));
            com.Parameters.AddWithValue("@area", txtArea.Text);
            com.Parameters.AddWithValue("@email", txtEmailProf.Text);


            connection.CRUD(com);
            showdata();
            
            MessageBox.Show("Professor inserido com sucesso");
        }



        private void formInsProf_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mostrarUtilizadoresDataSet.utilizador' table. You can move, or remove it, as needed.
            this.utilizadorTableAdapter.Fill(this.mostrarUtilizadoresDataSet.utilizador);


        }
    }
}
