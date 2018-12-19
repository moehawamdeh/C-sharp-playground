using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paintApp
{
    public partial class Form1 : Form
    {
        bool drawing;
        tools selectedTool;
        GraphicLists memory;
        private Point startPoint, endPoint;
        Graphics graphics;
        Color drawColor;
        float width;
        private readonly Point penEndPoint = new Point(-1, -1);
        public Form1()
        {
            InitializeComponent();
            drawing = false;
            selectedTool = 0;
            memory = new GraphicLists();
            startPoint = new Point(-1,-1);
            graphics = panel.CreateGraphics();
            drawColor = Color.Black;
            width = 1;
        }
        public enum tools
        {
            none=0,pen =1, brush =2,rectangle=3,circle=4,line=5
        }
        private void penButton_Click(object sender, EventArgs e)
        {
            selectedTool = tools.pen;
            Pen mypen = new Pen(drawColor, width);
           
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            startPoint = e.Location;
            //if (selectedTool == tools.pen || selectedTool == tools.brush)
            //{
            //    drawing = true;
                
            //}
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if(drawing)
            {
                if(selectedTool == tools.pen)
                {
                    Pen mypen = new Pen(drawColor, width);
                    graphics.DrawLine(mypen, startPoint, e.Location);
                    startPoint = e.Location;
                    memory.pointsList.Add(startPoint);
                }
                else if(selectedTool == tools.brush)
                    {
                    SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                    graphics.FillEllipse(myBrush, new System.Drawing.Rectangle(e.Location.X,e.Location.Y, 8, 8));
                    startPoint = e.Location;
                    memory.brushStrokesList.Add(startPoint);
                }// else if(selectedTool == tools.line)
                //{
                //    Pen mypen = new Pen(drawColor, width);
                //    endPoint = e.Location;
                //    graphics.DrawLine(mypen, startPoint, endPoint);
                //    panel.Refresh();
                //}else if(selectedTool == tools.rectangle)
                //{
                //    Rectangle rect = new Rectangle(startPoint, Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                //    rect.color = drawColor;
                //    Pen p = new Pen(rect.color, width);
                //    graphics.DrawRectangle(p, rect.location.X, rect.location.Y, rect.size.Width, rect.size.Height);

                //    panel.Refresh(); }
                
                

            }
        }
        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            if (selectedTool == tools.pen)
                memory.pointsList.Add(penEndPoint);
            else if (selectedTool == tools.brush)
                memory.brushStrokesList.Add(penEndPoint);
            else if (selectedTool == tools.line)
            {
                endPoint = e.Location;
                memory.linesList.Add(new Line(startPoint, endPoint, drawColor));
                panel.Refresh();
            }
            else if(selectedTool == tools.rectangle)
            {
                Rectangle r = new Rectangle(startPoint,Math.Abs(startPoint.X-e.X),Math.Abs(startPoint.Y-e.Y) );
                r.color = drawColor;
                memory.rectsList.Add(r);
                panel.Refresh();
            }else if(selectedTool == tools.circle)
            {
                Rectangle r = new Rectangle(startPoint, Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                r.color = drawColor;
                memory.circlesList.Add(r);
                panel.Refresh();
            }

        }
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics memoryGraphic = e.Graphics;
            //redraw points
            Pen p = new Pen(Color.Black, width);
            List<Point> points = memory.pointsList;
            for (int i = 0; i < points.Count - 1; i++)
            {
                if (memory.pointsList[i + 1] == penEndPoint)
                    memoryGraphic.DrawLine(p, points[i], points[i]);
                else if (memory.pointsList[i] == penEndPoint)
                    continue;
                else memoryGraphic.DrawLine(p, points[i], points[i + 1]);
            }
            p.Dispose();
            //
            //redraw brush
            SolidBrush myBrush = new System.Drawing.SolidBrush(Color.Black);
            points = memory.brushStrokesList;
            foreach (Point bp in memory.brushStrokesList)
                if (bp == penEndPoint)
                    continue;
            else memoryGraphic.FillEllipse(myBrush, new System.Drawing.Rectangle(bp.X, bp.Y, 8, 8));          
            myBrush.Dispose();
            // redraw lines
            foreach(Line line in memory.linesList)
            {
                p = new Pen(line.color, width);
                memoryGraphic.DrawLine(p, line.start, line.end);
               // p.Dispose();
            }
            //draw rect
            foreach(var rect in memory.rectsList)
            {
                p = new Pen(rect.color, width);
                memoryGraphic.DrawRectangle(p, rect.location.X, rect.location.Y, rect.size.Width, rect.size.Height);
                p.Dispose();
            }
            //circs
            foreach (var rect in memory.circlesList)
            {
                p = new Pen(rect.color, width);
                memoryGraphic.DrawEllipse(p, rect.location.X, rect.location.Y, rect.size.Width, rect.size.Height);
                p.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rectButton_Click(object sender, EventArgs e)
        {
            selectedTool = tools.rectangle;
        }

        private void circButton_Click(object sender, EventArgs e)
        {
            selectedTool = tools.circle;
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            selectedTool = tools.line;
        }

        private void blue_Click(object sender, EventArgs e)
        {
            drawColor = Color.Blue;
        }

        private void green_Click(object sender, EventArgs e)
        {
            drawColor = Color.Green;
        }

        private void red_Click(object sender, EventArgs e)
        {
            drawColor = Color.Red;
        }

        private void black_Click(object sender, EventArgs e)
        {
            drawColor = Color.Black;
        }

        private void brushButton_Click(object sender, EventArgs e)
        {
            selectedTool = tools.brush;
        }

      
    }
}
