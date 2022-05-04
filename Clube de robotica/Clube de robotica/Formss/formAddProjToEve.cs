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
using System.Net;
using System.Net.Mail;
using Clube_de_robotica.DAO;

namespace Clube_de_robotica.Formss
{
    public partial class formAddProjToEve : Form
    {
        public formAddProjToEve()
        {
            InitializeComponent();
            showdataProj();
            showdatacomboAlu();
        }

        private void showdatacomboAlu()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from eventos";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);




            //Assign DataTable as DataSource.
            cbeve.ValueMember = "ID_Evento";

            cbeve.DisplayMember = "Nome_evento";

            cbeve.DataSource = dt;
        }

        private void cbeve_SelectedIndexChanged(object sender, EventArgs e)
        {
            eveid.Text = cbeve.SelectedValue.ToString();
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



     
        private void DataProj_CellContentClick(object sender, DataGridViewCellEventArgs e)
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


            com.CommandText = @"SELECT * FROM projectos_eventos where ID_projectos = '" + projid.Text + "' AND ID_eventos ='" + eveid.Text + "'";
            SqlDataAdapter da = connection.Selectt(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            try
            {

                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Projecto ja irá participar neste evento");
                }
                else
                {
                    com.CommandText = @"INSERT INTO projectos_eventos ( ID_projectos,ID_eventos) values (@projid, @eveid)";
                    com.Parameters.AddWithValue("@projid", projid.Text);
                    com.Parameters.AddWithValue("@eveid", eveid.Text);


                    connection.CRUD(com);

                    MessageBox.Show("Projecto inserido com sucesso");


                    //string Email = connection.Email(lblID.Text);


                    //using (MailMessage mail = new MailMessage())
                    //{
                    //    mail.From = new MailAddress("ricardo.gaio.29072@esgc.pt");
                    //    mail.To.Add(new MailAddress(Email));
                    //    mail.Subject = "NÃO RESPONDER - CLUBE DE PROGRAMÇÃO";
                    //    mail.Body = "<h1>Foi inserido num novo evento, Para mais informações verifique a aplicação do Clube.</h1>";

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }



        }

        private void formAddProjToEve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectosDataSet.projectos' table. You can move, or remove it, as needed.

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void DataProj_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DataProj.Rows[e.RowIndex];
            projid.Text = row.Cells[0].Value.ToString();
        }
    }
}
