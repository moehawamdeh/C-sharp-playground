namespace diceGame
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
            this.components = new System.ComponentModel.Container();
            this.Computer = new System.Windows.Forms.GroupBox();
            this.computerDice2 = new System.Windows.Forms.PictureBox();
            this.computerDice1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userDice2 = new System.Windows.Forms.PictureBox();
            this.userDice1 = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.Button();
            this.roll = new System.Windows.Forms.Button();
            this.tryAgain = new System.Windows.Forms.Label();
            this.rolls = new System.Windows.Forms.Label();
            this.rollsLabel = new System.Windows.Forms.Label();
            this.delayTimer = new System.Windows.Forms.Timer(this.components);
            this.Computer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDice1)).BeginInit();
            this.SuspendLayout();
            // 
            // Computer
            // 
            this.Computer.BackColor = System.Drawing.Color.Transparent;
            this.Computer.Controls.Add(this.computerDice2);
            this.Computer.Controls.Add(this.computerDice1);
            this.Computer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Computer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Computer.Location = new System.Drawing.Point(12, 120);
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(206, 426);
            this.Computer.TabIndex = 0;
            this.Computer.TabStop = false;
            this.Computer.Text = "Computer";
            this.Computer.Visible = false;
            // 
            // computerDice2
            // 
            this.computerDice2.InitialImage = null;
            this.computerDice2.Location = new System.Drawing.Point(17, 231);
            this.computerDice2.Name = "computerDice2";
            this.computerDice2.Size = new System.Drawing.Size(166, 150);
            this.computerDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerDice2.TabIndex = 1;
            this.computerDice2.TabStop = false;
            // 
            // computerDice1
            // 
            this.computerDice1.InitialImage = null;
            this.computerDice1.Location = new System.Drawing.Point(17, 48);
            this.computerDice1.Name = "computerDice1";
            this.computerDice1.Size = new System.Drawing.Size(166, 150);
            this.computerDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerDice1.TabIndex = 0;
            this.computerDice1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(229, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dice Match Game";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userDice2
            // 
            this.userDice2.BackColor = System.Drawing.Color.Transparent;
            this.userDice2.InitialImage = null;
            this.userDice2.Location = new System.Drawing.Point(521, 351);
            this.userDice2.Name = "userDice2";
            this.userDice2.Size = new System.Drawing.Size(166, 150);
            this.userDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userDice2.TabIndex = 3;
            this.userDice2.TabStop = false;
            this.userDice2.Visible = false;
            this.userDice2.Click += new System.EventHandler(this.userDice2_Click);
            // 
            // userDice1
            // 
            this.userDice1.BackColor = System.Drawing.Color.Transparent;
            this.userDice1.InitialImage = null;
            this.userDice1.Location = new System.Drawing.Point(521, 168);
            this.userDice1.Name = "userDice1";
            this.userDice1.Size = new System.Drawing.Size(166, 150);
            this.userDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userDice1.TabIndex = 2;
            this.userDice1.TabStop = false;
            this.userDice1.Visible = false;
            this.userDice1.Click += new System.EventHandler(this.userDice1_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.LightGray;
            this.play.Location = new System.Drawing.Point(301, 168);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(126, 57);
            this.play.TabIndex = 4;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // roll
            // 
            this.roll.BackColor = System.Drawing.Color.LightGray;
            this.roll.Enabled = false;
            this.roll.Location = new System.Drawing.Point(301, 252);
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(126, 57);
            this.roll.TabIndex = 5;
            this.roll.Text = "Roll";
            this.roll.UseVisualStyleBackColor = false;
            this.roll.Click += new System.EventHandler(this.roll_Click);
            // 
            // tryAgain
            // 
            this.tryAgain.BackColor = System.Drawing.Color.Transparent;
            this.tryAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tryAgain.Location = new System.Drawing.Point(224, 351);
            this.tryAgain.Name = "tryAgain";
            this.tryAgain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tryAgain.Size = new System.Drawing.Size(300, 36);
            this.tryAgain.TabIndex = 7;
            this.tryAgain.Text = "<< Try again >> !";
            this.tryAgain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tryAgain.Visible = false;
            this.tryAgain.Click += new System.EventHandler(this.tryAgain_Click);
            // 
            // rolls
            // 
            this.rolls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rolls.AutoSize = true;
            this.rolls.BackColor = System.Drawing.Color.Transparent;
            this.rolls.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolls.ForeColor = System.Drawing.Color.White;
            this.rolls.Location = new System.Drawing.Point(335, 407);
            this.rolls.Name = "rolls";
            this.rolls.Size = new System.Drawing.Size(53, 58);
            this.rolls.TabIndex = 8;
            this.rolls.Text = "1";
            this.rolls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rolls.Visible = false;
            // 
            // rollsLabel
            // 
            this.rollsLabel.AutoSize = true;
            this.rollsLabel.BackColor = System.Drawing.Color.Transparent;
            this.rollsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rollsLabel.Location = new System.Drawing.Point(308, 475);
            this.rollsLabel.Name = "rollsLabel";
            this.rollsLabel.Size = new System.Drawing.Size(118, 36);
            this.rollsLabel.TabIndex = 9;
            this.rollsLabel.Text = "rolls left";
            this.rollsLabel.Visible = false;
            // 
            // delayTimer
            // 
            this.delayTimer.Interval = 2000;
            this.delayTimer.Tick += new System.EventHandler(this.delayTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::diceGame.Properties.Resources.red_background_6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 564);
            this.Controls.Add(this.rollsLabel);
            this.Controls.Add(this.rolls);
            this.Controls.Add(this.tryAgain);
            this.Controls.Add(this.roll);
            this.Controls.Add(this.play);
            this.Controls.Add(this.userDice2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userDice1);
            this.Controls.Add(this.Computer);
            this.Name = "Form1";
            this.Text = "Dice Match Game";
            this.Computer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.computerDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Computer;
        private System.Windows.Forms.PictureBox computerDice1;
        private System.Windows.Forms.PictureBox computerDice2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox userDice2;
        private System.Windows.Forms.PictureBox userDice1;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button roll;
        private System.Windows.Forms.Label tryAgain;
        private System.Windows.Forms.Label rolls;
        private System.Windows.Forms.Label rollsLabel;
        private System.Windows.Forms.Timer delayTimer;
    }
}

