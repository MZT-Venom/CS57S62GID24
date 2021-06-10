using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagementSystem
{
    class Teacherr: Instructor
    {
        private string name;
        private string cnic;
        private string email;
        private DateTime dob;
        private string instructorId;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                bool flag = true;
                if (value.Length <= 20)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (!(value[i] >= 'A' && value[i] <= 'Z' || value[i] >= 'a' && value[i] <= 'z' || value[i] == ' '))
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                else
                {
                    flag = false;
                }
                if (flag == true)
                {
                    name = value;
                }
                else
                {
                    MessageBox.Show("Invalid Name", "Error");
                }
            }
        }
        public string Cnic
        {
            get
            {
                return cnic;
            }
            set
            {
                bool flag = true;
                if (value.Length == 13)
                {
                    for (int i = 0; i < 13; i++)
                    {
                        if (!(value[i] >= '0' && value[i] <= '9'))
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                else
                {
                    flag = false;
                }
                if (flag == true)
                {
                    cnic = value;
                }
                else
                {
                    MessageBox.Show("Invalid Cnic", "Error");
                }
            }
        }
        public DateTime Dob
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string InstructorId
        {
            get
            {
                return instructorId;
            }
            set
            {
                instructorId = value;
            }
        }
    }
}
