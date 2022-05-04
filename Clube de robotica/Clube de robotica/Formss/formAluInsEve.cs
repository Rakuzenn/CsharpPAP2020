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

namespace Clube_de_robotica
{
    public partial class formAluInsEve : Form
    {


        public formAluInsEve()
        {
            InitializeComponent();
            showdataProj();
            showdatacomboAlu();
        }

        private void formAluInsEve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventosDataSet.eventos' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet_Eventos.eventos' table. You can move, or remove it, as needed.

        }

        private string GetEmail;

        private void showdatacomboAlu()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from utilizador where Administrador = 0";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);


          

            //Assign DataTable as DataSource.
            cbalu.ValueMember = "UserID";

            cbalu.DisplayMember = "Nome";

            cbalu.DataSource = dt;
        }

        public void showdataProj()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"select * from eventos";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataEve.DataSource = dt;
        }

        private void cbalu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lblID.Text = cbalu.SelectedValue.ToString();
        }


        public void insert()
        {
            SqlCommand com = new SqlCommand();
            connection connection = new connection();


            com.CommandText = @"SELECT * FROM user_eventos where UserID = '" + lblID.Text + "' AND ID_evento ='" + lblEveID.Text + "'";
            SqlDataAdapter da = connection.Selectt(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            try
            {

                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Alunos ja está a inserido no evento");
                }
                else
                {
                    com.CommandText = @"INSERT INTO user_eventos ( UserID, ID_evento, Data_entrada) values (@userid, @eveid, @dataen)";
                    com.Parameters.AddWithValue("@userid", lblID.Text);
                    com.Parameters.AddWithValue("@eveid", lblEveID.Text);
                    SqlParameter sqlParameter = com.Parameters.AddWithValue("@dataen", DateTime.Now.ToString("M/d/yyyy"));


                    connection.CRUD(com);

                    MessageBox.Show("Aluno inserido com sucesso");

                                
                    string Email = connection.Email(lblID.Text);
          

                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress("ricardo.gaio.29072@esgc.pt");
                        mail.To.Add(new MailAddress(Email));
                        mail.Subject = "NÃO RESPONDER - CLUBE DE PROGRAMÇÃO";
                        mail.Body = "<h1>Foi inserido num novo evento, Para mais informações verifique a aplicação do Clube.</h1>";

                        mail.IsBodyHtml = true;
                        //mail.Attachments.Add(new Attachment("C:\\file.zip"));
                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            string emailadress = System.Configuration.ConfigurationManager.AppSettings["emailadress"];
                            string Epass = System.Configuration.ConfigurationManager.AppSettings["Epass"];
                            smtp.Credentials = new System‎‎.Net‎‎.NetworkCredential(emailadress, Epass);
                            smtp.EnableSsl = true;
                            smtp.Send(mail);
                        }
                    }
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.ToString());
                return;
            }



        }




        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataEve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataEve.Rows[e.RowIndex];
                lblEveID.Text = row.Cells[0].Value.ToString();
            }

        }

        private void DataEve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



