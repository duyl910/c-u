using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Adminlmao" && txtPass.Text == "09102003")
            {
                MessageBox.Show("Hello Sir!");
                Mainmenu mainmenu = new Mainmenu();
                this.Hide();
                mainmenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("You Sure", "Notify!", MessageBoxButtons.YesNo)!= DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
