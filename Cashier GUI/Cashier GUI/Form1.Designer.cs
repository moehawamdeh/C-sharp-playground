namespace Cashier_GUI
{
    partial class Cashier
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.salad = new System.Windows.Forms.PictureBox();
            this.hotdog = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.jouice = new System.Windows.Forms.PictureBox();
            this.coffe = new System.Windows.Forms.PictureBox();
            this.tea = new System.Windows.Forms.PictureBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotdog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jouice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tea)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(55, 119);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(228, 308);
            this.listBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(73, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name                          Price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 442);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.salad);
            this.groupBox1.Controls.Add(this.hotdog);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(323, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(503, 158);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Food";
            // 
            // salad
            // 
            this.salad.Image = global::Cashier_GUI.Properties.Resources.Salata;
            this.salad.Location = new System.Drawing.Point(339, 23);
            this.salad.Margin = new System.Windows.Forms.Padding(4);
            this.salad.Name = "salad";
            this.salad.Size = new System.Drawing.Size(157, 123);
            this.salad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salad.TabIndex = 2;
            this.salad.TabStop = false;
            this.salad.Click += new System.EventHandler(this.salad_Click);
            // 
            // hotdog
            // 
            this.hotdog.Image = global::Cashier_GUI.Properties.Resources.HotDog;
            this.hotdog.Location = new System.Drawing.Point(173, 23);
            this.hotdog.Margin = new System.Windows.Forms.Padding(4);
            this.hotdog.Name = "hotdog";
            this.hotdog.Size = new System.Drawing.Size(157, 123);
            this.hotdog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hotdog.TabIndex = 1;
            this.hotdog.TabStop = false;
            this.hotdog.Click += new System.EventHandler(this.hotdog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "";
            this.pictureBox1.Image = global::Cashier_GUI.Properties.Resources.Pizz;
            this.pictureBox1.Location = new System.Drawing.Point(8, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            this.pictureBox1.Click += new System.EventHandler(this.pizza_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.jouice);
            this.groupBox2.Controls.Add(this.coffe);
            this.groupBox2.Controls.Add(this.tea);
            this.groupBox2.Location = new System.Drawing.Point(323, 261);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(503, 158);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drinks";
            // 
            // jouice
            // 
            this.jouice.Image = global::Cashier_GUI.Properties.Resources.Juce;
            this.jouice.Location = new System.Drawing.Point(339, 23);
            this.jouice.Margin = new System.Windows.Forms.Padding(4);
            this.jouice.Name = "jouice";
            this.jouice.Size = new System.Drawing.Size(157, 123);
            this.jouice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jouice.TabIndex = 5;
            this.jouice.TabStop = false;
            this.jouice.Click += new System.EventHandler(this.jouice_Click);
            // 
            // coffe
            // 
            this.coffe.Image = global::Cashier_GUI.Properties.Resources.Coffe;
            this.coffe.Location = new System.Drawing.Point(173, 23);
            this.coffe.Margin = new System.Windows.Forms.Padding(4);
            this.coffe.Name = "coffe";
            this.coffe.Size = new System.Drawing.Size(157, 123);
            this.coffe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coffe.TabIndex = 4;
            this.coffe.TabStop = false;
            this.coffe.Click += new System.EventHandler(this.coffe_Click);
            // 
            // tea
            // 
            this.tea.Image = global::Cashier_GUI.Properties.Resources.Tea;
            this.tea.Location = new System.Drawing.Point(8, 23);
            this.tea.Margin = new System.Windows.Forms.Padding(4);
            this.tea.Name = "tea";
            this.tea.Size = new System.Drawing.Size(157, 123);
            this.tea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tea.TabIndex = 3;
            this.tea.TabStop = false;
            this.tea.Click += new System.EventHandler(this.tea_Click);
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(378, 448);
            this.Total.Margin = new System.Windows.Forms.Padding(4);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(95, 22);
            this.Total.TabIndex = 5;
            this.Total.TextChanged += new System.EventHandler(this.Total_TextChanged);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalLabel.Location = new System.Drawing.Point(320, 448);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(40, 17);
            this.TotalLabel.TabIndex = 6;
            this.TotalLabel.Text = "Total";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(690, 442);
            this.reset.Margin = new System.Windows.Forms.Padding(4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(100, 28);
            this.reset.TabIndex = 7;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cashier_GUI.Properties.Resources.Print_Master;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 521);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotdog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jouice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox salad;
        private System.Windows.Forms.PictureBox hotdog;
        private System.Windows.Forms.PictureBox jouice;
        private System.Windows.Forms.PictureBox coffe;
        private System.Windows.Forms.PictureBox tea;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button reset;
    }
}

