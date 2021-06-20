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
    public partial class AddUpdateTeacher : Form
    {
        public static bool validateName(String name) {
            bool flag = false;
            int size = name.Length;
            for (int i = 0; i < size; i++)
            {
                if ((name[i] >= 'a' && name[i] <= 'z') || (name[i] >= 'A' && name[i] <= 'Z') || (name[i] >= '0' && name[i] <= '9'))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        public static bool validateCnic(String Cnic) {
            bool flag = false;
            int size = Cnic.Length;
            if (size == 13)
            {
                for (int i = 0; i < size; i++)
                {
                    if (Cnic[i] >= '0' && Cnic[i] <= '9')
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
        public static bool validateMail(String mail)
        {
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
        public static bool validateId(String Id) {
            bool flag = false;
            int size = Id.Length;
            for(int i = 0; i < size; i++)
            {
                if (Id[i] >= '0' && Id[i] <= '9')
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        public AddUpdateTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageTeacher mngtch = new ManageTeacher();
            mngtch.Show();
            this.Hide();
            mngtch.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddTeacherbtn_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Instructor has been added successfully!");
            ManageTeacher mngtch = new ManageTeacher();
            mngtch.Show();
            this.Hide();
            mngtch.BringToFront();
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

        private void AddUpdateTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
