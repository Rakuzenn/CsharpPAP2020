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
    public partial class formAluInsProj : Form
    {
        public formAluInsProj()
        {
            InitializeComponent();
            showdataProj(); 
            showdatacomboAlu();
        }

        //private void datee()
        //{
        //    string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
        //    lbldate.Text = date;
        //}

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
            com.CommandText = @"select * from projectos";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataProj.DataSource = dt;
        }

       


       
        private void cbalu_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbluserNameAlu.Text = cbalu.SelectedValue.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataProj_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataProj.Rows[e.RowIndex];
                projid.Text = row.Cells[0].Value.ToString();

            }
        }

        public void insert()
        {
            SqlCommand com = new SqlCommand();
            connection connection = new connection();

            com.CommandText = @"INSERT INTO user_projectos ( UserID, ID_projecto, Data_entrada) values (@userid, @idproj, @dataen)";
            com.Parameters.AddWithValue("@userid", lbluserNameAlu.Text);
            com.Parameters.AddWithValue("@idproj", projid.Text);
            SqlParameter sqlParameter = com.Parameters.AddWithValue("@dataen", DateTime.Now.ToString("M/d/yyyy"));


            connection.CRUD(com);

            MessageBox.Show("Aluno inserido com sucesso");
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formAluInsProj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mostrarProjectosDataSet.projectos' table. You can move, or remove it, as needed.
            this.projectosTableAdapter.Fill(this.mostrarProjectosDataSet.projectos);

        }
    }
}
