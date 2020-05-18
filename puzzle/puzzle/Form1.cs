using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace puzzle
{
    public partial class Form1 : Form
    {
        private static bool allowDrag = false;
        private static Point initialPos;
        private readonly Dictionary<string, Point> centersSet;
       public Form1()
        {
            InitializeComponent();
            //finding centers of boxes
            centersSet = new Dictionary<string, Point>();
            foreach (PictureBox box in PuzzleAreaGroup.Controls)
                centersSet.Add(box.Name,box.Location +(Size)new Point(box.Width/2,box.Height/2));
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            //randomizing 
                puzzleStart();
           // timer1.Start();
        }

        private void puzzleStart()
        {
            List<Int32> picked = new List<Int32>();
            Random rand = new Random();
            foreach (Control peice in this.Controls)
            {
                if (!peice.Name.Contains("peice"))
                    continue;
                int i;
                while (true)
                {
                    if (picked.Contains(i = rand.Next(1, 7)))
                        continue;
                    peice.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("p" + i);
                    picked.Add(i);
                    break;
                }
            }
        }
        private void MouseDown(object sender, MouseEventArgs e)
        {
            allowDrag = true;
            initialPos = e.Location;
            ((PictureBox)sender).BringToFront();
        }
        private void MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox thisPeice = ((PictureBox)sender);
            if (allowDrag)
                thisPeice.Location = new Point(thisPeice.Location.X + (e.X - initialPos.X), thisPeice.Location.Y + (e.Y - initialPos.Y));
        }
        private bool isInside(Point Start, Point End, Point p)
        {
            if (p.X > Start.X && p.Y > Start.Y)
                if (p.X < End.X && p.Y < End.Y)
                    return true;
            return false;
        }
        private void MouseUp(object sender, MouseEventArgs e)
        {
            if (allowDrag)
            {
                PictureBox thisPeice = ((PictureBox)sender);
                Point mousePos = e.Location + (Size)thisPeice.Location-(Size)PuzzleAreaGroup.Location;
                PictureBox placeHere = placeAt(mousePos);
                if (placeHere != null) //find nearest center and place it in it
                {
                    Image temp = thisPeice.BackgroundImage;
                    thisPeice.BackgroundImage = placeHere.BackgroundImage;
                    placeHere.BackgroundImage = temp;
                    Random rand = new Random();
                    thisPeice.Location = new Point(rand.Next(100, +this.Width-100), rand.Next(PuzzleAreaGroup.Height+ PuzzleAreaGroup.Location.Y+40, this.Height - 100));
                    thisPeice.BringToFront();
                }
            }
            allowDrag = false;
        }
        private PictureBox placeAt(Point mousePos)
        {
            //if its inside the area
            int distance = Int32.MaxValue;
            PictureBox nearest = null;
            if (isInside(p1.Location, p6.Location + p6.Size, mousePos))
                foreach (KeyValuePair<string,Point> box in centersSet)
                {
                    //distance between two points law
                    int d = (int)Math.Sqrt(Math.Pow(mousePos.X - box.Value.X, 2) + Math.Pow(mousePos.Y - box.Value.Y, 2));
                    //find nearest
                    if (d < distance)
                    {
                        distance = d;
                        nearest = (PictureBox)PuzzleAreaGroup.Controls[box.Key];
                    }
                }
                return nearest;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //bool win = true;
            //foreach(PictureBox p in PuzzleAreaGroup.Controls)
            //{
            //    try
            //    {
            //        Bitmap a = (Bitmap)p.BackgroundImage;
            //        Bitmap b = (Bitmap)Properties.Resources.ResourceManager.GetObject(p.Name);
            //        for (int w = 30; w < 60; w++)
            //            for (int h = 30; h < 60; h++)
            //                if (a.GetPixel(w, h) != b.GetPixel(w, h))
            //                    win = false;
            //    }
            //    catch (Exception E){  };
            //}
            //if (win == true)
            //{
            //    this.Enabled = false;

            //}
        }

        private void p_Click(object sender, EventArgs e)
        {
            PictureBox thisBoz = (PictureBox)sender;
            if (thisBoz.BackgroundImage != null)
            {
                foreach(Control a in this.Controls)
                {
                    if (a.Name.Contains("peice"))
                        if(a.BackgroundImage==null)
                        {
                            a.BackgroundImage = thisBoz.BackgroundImage;
                            thisBoz.BackgroundImage = null;
                            break;
                        }
                }
            }
        }

  
    }
}
