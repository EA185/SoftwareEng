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


namespace SoftwareProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dsLogin = DBConnection.GetDBConnectionInstance().GetDataSet("SELECT Count (*) From login WHERE username='" + textBox1.Text + "' and password='" + Pass.Text + "'");

            DataTable dtLogin = dsLogin.Tables[0];

            if (dtLogin.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Login Successful!", "Login Successful!");
                this.Hide();
                Menu page = new Menu();
                page.ShowDialog();
            }
            else
            {
                MessageBox.Show("Fail");
            }
               
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         MessageBox.Show("Seriously?! You forgot your password?!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
