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
        DataTable table = new DataTable();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            HashSet<BSCourses>.Enumerator em = driver.bsCourse.BsCourseList.GetEnumerator();
            while (em.MoveNext())
            {
                table.Rows.Add(em.Current.CourseCode, em.Current.CourseName, em.Current.Semester, em.Current.CrHr);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            HashSet<MSCourses>.Enumerator em = driver.msCourse.MsCourseList.GetEnumerator();
            while (em.MoveNext())
            {
                table.Rows.Add(em.Current.CourseCode, em.Current.CourseName, em.Current.Semester, em.Current.CrHr);
            }
        }

        private void Manage_Courses_Load(object sender, EventArgs e)
        {
            DataColumn c1 = new DataColumn("CourseCode");
            DataColumn c2 = new DataColumn("CourseName");
            DataColumn c3 = new DataColumn("Semester");
            DataColumn c4 = new DataColumn("CreditHours");
            table.Columns.Add(c1);
            table.Columns.Add(c2);
            table.Columns.Add(c3);
            table.Columns.Add(c4);
            dataGridView1.DataSource = table;
        }

        private void Manage_Courses_Load_1(object sender, EventArgs e)
        {
            DataColumn c1 = new DataColumn("CourseCode");
            DataColumn c2 = new DataColumn("CourseName");
            DataColumn c3 = new DataColumn("Semester");
            DataColumn c4 = new DataColumn("CreditHours");
            table.Columns.Add(c1);
            table.Columns.Add(c2);
            table.Columns.Add(c3);
            table.Columns.Add(c4);
            dataGridView1.DataSource = table;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            string cc;
            string cn;
            int sem;
            int cr;
            HashSet<BSCourses>.Enumerator em = driver.bsCourse.BsCourseList.GetEnumerator();
            while (em.MoveNext())
            {
                cc = em.Current.CourseCode;
                cn = em.Current.CourseName;
                sem = em.Current.Semester;
                cr = em.Current.CrHr;
                table.Rows.Add(em.Current.CourseCode, em.Current.CourseName, em.Current.Semester, em.Current.CrHr);
            }
        }
    }
}
