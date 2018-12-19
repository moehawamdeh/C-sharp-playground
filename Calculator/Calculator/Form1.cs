using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calculator : Form
    {
        private string fullEquation,currentOperand;
        private bool flag_operand1,flag_operator,flag_operand2;
        public calculator()
        {
            flag_operand1 = true;
            flag_operator = flag_operand2=false;
            InitializeComponent();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void zero_Click(object sender, EventArgs e)
        {
            currentOperand = operand.Text = zero.Text;
            if (flag_operator)
                fullEquation = fullEquation.Remove(fullEquation.Length - 1);
            fullEquation = fullEquation + currentOperand;
            equation.Text = fullEquation;
            flag_operator = true;
            if (flag_operand1)
                flag_operand1 = false;
        }
        private void one_Click(object sender, EventArgs e)
        {
            currentOperand = operand.Text =  one.Text;
            if (flag_operator)
                fullEquation = fullEquation.Remove(fullEquation.Length - 1);
            fullEquation = fullEquation + currentOperand;
            equation.Text = fullEquation;
            flag_operator = true;
            if (flag_operand1)
                flag_operand1 = false;
        }
        private void two_Click(object sender, EventArgs e)
        {
            currentOperand = operand.Text = two.Text;
            if (flag_operator)
                fullEquation = fullEquation.Remove(fullEquation.Length - 1);
            fullEquation = fullEquation + currentOperand;
            equation.Text = fullEquation;
            flag_operator = true;
            if (flag_operand1)
                flag_operand1 = false;
        }
        private void three_Click(object sender, EventArgs e)
        {
            currentOperand = operand.Text=three.Text;
           if(flag_operator)
             fullEquation = fullEquation.Remove(fullEquation.Length - 1);
            fullEquation = fullEquation + currentOperand;
            equation.Text = fullEquation;
            flag_operator = true;
            if (flag_operand1)
                flag_operand1 = false;
        }
        private void four_Click(object sender, EventArgs e)
        {
            currentOperand = operand.Text = four.Text;
            if (flag_operator)
                fullEquation = fullEquation.Remove(fullEquation.Length - 1);
            fullEquation = fullEquation + currentOperand;
            equation.Text = fullEquation;
            flag_operator = true;
            if (flag_operand1)
                flag_operand1 = false;
        }
        private void five_Click(object sender, EventArgs e)
        {
            currentOperand = operand.Text = five.Text;
            if (flag_operator)
                fullEquation = fullEquation.Remove(fullEquation.Length - 1);
            fullEquation = fullEquation + currentOperand;
            equation.Text = fullEquation;
            flag_operator = true;
            if (flag_operand1)
                flag_operand1 = false;
        }
        private void six_Click(object sender, EventArgs e)
        {
            currentOperand = operand.Text = six.Text;
            if (flag_operator)
                fullEquation = fullEquation.Remove(fullEquation.Length - 1);
            fullEquation = fullEquation + currentOperand;
            equation.Text = fullEquation;
            flag_operator = true;
            if (flag_operand1)
                flag_operand1 = false;
        }
        private void seven_Click(object sender, EventArgs e)
        {
            currentOperand = operand.Text = seven.Text;
            if (flag_operator)
                fullEquation = fullEquation.Remove(fullEquation.Length - 1);
            fullEquation = fullEquation + currentOperand;
            equation.Text = fullEquation;
            flag_operator = true;
            if (flag_operand1)
                flag_operand1 = false;
        }
        private void eight_Click(object sender, EventArgs e)
        {
            currentOperand = operand.Text = eight.Text;
            if (flag_operator)
                fullEquation = fullEquation.Remove(fullEquation.Length - 1);
            fullEquation = fullEquation + currentOperand;
            equation.Text = fullEquation;
            flag_operator = true;
            if (flag_operand1)
                flag_operand1 = false;
        }
        private void nine_Click(object sender, EventArgs e)
        {
            currentOperand = operand.Text = nine.Text;
            if (flag_operator)
                fullEquation = fullEquation.Remove(fullEquation.Length - 1);
            fullEquation = fullEquation + currentOperand;
            equation.Text = fullEquation;
            flag_operator = true;
            if (flag_operand1)
                flag_operand1 = false;
        }
        private void multplication_Click(object sender, EventArgs e)
        {
            if(flag_operand1)
                MessageBox.Show("a digit is needed before", "wrong input", System.Windows.Forms.MessageBoxButtons.OK);
            else if(fullEquation.Length !=3)
            {
                if(flag_operand2)
                    fullEquation = fullEquation.Remove(fullEquation.Length - 1);
                fullEquation = fullEquation + "*";
                equation.Text = fullEquation;
                flag_operand2 = true;
                flag_operator = false;
            }
            else MessageBox.Show("you cannot add more than one expression", "wrong input", System.Windows.Forms.MessageBoxButtons.OK);

        }
        private void division_Click(object sender, EventArgs e)
        {
            if (flag_operand1)
                MessageBox.Show("a digit is needed before", "wrong input", System.Windows.Forms.MessageBoxButtons.OK);
            else if (fullEquation.Length != 3)
            {
                if (flag_operand2)
                    fullEquation = fullEquation.Remove(fullEquation.Length - 1);
                fullEquation = fullEquation + "/";
                equation.Text = fullEquation;
                flag_operand2 = true;
                flag_operator = false;
            }
            else MessageBox.Show("you cannot add more than one expression", "wrong input", System.Windows.Forms.MessageBoxButtons.OK);

        }
        private void subtraction_Click(object sender, EventArgs e)
        {
            if (flag_operand1)
                MessageBox.Show("a digit is needed before", "wrong input", System.Windows.Forms.MessageBoxButtons.OK);
            else if (fullEquation.Length != 3)
            {
                if (flag_operand2)
                    fullEquation = fullEquation.Remove(fullEquation.Length - 1);
                fullEquation = fullEquation + "-";
                equation.Text = fullEquation;
                flag_operand2 = true;
                flag_operator = false;
            }
            else MessageBox.Show("you cannot add more than one expression", "wrong input", System.Windows.Forms.MessageBoxButtons.OK);

        }
        private void addition_Click(object sender, EventArgs e)
        {
            if (flag_operand1)
                MessageBox.Show("a digit is needed before", "wrong input", System.Windows.Forms.MessageBoxButtons.OK);
            else if (fullEquation.Length != 3)
            {
                if (flag_operand2)
                    fullEquation = fullEquation.Remove(fullEquation.Length - 1);
                fullEquation = fullEquation + "+";
                equation.Text = fullEquation;
                flag_operand2 = true;
                flag_operator = false;
            }
            else MessageBox.Show("you cannot add more than one expression", "wrong input", System.Windows.Forms.MessageBoxButtons.OK);

        }

        private void C_Click(object sender, EventArgs e)
        {
            operand.Text = "0";
            currentOperand = fullEquation = equation.Text = "";
            flag_operand1 = true;
            flag_operand2 = flag_operator = false;
        }

        private void CE_Click(object sender, EventArgs e)
        {
            currentOperand = operand.Text = "0";
        }

   

        private void result_Click(object sender, EventArgs e)
        {
            if (fullEquation.Length == 3)
            {
                try
                {

                    operand.Text = evaluateEquation(fullEquation);
                    currentOperand = fullEquation = equation.Text = "";
                    flag_operand1 = true;
                    flag_operand2 = flag_operator = false;
                
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "wrong division", System.Windows.Forms.MessageBoxButtons.OK);
                }
            }
            else MessageBox.Show("wrong expression :missing 2nd operand", "wrong input", System.Windows.Forms.MessageBoxButtons.OK);

        }

        private string evaluateEquation(string fullEquation)
        {
            char operation = fullEquation[1];
            switch(operation)
            {
                case '+':
                    {
                        return (fullEquation[0] -'0' + fullEquation[2]-'0').ToString();
                    }
                case '-':
                    {
                        return ((fullEquation[0] - '0') - (fullEquation[2] - '0')).ToString();
                    }
                case '/':
                    {
                        return ((fullEquation[0] - '0') / (fullEquation[2] - '0')).ToString();
                    }
                case '*':
                    {
                        return ((fullEquation[0] - '0') *( fullEquation[2] - '0')).ToString();
                    }
                default: { return ""; }
            }
        }

     
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //to enable form moving while no border
        protected override void OnMouseDown(MouseEventArgs e)

        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }
    }
}
