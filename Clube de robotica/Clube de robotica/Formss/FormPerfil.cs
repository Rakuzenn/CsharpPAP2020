using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clube_de_robotica;
using System.Data.SqlClient;
using Clube_de_robotica.DAO;

namespace Clube_de_robotica
{
    public partial class FormPerfil : Form
    {
        public FormPerfil()
        {
            InitializeComponent();
        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {
            txtNpNi.Text = Login.setvalueforadmincheck;

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from utilizador where NProcesso =  @NProcesso or NIF = @nif ";
            command.Parameters.AddWithValue("@NProcesso", txtNpNi.Text);
            command.Parameters.AddWithValue("@nif", txtNpNi.Text);
            connection connection = new connection();
            connection.CRUD(command);
            SqlDataReader dr = connection.Select(command);

            while (dr.Read())
            {
                txtNomeUtilizador.Text = (dr["Nome"].ToString());
                txtNif.Text = (dr["nif"].ToString());
                txtArea.Text = (dr["area"].ToString());
                txtCurso.Text = (dr["Curso"].ToString());
                txtdtnasc.Text = (dr["Data_Nascimento"].ToString());
                txtEmailUtilizador.Text = (dr["Email"].ToString());
                txtNprocesso.Text = (dr["NProcesso"].ToString());
                txtAlterPassword.Text = (dr["palavrapasse"].ToString());
            }
        }
       

        public void update()
        {
            try
            {
               
                if ((String.IsNullOrEmpty(txtNif.Text)) || (txtNif.Text.Length == 9))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"UPDATE utilizador SET nif = @nif, Email = @email where NProcesso = '" + txtNpNi.Text + "' or nif = '" + txtNpNi.Text + "'";
                    command.Parameters.AddWithValue("@nif", txtNif.Text);
                    command.Parameters.AddWithValue("@email", txtEmailUtilizador.Text);




                    connection.CRUD(command);

                    MessageBox.Show("Dados actualizados com sucesso");
                }
                else
                {
                    MessageBox.Show("O nif precisa de ter 9 numeros, ou estar vazio");
                }
                
            }
            catch (Exception ex )
            {
                MessageBox.Show("Dados não actualizados com sucesso ------>", ex.ToString()); 

                return;
            }
        }
           

        private void txtAlterPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarPerfil_Click(object sender, EventArgs e)
        {
            update();
        }

        private void txtNif_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
