using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using Clube_de_robotica.Formss;

namespace Clube_de_robotica.Formss
{
    public partial class sendCode : Form
    {
        string randomCode;
        public static string email;

        public sendCode()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
      
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
           
            try
            {
                using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {

                    Credentials = new NetworkCredential("ricardo.gaio.29072@esgc.pt", "D01sk01pt123"),
                    EnableSsl = true
                })
                {
                    client.Send(txtEmail.Text, txtEmail.Text, "Clube de Programação - Reset Password", "O teu codigo de reset da password é " + randomCode);
               
                    MessageBox.Show("your code was sent sucessfully");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("your code was not sent sucessfully");
         
            }
                
        }

        

        private void btnVerCode_Click(object sender, EventArgs e)
        {
            if(randomCode == (txtVerCode.Text).ToString())
            {
                email = txtEmail.Text;
                ResetPassword rp = new ResetPassword();
                this.Hide();    //Hide the Old Form
                rp.Show();
            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Login newForm = new Login();    //Create the New Form Object
            this.Hide();    //Hide the Old Form
            newForm.Show();    //Show the New Form
        }

        private void sendCode_Load(object sender, EventArgs e)
        {

        }
    }
}
