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
    public partial class formInsEve : Form
    {


        public formInsEve()
        {
            InitializeComponent();
            showdata();

        }


        public void showdata()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from eventos";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataEve.DataSource = dt;
        }




        private void formInsEve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventosDataSet.eventos' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet_Eventos.eventos' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet_Eventos.eventos' table. You can move, or remove it, as needed.




        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEve_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != "" && txtNomeEve.Text != "" && txtlocal.Text != "" && dtrez.Text != "")
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
            try
            {
                SqlCommand com = new SqlCommand();
                connection connection = new connection();


                com.CommandText = @"INSERT INTO eventos ( Nome_evento, local_evento , Data_evento, descricao) values (@nome, @local,@dtrez, @desc )";
                com.Parameters.AddWithValue("@nome", txtNomeEve.Text);
                com.Parameters.AddWithValue("@desc", txtDesc.Text);
                com.Parameters.AddWithValue("@local", txtlocal.Text);
                com.Parameters.AddWithValue("@dtrez", DateTime.Parse(dtrez.Text));

                connection.CRUD(com);


                showdata();

                MessageBox.Show("Evento inserido com sucesso");
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
