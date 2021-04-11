using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
    public partial class Form1 : Form
    {
        public double dBalance = 0.0;
        public Form1()
        {
            InitializeComponent();
        }
        private void update_balance()
        {
            //dBalance += 2.0;
            textBox1.Text = dBalance.ToString("n2");
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbChickenBrg_Click(object sender, EventArgs e)
        {
            dBalance -= 5.39;
            update_balance();
            textBox2.Text += "You bought 1 McChicken.\r\n";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOneDollar_Click(object sender, EventArgs e)
        {
            dBalance += 1.0;
            update_balance();
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFiveDollars_Click(object sender, EventArgs e)
        {
            dBalance += 5.0;
            update_balance();
        }

        private void btnTenDollars_Click(object sender, EventArgs e)
        {
            dBalance += 10.0;
            update_balance();
        }

        private void btnTwenDollars_Click(object sender, EventArgs e)
        {
            dBalance += 20.0;
            update_balance();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void pbBigMac_Click(object sender, EventArgs e)
        {
            dBalance -= 2.25;
            update_balance();
            textBox2.Text += "You bought 1 Big Mac.\r\n";
        }

        private void pbQuarterPounder_Click(object sender, EventArgs e)
        {
            dBalance -= 3.79;
            update_balance();
            textBox2.Text += "You bought 1 Quarter Pounder.\r\n";
        }

        private void pbChickenNugget_Click(object sender, EventArgs e)
        {
            dBalance -= 5.59;
            update_balance();
            textBox2.Text += "You bought 6 Chicken McNuggets.\r\n";
        }

        private void pbMilkshake_Click(object sender, EventArgs e)
        {
            dBalance -= 2.21;
            update_balance();
            textBox2.Text += "You bought 1 Milkshake.\r\n";
        }

        //private void btnLeftOver_Click(object sender, EventArgs e)
        //{
            //textBox2.Text += "Your leftover is" + dBalance.ToString("n2") + "\r\n";
            //dBalance = 0;
            //update_balance();
        //}
        
        private void btnLeftOver_Click(object sender, EventArgs e)
        {
            double count_of_coin = 0;
            count_of_coin = (double)(Math.Round(dBalance, 2) / 2.0);
            if (count_of_coin  > 0)
            {
                textBox2.Text += "Tooney: \t" + count_of_coin + "\r\n";
            }
            dBalance -= count_of_coin * 2.0;
            update_balance();

            count_of_coin = (double)(Math.Round(dBalance, 2) / 1.0);
            if (count_of_coin > 0)
            {
                textBox2.Text += "Looney: \t" + count_of_coin + "\r\n";
            }
            dBalance -= count_of_coin * 1.0;
            update_balance();

            count_of_coin = (double)(Math.Round(dBalance, 2) / 0.25);
            if (count_of_coin > 0)
            {
                textBox2.Text += "Quarter: \t" + count_of_coin + "\r\n";
            }
            dBalance -= count_of_coin * 0.25;
            update_balance();

            count_of_coin = (double)(Math.Round(dBalance, 2) / 0.1);
            if (count_of_coin > 0)
            {
                textBox2.Text += "Dime: \t" + count_of_coin + "\r\n";
            }
            dBalance -= count_of_coin * 0.1;
            update_balance();
        }

        private void pbFries_Click(object sender, EventArgs e)
        {
            dBalance -= 1.5;
            update_balance();
            textBox2.Text += "You bought 1 French fries. \r\n";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
