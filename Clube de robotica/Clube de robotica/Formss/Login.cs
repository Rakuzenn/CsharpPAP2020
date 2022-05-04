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
using Clube_de_robotica.Formss;
using WinBiometricDotNet;


namespace Clube_de_robotica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }


        public static string setvalueforadmincheck;


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inseriralunos_Click(object sender, EventArgs e)
        {

        }




        public void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != "" && txtNprocesso.Text != "")
                {
                    setvalueforadmincheck = txtNprocesso.Text;
                    login();

                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");

                }
            }
            catch (Exception ex)
            {

                return;
            }




        }




        public void login()
        {




            try
            {
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = @"select * from utilizador where NIF = " + txtNprocesso.Text + " or NProcesso = " + txtNprocesso.Text + " and palavrapasse = HashBytes('MD5', '" + txtPassword.Text + "') or palavrapasse = '" + txtPassword.Text + "'";

                SqlDataReader dr = connection.Select(com);

                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        Menu newForm = new Menu();    //Create the New Form Object
                        this.Hide();    //Hide the Old Form
                        newForm.Show();    //Show the New Form
                    }
                }
                else
                {
                    MessageBox.Show("Numero de processo/ NIF ou senha errados.");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar fazer login , Caso tenha colocado algum caracter especial como '.' tente novamente, se não chame o administrador -------->" + ex.Message.ToString());
            }
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnPassEsq_Click(object sender, EventArgs e)
        {
            sendCode newForm = new sendCode();    //Create the New Form Object
            this.Hide();    //Hide the Old Form
            newForm.Show();    //Show the New Form
        }

        private void txtNprocesso_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
