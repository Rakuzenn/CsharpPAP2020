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
using System.Net.Mail;

namespace Clube_de_robotica
{
    public partial class formProfInsProj : Form
    {
        public formProfInsProj()
        {
            InitializeComponent();
            showdatacomboAlu();
            showdataProj();
        }


        private void showdatacomboAlu()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from utilizador where Administrador = 1";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);


            //Assign DataTable as DataSource.
            cbprof.ValueMember = "UserID";

            cbprof.DisplayMember = "Nome";

            cbprof.DataSource = dt;

        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        public void insert()
        {
            SqlCommand com = new SqlCommand();
            connection connection = new connection();

            com.CommandText = @"INSERT INTO user_projectos ( UserID, ID_projecto, Data_entrada) values (@userid, @idproj, @dataen)";
            com.Parameters.AddWithValue("@userid", lbluserNameAlu.Text);
            com.Parameters.AddWithValue("@idproj", projid.Text);
            SqlParameter sqlParameter = com.Parameters.AddWithValue("@dataen", DateTime.Now.ToString("M/d/yyyy"));


            connection.CRUD(com);

            MessageBox.Show("Professor inserido com sucesso");

            string Email = connection.Email(lbluserNameAlu.Text);


            //using (MailMessage mail = new MailMessage())
            //{
            //    mail.From = new MailAddress("ricardo.gaio.29072@esgc.pt");
            //    mail.To.Add(new MailAddress(Email));
            //    mail.Subject = "NÃO RESPONDER - CLUBE DE PROGRAMÇÃO";
            //    mail.Body = "<h1>Foi inserido num novo projecto, Para mais informações verifique a aplicação do Clube.</h1>";

            //    mail.IsBodyHtml = true;
            //    //mail.Attachments.Add(new Attachment("C:\\file.zip"));
            //    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            //    {
            //        string emailadress = System.Configuration.ConfigurationManager.AppSettings["emailadress"];
            //        string Epass = System.Configuration.ConfigurationManager.AppSettings["Epass"];
            //        smtp.Credentials = new System‎‎.Net‎‎.NetworkCredential(emailadress, Epass);
            //        smtp.EnableSsl = true;
            //        smtp.Send(mail);
            //    }
            //}
        }

       

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            insertt();
        }

        private void cbprof_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbluserNameAlu.Text = cbprof.SelectedValue.ToString();
        }

        private void DataProj_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataProj.Rows[e.RowIndex];
                projid.Text = row.Cells[0].Value.ToString();
            }
        }

        public void insertt()
        {
            SqlCommand com = new SqlCommand();
            connection connection = new connection();

            com.CommandText = @"SELECT * FROM user_projectos where UserID = '" + lbluserNameAlu.Text + "' AND ID_projecto ='" + projid.Text + "'";
            SqlDataAdapter da = connection.Selectt(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Professor ja esta inserido no projecto");
            }
            else
            {
                com.CommandText = @"INSERT INTO user_projectos ( UserID, ID_projecto, Data_entrada) values (@userid, @idproj, @dataen)";
                com.Parameters.AddWithValue("@userid", lbluserNameAlu.Text);
                com.Parameters.AddWithValue("@idproj", projid.Text);
                SqlParameter sqlParameter = com.Parameters.AddWithValue("@dataen", DateTime.Now.ToString("M/d/yyyy"));


                connection.CRUD(com);

                MessageBox.Show("Professor inserido com sucesso");
            }

        
        }

        private void formProfInsProj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clube_informaticaDataSet.projectos' table. You can move, or remove it, as needed.
            this.projectosTableAdapter.Fill(this.clube_informaticaDataSet.projectos);
            // TODO: This line of code loads data into the 'projectosDataSet.projectos' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet_Proj.projectos' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet_Eventos.eventos' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet_Proj.projectos' table. You can move, or remove it, as needed.



        }

        private void DataProj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataProj_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
