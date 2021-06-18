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
        
        public static bool verifycoursecode(string coursecode ) {
            bool flag = false;
            // if (coursecode)) { }
            int length = coursecode.Length;
            for (int i = 0; i < length; i++) {
                if ((coursecode[i] >= 'a' && coursecode[i] <= 'z') || (coursecode[i] >= 'A' && coursecode[i] <= 'Z') || (coursecode[i] >= '0' && coursecode[i] <= '9'))
                {
                    flag = true;
                }
                else {
                    flag = false;
                    break;
                }
                }


            return flag;
        }
        public static bool validateCourseName(String CourseName) {
            bool flag = false;
            int length = CourseName.Length;
            for (int i = 0; i < length; i++) {
                if ((CourseName[i] >= 'A' && CourseName[i] <= 'Z') || (CourseName[i] >= 'a' && CourseName[i] <= 'z'))
                {
                    flag = true;
                }
                else {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public static bool validatecreditHours(string crdthr) {
            bool flag = false;
            int length = crdthr.Length;
            for (int i = 0; i < length; i++) {
                if (crdthr[i] >= '0' && crdthr[i] <= '9')
                {
                    flag = true;
                }
                else {
                    flag = false;
                }
            }
            return flag;
        }
        public static bool validateInstructor(String name) {
            bool flag=false;
            int size = name.Length;
            for (int i = 0; i < size; i++)
            {
                if ((name[i] >= 'A' && name[i] <= 'Z') || (name[i] >= 'a' && name[i] <= 'z'))
                {
                    flag = true;
                }
                else {
                    flag = false;
                }
            }
            return flag;
        }
        public static bool validateSemester(String sem) {
            bool flag = false;
            int size = sem.Length;
            for (int i = 0; i < size; i++) {
                if (sem[i] >= '0' && sem[i] <= '9')
                {
                    flag = true;
                }
                else {
                    flag = false;
                }
            }

            return flag;
        }
        MSCourses ms = new MSCourses();
        BSCourses bs = new BSCourses();
        public AddCourse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (verifycoursecode(coursecode.Text) && (validateCourseName(coursename.Text)) && (validatecreditHours(crdthr.Text)) && (validateInstructor(instructor.Text)) && (validateSemester(sem.Text)))
            {
                if (MScourse.Checked)
                {
                    ms.CourseCode = coursecode.Text;
                    ms.CourseCode = coursename.Text;
                    string crdt = crdthr.Text;
                    int cr = Int16.Parse(crdt);
                    ms.CrHr = cr;
                    string semes = sem.Text;
                    int semest = Int16.Parse(semes);
                    ms.Semester = semest;
                    ms.Outline = outline.Text;
                }
                else if (Bscourse.Checked)
                {
                    bs.CourseCode = coursecode.Text;
                    bs.CourseCode = coursename.Text;
                    string crdt = crdthr.Text;
                    int cr = Int16.Parse(crdt);
                    bs.CrHr = cr;
                    string semes = sem.Text;
                    int semest = Int16.Parse(semes);
                    bs.Semester = semest;
                    ms.Outline = outline.Text;
                }
                MessageBox.Show("Course has been added successfully!");
            }
            else {
                MessageBox.Show("Invalid Data!");
            }
                AddCourse addcr = new AddCourse();            
            addcr.Show();
            this.Hide();
            addcr.BringToFront();
           
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
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
            
        }

        private void sem_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Bscourse_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
