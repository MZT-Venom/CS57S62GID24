using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagementSystem
{
    class Student : Person
    {
        private string name;
        private string cnic;
        private string email;
        private DateTime dob;
        private string regNo;
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
                    for(int i = 0; i < value.Length; i++)
                    {
                        if(!(value[i]>='A'&&value[i]<='Z'||value[i]>='a'&&value[i]<='z'||value[i]==' '))
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
                    for(int i = 0; i < 13; i++)
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
        public string RegNo
        {
            get
            {
                return regNo;
            }
            set
            {
                int len = value.Length;
                bool a = false;
                if (len >= 9 && len <= 11)
                {
                    if (value[0] == '2' && value[1] == '0' && value[4] == '-' && value[7] == '-' && value[2] >= '0' && value[2] <= '9' && value[3] >= '0' && value[3] <= '9' && value[5] >= 'A' && value[5] <= 'Z' && value[6] >= 'A' && value[6] <= 'Z')
                    {

                        for (int i = 8; i < len; i++)
                        {
                            if (value[i] >= '0' && value[i] <= '9')
                            {
                                a = true;
                            }
                            else
                            {
                                a = false;
                                break;
                            }
                        }
                    }
                }
                if (a == true)
                {
                    regNo = value;
                }
            }
        }
    }
}
