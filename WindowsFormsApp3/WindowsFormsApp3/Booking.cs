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
    public partial class Booking : Form
    {
        BindingList<Customers> Listcustomers = new BindingList<Customers>();
        public Booking()
        {
            InitializeComponent();
            dataCust.DataSource = Listcustomers;
        }
        public class Customers
        {
            public string Name { get; set; }
            public string Phone  { get; set; }
            public string Table { get; set; }
            public string Time { get; set; }
            public Customers(string name, string phone, string table, string time)
            {
                Name = name;
                Phone = phone;
                Table = table;
                Time = time;
            }
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
          Listcustomers.Add(new Customers(txtName.Text, txtPhone.Text, cbbTable.Text, txtTime.Text));
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Mainmenu mainmenu = new Mainmenu();
            this.Hide();
            mainmenu.ShowDialog();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            dataCust.Rows.RemoveAt(dataCust.CurrentRow.Index);
            Listcustomers.Add(new Customers(txtName.Text, txtPhone.Text, cbbTable.Text, txtTime.Text)); 
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            dataCust.Rows.RemoveAt(dataCust.CurrentRow.Index);
        }
    }
}
