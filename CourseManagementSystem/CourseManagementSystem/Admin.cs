using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagementSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageTeacher mngtch = new ManageTeacher();
            mngtch.Show();
            this.Hide();
            mngtch.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Courses mngcr = new Manage_Courses();
            mngcr.Show();
            this.Hide();
            mngcr.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manage_Students mngstd = new Manage_Students();
            mngstd.Show();
            this.Hide();
            mngstd.BringToFront();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
            log.BringToFront();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword chngpass = new ChangePassword();
            chngpass.Show();
            this.Hide();
            chngpass.BringToFront();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
