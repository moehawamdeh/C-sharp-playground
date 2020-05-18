using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cashier_GUI
{
    public partial class Cashier : Form
    {
        private ItemList list;
        public Cashier()
        {
            list = new ItemList();
            InitializeComponent();
   
        }

        private void pizza_Click(object sender, EventArgs e)
        {

            listBox2.Items.Add("pizza         " +1.00);
            list.addItem("pizza", 1.00);
        }

        private void hotdog_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("hotdog      " + 1.00);
            list.addItem("hotdog", 1.00);
        }

        private void tea_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("tea            " + 0.30);
            list.addItem("tea", 0.30);
        }

        private void jouice_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("juice          " + 0.60);
            list.addItem("juice", 0.60);
        }

        private void coffe_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("coffee       " + 0.50);
            list.addItem("coffee", 0.50);
        }

        private void salad_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("salad         " + 0.70);
            list.addItem("salad", 0.70);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Total.Text=list.totalSale().ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            list = null;
            list = new ItemList();
            Total.Text = "";
        }

        private void Total_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
