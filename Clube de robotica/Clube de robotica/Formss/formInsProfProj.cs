﻿using System;
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

namespace Clube_de_robotica
{
    public partial class formInsProfProj : Form
    {
        private string projid;

        public formInsProfProj()
        {
            InitializeComponent();
            showdatacomboProf();
            showdataProf();
        }

        public void showdatacomboProf()
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

        public void showdataProf()
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = @"SELECT user_projectos.ID_projecto, projectos.Nome, projectos.Data_inicio, projectos.Data_fim , projectos.descricao  FROM ((user_projectos INNER JOIN utilizador ON user_projectos.UserID = utilizador.UserID) INNER JOIN projectos ON user_projectos.ID_projecto = projectos.ID_projecto) where utilizador.UserID = '" + projid + "'";
            SqlDataAdapter adpt = connection.Selectt(com);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DataProjProf.DataSource = dt;
        }

        
        private void cbprof_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID id = new ID();
            id.IDs = cbprof.SelectedValue.ToString();
            projid = id.IDs;
            showdataProf();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formProfInsProj myForm = new formProfInsProj();
            this.Show();
            myForm.ShowDialog();
            this.Close();
        }

        private void formInsProfProj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectosDataSet.projectos' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet_Proj.projectos' table. You can move, or remove it, as needed.



        }
    }
}
