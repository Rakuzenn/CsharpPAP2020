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
    public partial class formInsAlu : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source = B07-PC03; Initial Catalog = Clube_informatica; Integrated Security = True");
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand com;
        public formInsAlu()
        {
            InitializeComponent();
            showdata();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void showdata()
        {
            adpt = new SqlDataAdapter("select * from utilizador", sqlcon);
            dt = new DataTable();
            adpt.Fill(dt);
            DataAlunos.DataSource = dt;
        }

        private void btnAceitarAlu_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            //Cria conexao sql
            SqlConnection sqlcon = new SqlConnection(@"Data Source = B07-PC03; Initial Catalog = Clube_informatica; Integrated Security = True");
            sqlcon.Open();

            com.Connection = sqlcon;
            com.CommandText = @"INSERT INTO utilizador ( Nome, NProcesso, Data_Nascimento, Curso, Email) values (@nome, @nprocesso, @DataNasc, @curso, @email )";
            com.Parameters.AddWithValue("@nome", txtNomeAlu.Text);
            com.Parameters.AddWithValue("@nprocesso", txtNProc.Text);
            com.Parameters.AddWithValue("@DataNasc", DateTime.Parse(dtNascAlu.Text));
            com.Parameters.AddWithValue("@curso", txtCurso.Text);
            com.Parameters.AddWithValue("@email", txtEmailAlu.Text);
            

            com.ExecuteNonQuery();
            showdata();
            sqlcon.Close();
            MessageBox.Show("Aluno inserido com sucesso");
        }

        private void formInsAlu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clube_informaticaDataSet.utilizador' table. You can move, or remove it, as needed.
            this.utilizadorTableAdapter.Fill(this.clube_informaticaDataSet.utilizador);

        }
    }
}
