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
using System.Net;
using System.Net.Mail;



namespace Clube_de_robotica
{
    public partial class formInsProf : Form
    {


        public formInsProf()
        {
            InitializeComponent();
            showdata();
        }


        private void formInsProf_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataSet.utilizador' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet_Utilizador.utilizador' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet_Utilizador.utilizador' table. You can move, or remove it, as needed.




        }

        public void showdata()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from utilizador where Administrador = 1";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataProf.DataSource = dt;
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceitarProf_Click(object sender, EventArgs e)
        {
            if (txtnomeprof.Text != "" && txtNIF.Text != "" && txtEmailProf.Text != "" && txtArea.Text != "" && dtNascProf.Text != "")
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
            com.CommandText = @"SELECT * FROM utilizador where NIF = '" + txtNIF.Text + "'";
            SqlDataAdapter da = connection.Selectt(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Professor ja esta inserido no clube");
            }
            else
            {
                com.CommandText = @"INSERT INTO utilizador ( Nome, NIF, Data_Nascimento, area, Email, administrador, palavrapasse) values (@nome, @nif, @DataNasc, @area, @email, 1, HashBytes('MD5', '@pass'))";
                com.Parameters.AddWithValue("@nome", txtnomeprof.Text);
                com.Parameters.AddWithValue("@nif", txtNIF.Text);
                com.Parameters.AddWithValue("@DataNasc", DateTime.Parse(dtNascProf.Text));
                com.Parameters.AddWithValue("@area", txtArea.Text);
                com.Parameters.AddWithValue("@email", txtEmailProf.Text);
                com.Parameters.AddWithValue("@pass", txtNIF.Text);


                connection.CRUD(com);
                showdata();


                MessageBox.Show("Professor inserido com sucesso");
                //using (MailMessage mail = new MailMessage())
                //{
                //    mail.From = new MailAddress("ricardo.gaio.29072@esgc.pt");
                //    mail.To.Add(new MailAddress(txtEmailProf.Text));
                //    mail.Subject = "NÃO RESPONDER - CLUBE DE PROGRAMÇÃO";
                //    mail.Body = "<h2>Foi inserido no clube de programação, Para mais informações verifique a aplicação do Clube.</h2>";

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
            }
        }

    }

}

      
    
    
       



    
