using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace paintApp
{
    class GraphicLists
    {
        public List<Point> pointsList;
        public List<Point> brushStrokesList;
        public List<Rectangle> rectsList;
        public List<Rectangle> circlesList;
        public List<Line> linesList;
        public GraphicLists()
        {
            pointsList = new List<Point>();
            brushStrokesList = new List<Point>();
            linesList = new List<Line>();
            rectsList = new List<Rectangle>();
            circlesList = new List<Rectangle>();
        }
    }
    class Rectangle
    {
        public Point location;
        public Size size;
        public Color color;
        public Rectangle()
        {

        }
        public Rectangle(Point location, int hieght, int width)
        {
            this.location = location;
            this.size.Width = hieght;
            this.size.Height = width;
        }
    }
    class Line
    {
        public Point start, end;
        public Color color;
        public Line(Point s,Point e,Color c)
        {
            this.start = s;
            end = e;
            color = c;
        }
    }
}
