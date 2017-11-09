using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareProject
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register page = new Register();
            page.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exist page = new Exist();
            page.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            check page = new check();
            page.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking page = new Booking();
            page.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login page = new Login();
            page.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
