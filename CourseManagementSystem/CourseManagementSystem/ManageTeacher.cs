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
    public partial class ManageTeacher : Form
    {
        public ManageTeacher()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddUpdateTeacher addtch = new AddUpdateTeacher();
            addtch.Show();
            this.Hide();
            addtch.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
            ad.BringToFront();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword chngpass = new ChangePassword();
            chngpass.Show();
            this.Hide();
            chngpass.BringToFront();
        }
    }
}
