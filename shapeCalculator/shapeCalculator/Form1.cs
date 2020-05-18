using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace shapeCalculator
{
    public partial class Form1 : Form
    {
        Shape shape;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = shapeTabs.SelectedIndex.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox Area, Perimeter;
            try
            {
                switch (shapeTabs.SelectedIndex)
                {
                    case 0://rect
                        {
                            Perimeter = textBox2;
                            Area = textBox1;
                            shape = new Rectangle(0, 0, float.Parse(Rwidth.Text), float.Parse(Rheigth.Text));
                            Perimeter.Text = shape.findPerimeter().ToString();
                            Area.Text = shape.findArea().ToString();
                            break;
                        }
                    case 1://circ
                        {
                            Perimeter = textBox4;
                            Area = textBox3;
                            shape = new Circle(0, 0, float.Parse(Cradius.Text));
                            Perimeter.Text = shape.findPerimeter().ToString();
                            Area.Text = shape.findArea().ToString();
                            break;
                        }
                    case 2://tri
                        {
                            Perimeter = textBox8;
                            Area = textBox7;
                            shape = new Triangle(0, 0, float.Parse(TA.Text), float.Parse(TB.Text), float.Parse(TC.Text));
                            Perimeter.Text = shape.findPerimeter().ToString();
                            Area.Text = shape.findArea().ToString();
                            break;
                        }
                    case 3://Square
                        {
                            Perimeter = textBox6;
                            Area = textBox5;
                            shape = new Square(0, 0, float.Parse(Sheight.Text));
                            Perimeter.Text = shape.findPerimeter().ToString();
                            Area.Text = shape.findArea().ToString();
                            break;
                        }
                }
            }
            catch (Exception E) { };
        }

        private void tabRectangle_Click(object sender, EventArgs e)
        {

        }
    }
}
