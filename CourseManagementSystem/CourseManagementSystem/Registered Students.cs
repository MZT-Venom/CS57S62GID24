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
    public partial class Registered_Students : Form
    {
        public Registered_Students()
        {
            InitializeComponent();
        }

        private void Registered_Students_Load(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
            log.BringToFront();
            
        }

        private void Registered_Students_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
