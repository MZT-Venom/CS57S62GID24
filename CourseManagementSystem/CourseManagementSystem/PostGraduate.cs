using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagementSystem
{
    class PostGraduate : Student
    {
        private int semester;
        private List<MSCourses> course = new List<MSCourses>();
        public int Semester
        {
            get
            {
                return semester;
            }
            set
            {
                if (value >= 0 && value <= 4)
                {
                    semester = value;
                }
                else
                {
                    MessageBox.Show("Invalid Semester", "Error");
                }
            }
        }
        public List<MSCourses> Course
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
