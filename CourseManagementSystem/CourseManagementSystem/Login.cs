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
    public partial class Login : Form
    {
        String Username;
        //String Password;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.UseSystemPasswordChar=false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Username = LoginUN.Text;
            if (Username.Contains("Admin"))
            {
                Admin ad = new Admin();
                ad.Show();
                this.Hide();
                ad.BringToFront();
            }
            else if (Username.Contains("student"))
            {

                Student2 std = new Student2();
                std.Show();
                this.Hide();
                std.BringToFront();
            }
            else if (Username.Contains("instructor"))
            {

                Teacher tch = new Teacher();
                tch.Show();
                this.Hide();
                tch.BringToFront();
            }
            else {
                MessageBox.Show("Incorrect Username or Password!");
            }
        }

        private void LoginUN_TextChanged(object sender, EventArgs e)
        {
          //  Username = LoginUN.Text;
        }
    }
}
