using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagementSystem
{
    class BSCourses : Course
    {
        private int semester;
        private int crHr;
        public int Semester
        {
            get
            {
                return semester;
            }
            set
            {
                if (value > 0 && value <= 8)
                {
                    semester = value;
                }
            }
        }
        public int CrHr
        {
            get
            {
                return crHr;
            }
            set
            {
                if (crHr >= 1 && crHr <= 3)
                {
                    crHr = value;
                }
            }
        }

    }
}
