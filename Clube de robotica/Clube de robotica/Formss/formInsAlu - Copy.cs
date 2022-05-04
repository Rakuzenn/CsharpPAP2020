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
    public partial class formInsAlu : Form
    {
        
      
       
        public formInsAlu()
        {
            InitializeComponent();
            showdata();
            
            ;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void showdata()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from utilizador where Administrador = 0";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataAlunos.DataSource = dt;
        }

        private void btnAceitarAlu_Click(object sender, EventArgs e)
        {
            if (txtNomeAlu.Text != "" && txtCurso.Text != "" && txtEmailAlu.Text != "" && txtNProc.Text != "" && dtNascAlu.Text != "")
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
            
            com.CommandText = @"INSERT INTO utilizador ( Nome, NProcesso, Data_Nascimento, Curso, Email, administrador) values (@nome, @nprocesso, @DataNasc, @curso, @email, 0 )";
            com.Parameters.AddWithValue("@nome", txtNomeAlu.Text);
            com.Parameters.AddWithValue("@nprocesso", txtNProc.Text);
            com.Parameters.AddWithValue("@DataNasc", DateTime.Parse(dtNascAlu.Text));
            com.Parameters.AddWithValue("@curso", txtCurso.Text);
            com.Parameters.AddWithValue("@email", txtEmailAlu.Text);

            connection.CRUD(com);

            showdata();
            MessageBox.Show("Aluno inserido com sucesso");
        }

        private void DataAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
