using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shapeCalculator
{
    class Point
    {
        public float X, Y;
        public Point()
        {
            X = Y = -1;
        }
        public Point(float x,float y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    class Shape
    {
        protected float D1, D2, D3;
        protected Point Location;
        public Shape(float X, float Y,float D1,float D2=-1,float D3=-1)
        {
            Location = new Point(X, Y);
            this.D1 = D1;
            this.D2 = D2;
            this.D3 = D3; 
        }
        virtual public float findArea(){return 0;}
        virtual public float findPerimeter(){return 0;}
    }

    class Rectangle : Shape
    {
        public Rectangle(float x,float y,float width,float height):base(x,y,width,height){}
        override public float findPerimeter()
        {
 	        return 2*(D1+D2);
        }
        override public float findArea()
        {
            return D1 * D2;
        }
    }
    class Square:Shape
    {
        public Square(float x,float y,float sideLength):base(x,y,sideLength){}
        public override float findPerimeter()
        {
 	        return 4*D1;
        }
        public override float findArea()
        {
            return D1 * D1;
        }
    }

    class Circle : Shape
    {
        public Circle(float x, float y, float radius):base(x,y,radius)
        {

        }
        public override float findArea()
        {
            return (float)(2*Math.PI*Math.Pow(D1,2));
        }
        public override float findPerimeter()
        {
            return 2*(float)Math.PI*D1;
        }
    }

    class Triangle : Shape
    {
        public Triangle(float x, float y, float sideA, float sideB, float sideC) : base(x, y, sideA, sideB, sideC)
        {

        }
        public override float findArea()
        {
            float c = (D1 + D2 + D3) / 2;
            return (float)Math.Sqrt(c*(c-D1)*(c-D2)*(c-D3));
        }

        public override float findPerimeter()
        {
            return D1+D2+D3;
        }
    }
 
}
