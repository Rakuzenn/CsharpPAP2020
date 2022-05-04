using Clube_de_robotica.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clube_de_robotica.Formss
{
    public partial class formInsMatInProj : Form
    {
        public formInsMatInProj()
        {
            InitializeComponent();
            showdatacomboAlu();
            showdataProj();
        }

        private void formInsMatInProj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'materialDataSet.Material' table. You can move, or remove it, as needed.

        }

        private void showdatacomboAlu()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from projectos";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);


            //Assign DataTable as DataSource.
            cbproj.ValueMember = "ID_projecto";

            cbproj.DisplayMember = "Nome";

            cbproj.DataSource = dt;

        }

        public void showdataProj()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from Material";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataMat.DataSource = dt;
        }

        private void DataMat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataMat.Rows[e.RowIndex];
                lblmateriais.Text = row.Cells[0].Value.ToString();
            }
        }


        private void cbproj_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblproj.Text = cbproj.SelectedValue.ToString();
        }

        public void insert()
        {
            SqlCommand com = new SqlCommand();
            connection connection = new connection();


            com.CommandText = @"SELECT * FROM materiais_projectos where ID_artigo = '" + lblmateriais.Text + "' AND ID_projectos ='" + lblproj.Text + "'";
            SqlDataAdapter da = connection.Selectt(com);
            DataTable dt = new DataTable();
            da.Fill(dt);


            com.CommandText = @"IF NOT EXISTS (SELECT * FROM materiais_projectos WHERE ID_artigo = @mat )
                                INSERT INTO materiais_projectos (ID_artigo, ID_projectos, quantidade) values (@mat , @proj ,1)
                                IF EXISTS (SELECT quantidade FROM materiais_projectos WHERE ID_artigo = @mat)
								UPDATE materiais_projectos SET quantidade = (SELECT quantidade FROM materiais_projectos WHERE ID_artigo = @mat) + 1 WHERE ID_artigo = @mat
                                UPDATE Material SET quantidade = (SELECT quantidade FROM Material WHERE ID_artigo = @mat) -1  WHERE ID_artigo = @mat";
            com.Parameters.AddWithValue("@mat", lblmateriais.Text);
            com.Parameters.AddWithValue("@proj", lblproj.Text);
          


            connection.CRUD(com);
            MessageBox.Show("Material inserido com sucesso no projecto");
            showdataProj();

        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insert();
           
        }

        private void DataMat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataMat.Rows[e.RowIndex];
                lblmateriais.Text = row.Cells[0].Value.ToString();
            }
        }
    }
}
