namespace Calculator
{
    partial class calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.close = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.TextBox();
            this.operand = new System.Windows.Forms.TextBox();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multplication = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.close.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("A Jannat LT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.GrayText;
            this.close.Location = new System.Drawing.Point(342, -2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(41, 44);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.minimize.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("A Jannat LT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.SystemColors.GrayText;
            this.minimize.Location = new System.Drawing.Point(295, -9);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(41, 51);
            this.minimize.TabIndex = 2;
            this.minimize.Text = "_";
            this.minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // equation
            // 
            this.equation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.equation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.equation.Location = new System.Drawing.Point(12, 62);
            this.equation.Multiline = true;
            this.equation.Name = "equation";
            this.equation.ReadOnly = true;
            this.equation.Size = new System.Drawing.Size(360, 25);
            this.equation.TabIndex = 0;
            this.equation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // operand
            // 
            this.operand.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.operand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.operand.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operand.ForeColor = System.Drawing.Color.Black;
            this.operand.Location = new System.Drawing.Point(12, 93);
            this.operand.Multiline = true;
            this.operand.Name = "operand";
            this.operand.ReadOnly = true;
            this.operand.Size = new System.Drawing.Size(360, 44);
            this.operand.TabIndex = 3;
            this.operand.Text = "0";
            this.operand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.two.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.two.FlatAppearance.BorderSize = 0;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(92, 284);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(76, 52);
            this.two.TabIndex = 5;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.three.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.three.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.three.FlatAppearance.BorderSize = 0;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(174, 284);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(76, 52);
            this.three.TabIndex = 6;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.four.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.four.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.four.FlatAppearance.BorderSize = 0;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(10, 226);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(76, 52);
            this.four.TabIndex = 7;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.five.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.five.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.five.FlatAppearance.BorderSize = 0;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(92, 226);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(76, 52);
            this.five.TabIndex = 8;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.six.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.six.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.six.FlatAppearance.BorderSize = 0;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(174, 226);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(76, 52);
            this.six.TabIndex = 9;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.seven.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.seven.FlatAppearance.BorderSize = 0;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(10, 168);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(76, 52);
            this.seven.TabIndex = 10;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.one_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.eight.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.eight.FlatAppearance.BorderSize = 0;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(92, 168);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(76, 52);
            this.eight.TabIndex = 11;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nine.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.nine.FlatAppearance.BorderSize = 0;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(174, 168);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(76, 52);
            this.nine.TabIndex = 12;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.eight_Click);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CE.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.CE.FlatAppearance.BorderSize = 0;
            this.CE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE.Location = new System.Drawing.Point(256, 168);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(59, 52);
            this.CE.TabIndex = 13;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.C.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.C.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.C.FlatAppearance.BorderSize = 0;
            this.C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(321, 168);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(59, 52);
            this.C.TabIndex = 14;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.division.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.division.FlatAppearance.BorderSize = 0;
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(321, 226);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(59, 52);
            this.division.TabIndex = 16;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // multplication
            // 
            this.multplication.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.multplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.multplication.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.multplication.FlatAppearance.BorderSize = 0;
            this.multplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multplication.Location = new System.Drawing.Point(256, 226);
            this.multplication.Name = "multplication";
            this.multplication.Size = new System.Drawing.Size(59, 52);
            this.multplication.TabIndex = 15;
            this.multplication.Text = "X";
            this.multplication.UseVisualStyleBackColor = false;
            this.multplication.Click += new System.EventHandler(this.multplication_Click);
            // 
            // subtraction
            // 
            this.subtraction.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.subtraction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.subtraction.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.subtraction.FlatAppearance.BorderSize = 0;
            this.subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtraction.Location = new System.Drawing.Point(321, 284);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(59, 52);
            this.subtraction.TabIndex = 18;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = false;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // addition
            // 
            this.addition.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addition.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.addition.FlatAppearance.BorderSize = 0;
            this.addition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition.Location = new System.Drawing.Point(256, 284);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(59, 52);
            this.addition.TabIndex = 17;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = false;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.result.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.result.FlatAppearance.BorderSize = 0;
            this.result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(256, 342);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(124, 52);
            this.result.TabIndex = 19;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = false;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(174, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 52);
            this.button1.TabIndex = 22;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(10, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 52);
            this.button3.TabIndex = 20;
            this.button3.Text = "+-";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.one.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.one.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.one.FlatAppearance.BorderSize = 0;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(10, 284);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(76, 52);
            this.one.TabIndex = 23;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.zero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.zero.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.zero.FlatAppearance.BorderSize = 0;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(92, 343);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(76, 52);
            this.zero.TabIndex = 24;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 402);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.one);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multplication);
            this.Controls.Add(this.C);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.operand);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.equation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "calculator";
            this.Text = "calculator";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.TextBox equation;
        private System.Windows.Forms.TextBox operand;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multplication;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button zero;
    }
}

