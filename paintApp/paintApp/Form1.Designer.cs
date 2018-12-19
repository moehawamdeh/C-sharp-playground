namespace paintApp
{
    partial class Form1
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
            this.panel = new System.Windows.Forms.Panel();
            this.penButton = new System.Windows.Forms.Button();
            this.brushButton = new System.Windows.Forms.Button();
            this.circButton = new System.Windows.Forms.Button();
            this.rectButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(88, 118);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(959, 599);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // penButton
            // 
            this.penButton.BackgroundImage = global::paintApp.Properties.Resources.Pen;
            this.penButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.penButton.Location = new System.Drawing.Point(12, 143);
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(53, 45);
            this.penButton.TabIndex = 1;
            this.penButton.UseVisualStyleBackColor = true;
            this.penButton.Click += new System.EventHandler(this.penButton_Click);
            // 
            // brushButton
            // 
            this.brushButton.BackgroundImage = global::paintApp.Properties.Resources.Brush;
            this.brushButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brushButton.Location = new System.Drawing.Point(12, 194);
            this.brushButton.Name = "brushButton";
            this.brushButton.Size = new System.Drawing.Size(53, 45);
            this.brushButton.TabIndex = 2;
            this.brushButton.UseVisualStyleBackColor = true;
            this.brushButton.Click += new System.EventHandler(this.brushButton_Click);
            // 
            // circButton
            // 
            this.circButton.BackgroundImage = global::paintApp.Properties.Resources.Circle;
            this.circButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circButton.Location = new System.Drawing.Point(12, 305);
            this.circButton.Name = "circButton";
            this.circButton.Size = new System.Drawing.Size(53, 45);
            this.circButton.TabIndex = 4;
            this.circButton.UseVisualStyleBackColor = true;
            this.circButton.Click += new System.EventHandler(this.circButton_Click);
            // 
            // rectButton
            // 
            this.rectButton.BackgroundImage = global::paintApp.Properties.Resources.Rectangle;
            this.rectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectButton.Location = new System.Drawing.Point(12, 245);
            this.rectButton.Name = "rectButton";
            this.rectButton.Size = new System.Drawing.Size(53, 45);
            this.rectButton.TabIndex = 3;
            this.rectButton.UseVisualStyleBackColor = true;
            this.rectButton.Click += new System.EventHandler(this.rectButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.BackgroundImage = global::paintApp.Properties.Resources.Line;
            this.lineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lineButton.Location = new System.Drawing.Point(12, 356);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(53, 45);
            this.lineButton.TabIndex = 5;
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // black
            // 
            this.black.BackgroundImage = global::paintApp.Properties.Resources.Black;
            this.black.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.black.Location = new System.Drawing.Point(196, 27);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(98, 68);
            this.black.TabIndex = 6;
            this.black.UseVisualStyleBackColor = true;
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // red
            // 
            this.red.BackgroundImage = global::paintApp.Properties.Resources.Red;
            this.red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.red.Location = new System.Drawing.Point(335, 27);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(98, 68);
            this.red.TabIndex = 7;
            this.red.UseVisualStyleBackColor = true;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // green
            // 
            this.green.BackgroundImage = global::paintApp.Properties.Resources.Green;
            this.green.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.green.Location = new System.Drawing.Point(470, 27);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(98, 68);
            this.green.TabIndex = 8;
            this.green.UseVisualStyleBackColor = true;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // blue
            // 
            this.blue.BackgroundImage = global::paintApp.Properties.Resources.Blue;
            this.blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blue.Location = new System.Drawing.Point(604, 27);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(98, 68);
            this.blue.TabIndex = 9;
            this.blue.UseVisualStyleBackColor = true;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 744);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.green);
            this.Controls.Add(this.red);
            this.Controls.Add(this.black);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.circButton);
            this.Controls.Add(this.rectButton);
            this.Controls.Add(this.brushButton);
            this.Controls.Add(this.penButton);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button penButton;
        private System.Windows.Forms.Button brushButton;
        private System.Windows.Forms.Button circButton;
        private System.Windows.Forms.Button rectButton;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button black;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button blue;
    }
}

