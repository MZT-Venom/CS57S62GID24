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
    public partial class Manage_Courses : Form
    {
        Driver driver = new Driver();
        public Manage_Courses()
        {
            InitializeComponent();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
            ad.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCourse addcr = new AddCourse();
            addcr.Show();
            this.Hide();
            addcr.BringToFront();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
            log.BringToFront();
        }

        private void changePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangePassword chngpass = new ChangePassword();
            chngpass.Show();
            this.Hide();
            chngpass.BringToFront();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //driver.bsCourse.DelCourse();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
