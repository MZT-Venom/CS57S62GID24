using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagementSystem
{
    abstract class Course
    {
        private String courseCode;
        private String courseName;
        private String outline;
        public String CourseCode
        {
            get
            {
                return courseCode;
            }
            set
            {
                int x = value.Length;
                bool flag = true;
                if (x == 5)
                {

                    for (int i = 0; i < 2; i++)
                    {
                        if (!((value[i] >= 'a' && value[i] <= 'z') || (value[i] >= 'A' && value[i] <= 'Z')))
                        {
                            flag = false;
                            break;
                        }
                    }

                    for (int i = 2; i < 5 && flag; i++)
                    {
                        if (!(value[i] >= '0' && value[i] <= '9'))
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                if (flag == true)
                {
                    courseCode = value;
                }
                else
                {
                    MessageBox.Show("Invalid Course Code!!!! \n use Course Code like  CS111L or CS11", "Error");
                }
            }
        }
        public String CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                bool flag = true;
                if (value.Length <= 50)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (!(value[i] >= 'A' && value[i] <= 'Z' || value[i] >= 'a' && value[i] >= 'z'))
                            flag = false;
                    }
                }
                if (flag == true)
                {
                    courseName = value;
                }
                else
                {
                    MessageBox.Show("Invalid Course Name!!!! \n only alphabets are allowed", "Error");
                }
            }
        }
        public String Outline
        {
            get
            {
                return outline;
            }
            set
            {
                bool flag = true;
                if (value.Length <= 150)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (!(value[i] >= 'A' && value[i] <= 'Z' || value[i] >= 'a' && value[i] <= 'z' || value[i] >= '0' && value[i] <= '9'))
                            flag = false;
                    }
                }
                if (flag == true)
                {
                    outline = value;
                }
                else
                {
                    MessageBox.Show("Invalid outline for Course!!!!!\n Max. len. allowed upto 150\n only Alphanumeric data is allowed", "Error");
                }
            }
        }
    }
}
