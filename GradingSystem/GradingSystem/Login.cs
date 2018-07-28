using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if((use.Text == "Admin")&&(pass.Text == "123"))
            {
                Form1 MainForm = new Form1();
                MainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Dur redd ol");
            }
        }
    }
}
