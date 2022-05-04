using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//1. import System.Data.SqlClient
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace Clube_de_robotica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inseriralunos_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //2. create new SqlConnection. 
            /*the @"" thing is a Connection String.*/
            SqlConnection sqlcon = new SqlConnection(@"Data Source = B07-PC03; Initial Catalog = Clube_informatica; Integrated Security = True");
            //3.Make a query. The query is what we're going to ask the DB to do, pretty much.

            //Encryption time!!
            //search for username and get the PW string

            string query = "Select * from [utilizador] Where NProcesso= '" + txtNprocesso.Text + "'";
            //4. Create an object which will send the query through our connection to the sql server
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            //5. Create a dataTable in which we'll put the login information that matches
            DataTable dtbl = new DataTable();
            //6.Fill the table with whichever entry in the DB fits the criteria of:having the username put in the txtNprocesso.Text
            //and password from txtPassword.Text
            sda.Fill(dtbl);
            //7.If there is 1 element, check for password matching :)
            if (dtbl.Rows.Count == 1)
            {
                //get the saved string
                    // string savedPasswordHash = dtbl.Rows[0][1].ToString();
                //turn it into bytes
                    //byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
                //take the salt out of the string
                     // byte[] salt = new byte[16];
                     // Array.Copy(hashBytes, 0, salt, 0, 16);
                //hash the user inputted PW with the salt
                    //var pbkdf2 = new Rfc2898DeriveBytes(txtPassword.Text, salt, 10000);
                //put the damn thing in a byte vector.. instead of a string. why? why is this necessary?
                //who am i to judge cryptography standards i guess
                   // byte[] hash = pbkdf2.GetBytes(20);
                //oh, this is why
                //compare results! letter by letter!
                //starting from 17 cause 0-16 are the salt
                        //int ok = 1;
                        //for (int i = 0; i < 20; i++)
                        // if (hashBytes[i + 16] != hash[i])
                        //ok = 0;
                        //if (ok == 1)
                {
                    Menu newForm = new Menu();    //Create the New Form Object
                    this.Hide();    //Hide the Old Form
                    newForm.ShowDialog();    //Show the New Form
                    this.Close();    //Close the Old Form
                   // frm2.ShowDialog();
                   // Close();
                }
                            //else
                            //{
                            //if wrong password, show
                            //   MessageBox.Show("Incorrect username or password!");
                            //}
            }
            //If no match for NProcesso, show
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }

            sqlcon.Close();
        

       
        }
    }
}
