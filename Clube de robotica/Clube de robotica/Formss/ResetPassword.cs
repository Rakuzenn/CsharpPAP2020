using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Clube_de_robotica.Formss;
using Clube_de_robotica.DAO;

namespace Clube_de_robotica
{
    public partial class ResetPassword : Form
    {

        string username = sendCode.email;

        public ResetPassword()
        {
            
            InitializeComponent();
        }

    



        private void ResetPassword_Load(object sender, EventArgs e)
        {
     
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPasswordVer.Text)
            {
                SqlCommand com = new SqlCommand();
                connection connection = new connection();
                com.CommandText = @"update [utilizador] set [palavrapasse] = HASHBYTES('MD5','@pass') where Email = '" + username + "'";
                com.Parameters.AddWithValue("@pass", txtPasswordVer.Text);
                connection.CRUD(com);
                MessageBox.Show("password alterada com sucesso");
                Login newForm = new Login();    //Create the New Form Object
                this.Close();    //Hide the Old Form
                newForm.Show();    //Show the New Form


            }
        }
    }
}
