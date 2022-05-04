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
using Clube_de_robotica.DAO;

namespace Clube_de_robotica.Formss
{
    public partial class formInsMat : Form
    {
        public formInsMat()
        {
            InitializeComponent();
            showdata();
        }
        public void showdata()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from Material";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataMateriais.DataSource = dt;
        }

        public void insert()
        {
            SqlCommand com = new SqlCommand();
            connection connection = new connection();
         
            com.CommandText = @"IF NOT EXISTS (SELECT * FROM Material WHERE Nome_artigo = @nome )
                                INSERT INTO Material (Nome_artigo, quantidade) values (@nome, @quant)
                                IF EXISTS (SELECT quantidade FROM Material WHERE Nome_artigo = @nome) 
                                UPDATE Material SET quantidade = (SELECT quantidade FROM Material WHERE Nome_artigo = @nome) + @quant WHERE Nome_artigo = @nome";
            com.Parameters.AddWithValue("@nome", txtNomeMat.Text);
            com.Parameters.AddWithValue("@quant", txtQuant.Text);
            connection.CRUD(com);
            showdata();
            MessageBox.Show("Material inserido com successo");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void formInsMat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMateriais.Materiais' table. You can move, or remove it, as needed.
          

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNomeMat.Text != "" && txtQuant.Text != "" )
            {
                insert();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
    }
}
