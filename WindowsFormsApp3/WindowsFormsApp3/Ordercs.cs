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
    public partial class Ordercs : Form
    {
        List<Button> TableList = new List<Button>();
        List<Table> table = new List<Table>();
        public string totalPrice ;
        int priceBeef=0;
        int priceSpaghetti=0;
        int priceGin=0;
        int priceVermouth = 0;
        int priceMartini = 0;
        public Ordercs()
        {
            InitializeComponent();
            panel8.Visible = false;
            gBinformation.Visible = false;
        }
        public class Table
        { 
            public string Name { get; set; }
            public string Price { get; set; }
            public int Amount { get; set; }
            public string FoodB { get; set; }
            public string FoodS { get; set; }
            public string FoodG { get; set; }
            public string FoodV { get; set; }
            public string FoodM { get; set; }

        }
   /*     priceBeef+= 150000 * int.Parse(txtAmountBeef.Text);
        priceGin += 75000 * int.Parse(txtAmountGin.Text);
        totalPrice += priceBeef + priceGin;*/
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbbeef.Checked )
            {
                priceBeef += 150000 * int.Parse(txtAmountBeef.Text);
                totalPrice += priceBeef;
                Table t = new Table();
                {
                    t.FoodB = cbbeef.Text;
                    t.Price = totalPrice;
                }
                table.Add(t);             
            }
            else if (cbSpaghetti.Checked)
            {
                priceSpaghetti += 100000 * int.Parse(txtAmountSpaghetti.Text);
                totalPrice += priceSpaghetti;
                Table t = new Table();
                {
                    t.FoodS = cbbeef.Text;
                    t.Price = totalPrice;
                }
                table.Add(t);
            }
            else if( cbGin.Checked)
            {
                priceGin += 75000 * int.Parse(txtAmountGin.Text);
                totalPrice += priceGin;
                Table t = new Table();
                {
                    t.FoodG = cbbeef.Text;
                    t.Price = totalPrice;
                }
                table.Add(t);
            }
            else if(cbVermouth.Checked)
            {
                priceVermouth+= 80000 * int.Parse(txtAmountVermouth.Text);
                totalPrice += priceVermouth;
                Table t = new Table();
                {
                    t.FoodV = cbbeef.Text;
                    t.Price = totalPrice;
                }
                table.Add(t);
            }
            else if (cbMartini.Checked)
            {
                priceMartini+= 75000* int.Parse(txtAmountMartini.Text);
                totalPrice+= priceMartini;
                Table t = new Table();
                {
                    t.FoodM = cbbeef.Text;
                    t.Price = totalPrice;
                }
                table.Add(t);
            }
            txtPrice.Text=totalPrice.ToString();
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            Mainmenu mainmenu = new Mainmenu();
            this.Close();
            mainmenu.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btA1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Red)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Green;
                    TableList.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    TableList.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("The Table's already been taken!");
            }
        }

        private void btA2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Red)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Green;
                    TableList.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    TableList.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("The Table's already been taken!");
            }
        }

        private void btA3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Red)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Green;
                    TableList.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    TableList.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("The Table's already been taken!");
            }
        }

        private void btA4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Red)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Green;
                    TableList.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    TableList.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("The Table's already been taken!");
            }
        }

        private void btB1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Red)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Green;
                    TableList.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    TableList.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("The Table's already been taken!");
            }
        }

        private void btB2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Red)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Green;
                    TableList.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    TableList.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("The Table's already been taken");
            }
        }

        private void btB3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Red)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Green;
                    TableList.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    TableList.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("The Table's already been taken!");
            }
        }

        private void btB4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Red)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Green;
                    TableList.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    TableList.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("The Table's already been taken!");
            }
        }

        private void btC1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Red)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Green;
                    TableList.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    TableList.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("The Table's already been taken!");
            }
        }

        private void btC2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Red)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Green;
                    TableList.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    TableList.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("The Table's already been taken!");
            }
        }

        private void btC3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Red)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Green;
                    TableList.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    TableList.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("The Table's already been taken!");
            }
        }

        private void btC4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Red)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Green;
                    TableList.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    TableList.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("The Table's already been taken!");
            }
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            foreach (Button button in TableList)
            {
                string a = button.Text;
                if (a == button.Text)
                {
                    button.BackColor = Color.Red;
                    txtTable.Text += a + " ";
                }
                TableList = new List<Button>();
            }
            Table t = new Table();
            {
                t.Name = txtTable.Text;
            }
            table.Add(t);
            foreach (Table tb in table)
            { lbListTable.Items.Add(tb.Name); }
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            priceBeef = 0;
            priceGin = 0;
            priceMartini = 0;
            priceSpaghetti = 0;
            priceVermouth = 0;
            cbbeef.Checked = false;
            txtAmountBeef.Text = "";
            totalPrice = null;
            txtPrice.Text = "";
            cbGin.Checked = false;
            txtAmountGin.Text = "";
            cbMartini.Checked = false;
            txtAmountMartini.Text = "";
            cbSpaghetti.Checked = false;
            txtAmountSpaghetti.Text = "";
            cbVermouth.Checked = false;
            txtAmountVermouth.Text = "";           
        }
        private void btPay_Click(object sender, EventArgs e)
        {
            table.Clear();
            txtPrice.Text = "";
            MessageBox.Show("Thanks for coming!");
            foreach (Button button in TableList)
            {
                string a = button.Text;
                if (a == button.Text)
                {
                    if (button.BackColor != Color.White)
                    {
                        button.BackColor = Color.White;

                    }
                }
                TableList = new List<Button>();
            }
        }
        private void btCancel_Click_1(object sender, EventArgs e)
        {
            foreach (Button button in TableList)
            {
                string a = button.Text;
                if (a == button.Text)
                {
                    if (button.BackColor == Color.Red)
                    {
                        button.BackColor = Color.White;
                        TableList.Add(button);
                    }
                }
            }
            TableList = new List<Button>();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbeef_CheckStateChanged(object sender, EventArgs e)
        {
            panel3.Visible = true;        }

        private void cbSpaghetti_CheckStateChanged(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void cbGin_CheckStateChanged(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void cbVermouth_CheckStateChanged(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void cbMartini_CheckStateChanged(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void Ordercs_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            gBinformation.Visible = true;
        }
        private void lbListTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Table t in table)
            {
                lblFoodB.Text = t.FoodB;
                lblFoodG.Text = t.FoodG;
                lblFoodM.Text = t.FoodM;
                lblFoodS.Text = t.FoodS;
                lblFoodV.Text = t.FoodV;
                lblTotalCost.Text = t.Price;
            }
        }

        private void lblFoodB_Click(object sender, EventArgs e)
        {

        }

        private void gBinformation_Enter(object sender, EventArgs e)
        {

        }
    }
}
