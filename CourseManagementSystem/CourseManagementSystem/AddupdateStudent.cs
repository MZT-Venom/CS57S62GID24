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
    public partial class AddupdateStudent : Form
    {
        public static bool validateName(string name) {
            int size = name.Length;
            bool flag = false;
            for (int i = 0; i < size; i++) {
                if ((name[i] >= 'a' && name[i] <= 'z') || (name[i] >= 'A' && name[i] <= 'Z') || (name[i] >= '0' && name[i] <= '9'))
                {
                    flag=true;
                }
                else {
                    flag=false;
                    break;
                }
            }
            return flag;
        }
        public static bool validateRegisterationNumber(String regno)
        {
            bool flag = false;
            int size = regno.Length;
            if (regno[0] == '2' && regno[1] == '0')
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            if (flag == true)
            {
                for (int i = 2; i < 4; i++)
                {
                    if (regno[i] >= '0' && regno[i] <= '9')
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            if (flag == true)
            {
                if (regno[4] == '-')
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            if (flag == true)
            {
                for (int i = 5; i < 7; i++)
                {
                    if (regno[i] >= 'A' && regno[i] <= 'Z')
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            if (flag == true)
            {
                if (regno[7] == '-')
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            if (flag == true)
            {
                if (size == 10)
                {
                    for (int i = 8; i < 10; i++)
                    {
                        if (regno[i] >= '0' && regno[i] <= '9')
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                }
                else if (size == 11)
                {
                    for (int i = 8; i < 11; i++)
                    {
                        if (regno[i] >= '0' && regno[i] <= '9')
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                }

            }
            return flag;
        }
        public static bool validatesem(string sem) {
            bool flag = false;
            int size = sem.Length;
            for (int i = 0; i < size; i++) {
                if (sem[i] >= '0' && sem[i] <= '9')
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
        public static bool validateCnic(String num)
        {
            bool flag = false;
            int size = num.Length;
            if (size == 13)
            {
                for (int i = 0; i < size; i++)
                {
                    if (num[i] >= '0' && num[i] <= '9')
                    {
                        flag = true;

                    }
                    else
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
            return flag;

        }
        public static bool validateMail(String mail) {
            bool flag = false;
            int size = mail.Length;
           
            for (int i = 0; i < size; i++)
            {
                if (mail.Contains("@"))
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (mail[j] == '.')
                        {
                            flag = true;
                            break;
                        }
                    }
                }
                else
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }
        public AddupdateStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Students mngstd = new Manage_Students();
            mngstd.Show();
            this.Hide();
            mngstd.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((validateName(name.Text)) && (validateRegisterationNumber(Reg.Text)) && (validateMail(Email.Text)) && (validatesem(sem.Text)))
            {
                if (Msstd.Checked)
                {
                    PostGraduate pglist = new PostGraduate();
                    pglist.Name = name.Text;
                    pglist.RegNo = Reg.Text;
                    int semes = Int16.Parse(sem.Text);
                    pglist.Semester = semes;
                    pglist.Cnic = cnic.Text;
                    pglist.Email = Email.Text;
                    pglist.Dob = date.Value;

                }
                else if (Bsstd.Checked)
                {
                    UnderGraduate Uglist = new UnderGraduate();
                    Uglist.Name = name.Text;
                    Uglist.RegNo = Reg.Text;
                    int semes = Int16.Parse(sem.Text);
                    Uglist.Semester = semes;
                    Uglist.Cnic = cnic.Text;
                    Uglist.Email = Email.Text;
                    Uglist.Dob = date.Value;
                }

                MessageBox.Show("Student has been added successfully!");
            }
            else {
                MessageBox.Show("Invalid Data!");
            }
            Manage_Students mngstd = new Manage_Students();
            
            mngstd.Show();
            this.Hide();
            mngstd.BringToFront();
        }

        private void AddupdateStudent_Load(object sender, EventArgs e)
        {
           
          
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Bsstd_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void Msstd_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
