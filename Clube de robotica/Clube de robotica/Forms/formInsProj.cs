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


namespace Clube_de_robotica
{
    public partial class formInsProj : Form
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source = B07-PC03; Initial Catalog = Clube_informatica; Integrated Security = True");
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand com;

        public formInsProj()
        {
            InitializeComponent();
        }

        public void showdata()
        {
            adpt = new SqlDataAdapter("select * from projectos", sqlcon);
            dt = new DataTable();
            adpt.Fill(dt);
            DataProj.DataSource = dt;
        }

        private void btnAceitarProj_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            //Cria conexao sql
            SqlConnection sqlcon = new SqlConnection(@"Data Source = B07-PC03; Initial Catalog = Clube_informatica; Integrated Security = True");
            sqlcon.Open();

            com.Connection = sqlcon;
            com.CommandText = @"INSERT INTO projectos ( Nome, Data_Inicio, Data_Fim, Descricao) values (@nome, @dtIn, @dtFim, @desc )";
            com.Parameters.AddWithValue("@nome", txtNomeProj.Text);
            com.Parameters.AddWithValue("@desc", txtDesc.Text);
            com.Parameters.AddWithValue("@dtIn", DateTime.Parse(dtIn.Text));
            com.Parameters.AddWithValue("@dtFim", DateTime.Parse(dtFim.Text));


            com.ExecuteNonQuery();
            showdata();
            sqlcon.Close();
            MessageBox.Show("Projecto inserido com sucesso");
        }

        private void formInsProj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clube_informaticaDataSet1.projectos' table. You can move, or remove it, as needed.
            this.projectosTableAdapter.Fill(this.clube_informaticaDataSet1.projectos);

        }
    }
}
