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
using System.Configuration;


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
            com.CommandText = @"SELECT * FROM utilizador where NProcesso = '" + txtNProc.Text + "'";
            SqlDataAdapter da = connection.Selectt(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Alunos ja esta inserido no clube");
            }
            else
            {
                com.CommandText = @"INSERT INTO utilizador ( Nome, NProcesso, Data_Nascimento, Curso, Email, administrador, palavrapasse) values (@nome, @nprocesso, @DataNasc, @curso, @email, 0, HashBytes('MD5', '@pass'))";
                com.Parameters.AddWithValue("@nome", txtNomeAlu.Text);
                com.Parameters.AddWithValue("@nprocesso", txtNProc.Text);
                com.Parameters.AddWithValue("@DataNasc", DateTime.Parse(dtNascAlu.Text));
                com.Parameters.AddWithValue("@curso", txtCurso.Text);
                com.Parameters.AddWithValue("@email", txtEmailAlu.Text);
                com.Parameters.AddWithValue("@pass", txtNProc.Text);

                connection.CRUD(com);

                showdata();
               
                MessageBox.Show("Aluno inserido com sucesso");

                //using (MailMessage mail = new MailMessage())
                //{
                //    mail.From = new MailAddress("ricardo.gaio.29072@esgc.pt");
                //    mail.To.Add(new MailAddress(txtEmailAlu.Text));
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
