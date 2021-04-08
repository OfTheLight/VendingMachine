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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dBalance -= 5.39;
            update_balance();
            textBox2.Text = "You bought 1 McChicken.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dBalance += 1.0;
            update_balance();
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dBalance += 5.0;
            update_balance();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dBalance += 10.0;
            update_balance();
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dBalance -= 2.25;
            update_balance();
            textBox2.Text = "You bought 1 Big Mac.";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dBalance -= 3.79;
            update_balance();
            textBox2.Text = "You bought 1 Quarter Pounder.";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            dBalance -= 5.59;
            update_balance();
            textBox2.Text = "You bought 6 Chicken McNuggets.";
        }

        private void pbMilkshake_Click(object sender, EventArgs e)
        {
            dBalance -= 2.21;
            update_balance();
            textBox2.Text = "You bought 1 Milkshake.";
        }
    }
}
