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
    public partial class formInsProj : Form
    {
      

        public formInsProj()
        {
            InitializeComponent();
            showdata();
        }

        public void showdata()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from projectos";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataProj.DataSource = dt;
        }

        private void btnAceitarProj_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != "" && txtNomeProj.Text != "" && dtFim.Text != "" && dtIn.Text != "")
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

            
            com.CommandText = @"INSERT INTO projectos ( Nome, Data_Inicio, Data_Fim, Descricao) values (@nome, @dtIn, @dtFim, @desc )";
            com.Parameters.AddWithValue("@nome", txtNomeProj.Text);
            com.Parameters.AddWithValue("@desc", txtDesc.Text);
            com.Parameters.AddWithValue("@dtIn", DateTime.Parse(dtIn.Text));
            com.Parameters.AddWithValue("@dtFim", DateTime.Parse(dtFim.Text));

            connection.CRUD(com);
            
            showdata();
            
            MessageBox.Show("Projecto inserido com sucesso");
        }


        private void formInsProj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mostrarProjectosDataSet.projectos' table. You can move, or remove it, as needed.
            this.projectosTableAdapter.Fill(this.mostrarProjectosDataSet.projectos);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
