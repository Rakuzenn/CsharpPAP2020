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
    public partial class formInsMatProj : Form
    {
        public formInsMatProj()
        {
            InitializeComponent();
            showdata();
            showdatacomboAlu();
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
            cbmat.ValueMember = "ID_projecto";
           
            cbmat.DisplayMember = "Nome";
          
            cbmat.DataSource = dt;
        }


        public void showdata()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"SELECT materiais_projectos.ID_artigo, Material.Nome_artigo, materiais_projectos.Quantidade FROM ((materiais_projectos INNER JOIN projectos ON materiais_projectos.ID_projectos = projectos.ID_projecto) INNER JOIN Material ON  materiais_projectos.ID_artigo = Material.ID_artigo) where projectos.ID_projecto ='" + lblID.Text + "'";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataMat.DataSource = dt;
        }
        private void formInsMatProj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'materialDataSet.Material' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dataSetMateriais.Materiais' table. You can move, or remove it, as needed.


        }

        private void cbmat_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblID.Text = cbmat.SelectedValue.ToString();
            showdata();
        }

        private void DataMat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAddAluProj_Click(object sender, EventArgs e)
        {
            formInsMatInProj myForm = new formInsMatInProj();
            this.Show();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
