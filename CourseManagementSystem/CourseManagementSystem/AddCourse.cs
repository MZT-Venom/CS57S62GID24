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
    public partial class AddCourse : Form
    {
        MSCourses ms = new MSCourses();
        BSCourses bs = new BSCourses();
        public AddCourse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCourse addcr = new AddCourse();
            MessageBox.Show("Course has been added successfully!");
            addcr.Show();
            this.Hide();
            addcr.BringToFront();
            if (MScourse.Checked)
            {
                ms.CourseCode = coursecode.Text;
                ms.CourseCode = coursename.Text;
                string crdt = crdthr.Text;
                int cr = Int16.Parse(crdt);
                ms.CrHr = cr;
                string semes = sem.SelectedItem.ToString();
                int semest = Int16.Parse(semes);
                ms.Semester = semest;
                ms.Outline = outline.Text;
            }
            else if (Bscourse.Checked) {
                bs.CourseCode = coursecode.Text;
                bs.CourseCode = coursename.Text;
                string crdt = crdthr.Text;
                int cr = Int16.Parse(crdt);
                bs.CrHr = cr;
                string semes = sem.SelectedItem.ToString();
                int semest = Int16.Parse(semes);
                bs.Semester = semest;
                ms.Outline = outline.Text;
            }
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            if (Bscourse.Checked)
            {
                sem.Items.Add("1");
                sem.Items.Add("2");
                sem.Items.Add("3");
                sem.Items.Add("4");
                sem.Items.Add("5");
                sem.Items.Add("6");
                sem.Items.Add("7");
                sem.Items.Add("8");
            }
            else if (MScourse.Checked) {
                sem.Items.Add("1");
                sem.Items.Add("2");
                sem.Items.Add("3");
                sem.Items.Add("4");
            }
            sem.Items.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Courses mngcr = new Manage_Courses();
            mngcr.Show();
            this.Hide();
            mngcr.BringToFront();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sem.Items.Add("1");
            sem.Items.Add("2");
            sem.Items.Add("3");
            sem.Items.Add("4");
        }

        private void sem_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Bscourse_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
