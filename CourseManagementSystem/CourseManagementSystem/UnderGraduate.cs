using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagementSystem
{
    class UnderGraduate : Student
    {
        private int semester;
        private List<BSCourses> course = new List<BSCourses>();
        public int Semester
        {
            get
            {
                return semester;
            }
            set
            {
                if (value >= 0 && value <= 8)
                {
                    semester = value;
                }
                else
                {
                    MessageBox.Show("Invalid Semester", "Error");
                }
            }
        }
        public List<BSCourses> Course
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
            }
        }
    }
}
