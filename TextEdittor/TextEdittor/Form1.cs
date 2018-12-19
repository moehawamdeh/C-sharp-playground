using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextEdittor
{
    public partial class Form1 : Form
    {
        private string saveAsText;
        bool saved;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveAsText = "";
            saved = true;
            saveToolStripMenuItem.Enabled = false;
        }
        private void readFile(string name)
        {
            StreamReader read = new StreamReader(name);
            textArea.Text = read.ReadToEnd();
            this.Text = saveAsText = name;
            read.Close();
            saved = true;
            saveToolStripMenuItem.Enabled = false;
        }
        private void writeFile(string name)
        {
            StreamWriter write = new StreamWriter(name);
            foreach(string line in textArea.Lines)
            write.WriteLine(line);
            write.Close();
        }
        private DialogResult saveCurrentOrNot()
        {
            return MessageBox.Show("save current file before closing ?", "not saved", MessageBoxButtons.YesNoCancel);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (System.Windows.Forms.DialogResult.OK == openFile.ShowDialog())
            {
                //check if current is saved
                if (!saved)
                    switch (saveCurrentOrNot())
                    {
                        case System.Windows.Forms.DialogResult.Yes:
                            {
                                if (saveAsText != "")
                                    writeFile(saveAsText);
                                else
                                {
                                    if (saveAs.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                        writeFile(saveAs.FileName);
                                }
                                //now open it
                                readFile(openFile.FileName);
                                this.Text = openFile.FileName;
                                break;
                            }
                        case System.Windows.Forms.DialogResult.No:
                            {
                                //if not just open
                                readFile(openFile.FileName);
                                this.Text = openFile.FileName;
                                break;
                            }
                            //if cancel then nothing
                    }
                else // IF CURRENT  is saved then just open
                {
                    readFile(openFile.FileName);
                    this.Text = openFile.FileName;
                }
            }
        }

       

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveAsText != "")
                writeFile(saveAsText);
            else
            {
                if (saveAs.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    writeFile(saveAs.FileName);
                this.Text = saveAs.FileName;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveAs.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                writeFile(saveAs.FileName);
            this.Text = saveAs.FileName;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!saved)
                switch (saveCurrentOrNot())
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        {
                            if (saveAsText != "")
                                writeFile(saveAsText);
                            else
                            {
                                if (saveAs.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                    writeFile(saveAs.FileName);
                            }
                            //now open it
                            saveAsText = "";
                            saveToolStripMenuItem.Enabled = false ;
                            saved = true;
                            textArea.Text = "";
                            this.Text = "NewCPE360text";
                            break;
                        }
                    case System.Windows.Forms.DialogResult.No:
                        {
                            //if not just open
                            saveAsText = "";
                            saveToolStripMenuItem.Enabled =false;
                            saved =true;
                            textArea.Text = "";
                            this.Text = "NewCPE360text";
                            break;
                        }
                        //if cancel then nothing
                }
            else // IF CURRENT  is saved then just open new cpe360file
            {
                saveAsText = "";
                saved = false;
                saveToolStripMenuItem.Enabled = true;
                textArea.Text = "";
                this.Text = "NewCPE360text";
            }
            
        }

        private void textArea_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            saveToolStripMenuItem.Enabled = true;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved)
                this.Close();
            else
            {
                switch (saveCurrentOrNot())
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        {
                            if (saveAsText != "")
                                writeFile(saveAsText);
                            else
                            {
                                if (saveAs.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                    writeFile(saveAs.FileName);
                            }
                            
                            this.Close();
                            break;
                        }
                    case System.Windows.Forms.DialogResult.No:
                        {
                            this.Close();
                            break;
                        }
                        //if cancel then nothing
                }
            }
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font f = new Font("Times New Roman", 11 , textArea.Font.Style );
            textArea.Font = f;
        }

        private void garamondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font f = new Font("Garamond", 11, textArea.Font.Style);
            textArea.Font = f;
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font f = new Font("Arial", 11, textArea.Font.Style);
            textArea.Font = f;
        }

        private void georgiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font f = new Font("Georhia", 11, textArea.Font.Style);
            textArea.Font = f;
        }

        private void incrementBy2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font f = new Font(textArea.Font.FontFamily, textArea.Font.Size+2 , textArea.Font.Style);
            textArea.Font = f;
        }

        private void decrementBy2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textArea.Font.Size > 2)
            {
                Font f = new Font(textArea.Font.FontFamily, textArea.Font.Size - 2, textArea.Font.Style);
                textArea.Font = f;
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Font f = new Font(textArea.Font.FontFamily, 16, textArea.Font.Style);
            textArea.Font = f;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Font f = new Font(textArea.Font.FontFamily,12, textArea.Font.Style);
            textArea.Font = f;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Font f = new Font(textArea.Font.FontFamily,10, textArea.Font.Style);
            textArea.Font = f;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Font f = new Font(textArea.Font.FontFamily,8, textArea.Font.Style);
            textArea.Font = f;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.ForeColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.ForeColor = Color.Blue;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.ForeColor = Color.Yellow;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.ForeColor = Color.Green;
        }

        private void maroonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.ForeColor = Color.Maroon;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.ForeColor = Color.Black;
        }

        private void resetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Font f = new Font("Consolas", textArea.Font.Size, textArea.Font.Style);
            textArea.Font = f;
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textArea.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textArea.BackColor = Color.Green;
        }

        private void yellowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textArea.BackColor = Color.Yellow;
        }

        private void maroonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textArea.BackColor = Color.Maroon;
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textArea.BackColor = Color.Blue;
        }

        private void resetToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textArea.BackColor = Color.White;
        }

        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.BackColor = Color.White;
            textArea.ForeColor = Color.Black;
            Font f = new Font("Consolas", 11, FontStyle.Regular);
            textArea.Font = f;

            
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font f = new Font(textArea.Font.FontFamily, textArea.Font.Size, FontStyle.Bold);
            textArea.Font = f;
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font f = new Font(textArea.Font.FontFamily, textArea.Font.Size, FontStyle.Regular);
            textArea.Font = f;
        }

        private void italyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font f = new Font(textArea.Font.FontFamily, textArea.Font.Size, FontStyle.Italic);
            textArea.Font = f;
        }


        private void drakulaModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem sub in menu.Items)
                foreach (ToolStripDropDownItem subsub in sub.DropDownItems)
                {
                    subsub.BackColor = Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
                   subsub.ForeColor = Color.WhiteSmoke;
                    foreach (ToolStripDropDownItem child in subsub.DropDownItems)
                    {
                        child.BackColor = Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
                        child.ForeColor = Color.WhiteSmoke;
                    }
        }
                    
            textArea.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            textArea.ForeColor = Color.White;
            menu.BackColor = Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            menu.ForeColor = Color.WhiteSmoke;
            this.BackColor = Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.ForeColor = Color.WhiteSmoke;

        }

        private void daylightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem sub in menu.Items)
                foreach (ToolStripDropDownItem subsub in sub.DropDownItems)
                {
                    subsub.BackColor = System.Drawing.SystemColors.Control;
                    subsub.ForeColor = Color.Black;
                    foreach (ToolStripDropDownItem child in subsub.DropDownItems)
                    {
                        child.BackColor = System.Drawing.SystemColors.Control;
                        child.ForeColor = Color.Black;
                    }
                }
            textArea.BackColor = Color.White; 
            textArea.ForeColor = Color.Black;
            menu.BackColor = System.Drawing.SystemColors.Control;
            menu.ForeColor = Color.Black;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ForeColor = Color.Black;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
