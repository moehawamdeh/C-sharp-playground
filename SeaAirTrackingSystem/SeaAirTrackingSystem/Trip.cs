
using System.Linq;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;

namespace SeaAirTrackingSystem
{
    abstract class Trip
    {
        public static Form1 form;
        public Port From, To;
        protected TripInfo currentTripInfo;
        protected PictureBox pictureBox;
        //properties
        protected virtual double Slope
        {
            get
            {
                return (To.Y - From.Y) * 1.00 / (To.X - From.X) * 1.00;
            }
        }
        protected virtual float Angle
        {
            get
            { //rad to degree
                int plus;
                if (From.X > To.X)
                    plus = 180;
                else plus = 0;
                return plus + (float)((180 / Math.PI) * Math.Atan(Slope));
            }
        }
        //Trip Info Generator
        protected abstract TripInfo GenerateInfo(List<Port>ports);
        //event handler
        public abstract void port_Click(object sender, EventArgs e);
        public abstract override string ToString();
        //controls
        public abstract void Move(Image image);
        public virtual bool Arrived()
        {
            double distance = Math.Sqrt(Math.Pow((To.X - 14) - pictureBox.Location.X, 2) + Math.Pow((To.Y - 14) - pictureBox.Location.Y, 2));
            if (distance < 5)
                return true;
            return false;
        }
        public void Delete()
        {
            pictureBox.Visible = false;
            form.Controls.Remove(pictureBox);
            To.RemoveTrip(this);
            From.RemoveTrip(this);
        }
        public bool Visible
        {
            get
            {
                return pictureBox.Visible;
            }
            set
            {
                pictureBox.Visible = value;
            }
        }
        protected virtual Bitmap RotatedImage(Image image)
        {
            Bitmap b = new Bitmap(image.Width, image.Height);
            b.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            Matrix matrix = new Matrix();
            matrix.RotateAt(Angle, new Point(image.Width / 2, image.Height / 2), MatrixOrder.Append);
            Graphics g = Graphics.FromImage(b);
            g.Transform = matrix;
            g.DrawImage(image, new Point(0, 0));
            return b;
        }
    }
    class ContinentPoints
    {
        public readonly List<Point> Asia, Africa, America;
        public readonly Point AsiaPoint, AfricaPoint, AmericaPoint;
        public ContinentPoints(List<Point> asia, List<Point> africa, List<Point> america,Point asiaPoint,Point africaPoint,Point americaPoint)
        {
            Asia = asia;
            Africa = africa;
            America = america;
            AsiaPoint = asiaPoint;
            AfricaPoint = africaPoint;
            AmericaPoint = americaPoint;
        }
    }
    class SeaTrip : Trip
    {
        public static ContinentPoints Continents;
        List<Point> Route; // if going to another content
        public static string[] Ships = { "Blue Cruiser", "Sponge Floater", "Gold Weaver", "Sea Diver", "Heavy Metalica" };
        public SeaTrip(List<Port> Seaports)
        {
            //generate info
            this.currentTripInfo = GenerateInfo(Seaports);
            pictureBox = new PictureBox
            {
                Location = new Point(From.X - 14, From.Y - 14),
                Visible = false, // until its confirmed valid
                Size = new Size(29, 29),
                BackColor = Color.Transparent
            };
            pictureBox.BringToFront();
            pictureBox.Click += new EventHandler(port_Click);
            form.Controls.Add(pictureBox);
        }
        protected override TripInfo GenerateInfo(List<Port> Seaports)
        {
            Random rand = new Random();
            int f = rand.Next(0, 11);
            int t = rand.Next(0, 11);
            while (t == f)
                t = rand.Next(0, 11); // to insure different sea-ports
            this.From = Seaports[f];
            this.To = Seaports[t];
            determineRoute();
            return new TripInfo()
            {
                From = this.From,
                To = this.To,
                StartDate = DateTime.Now,
                VechileType = Ships[rand.Next(0, Ships.Count())],
                Distance = Math.Sqrt(Math.Pow((From.Y - To.Y), 2) + Math.Pow((From.X - To.X), 2)),
                Speed = rand.Next(30, 60),
                TripType = "Shipment"
            };
        }
        //custom methods
        private int getContinent(Port seaport)
        {
            if (Continents.Asia.Contains(seaport.Location))
                return 1;
            if (Continents.Africa.Contains(seaport.Location))
                return 2;
            else return 3;
        }
        private void determineRoute()
        {
            int f = getContinent(From), t = getContinent(To);
            Route = new List<Point>();
            Route.Add(From.Location);
            if(f!=t) //NUT SAME CONTINIENT
            {
                if (f + t == 3)
                    if (f > t)//africa to asia
                    {
                        Route.Add(Continents.AfricaPoint);
                        Route.Add(Continents.AsiaPoint);
                    }
                    else
                    {//sia to africa
                        Route.Add(Continents.AsiaPoint);
                        Route.Add(Continents.AfricaPoint);
                    }
                else if (f + t == 5)//america to africa vise cersa
                    Route.Add(Continents.AmericaPoint);
                else if(f+t ==4)
                {
                    if (f == 1)
                        Route.Add(Continents.AsiaPoint);
                    else Route.Add(Continents.AmericaPoint);
                    Route.Add(Continents.AfricaPoint);
                    if (t == 1)
                        Route.Add(Continents.AsiaPoint);
                    else Route.Add(Continents.AmericaPoint);
                }
            }
            Route.Add(To.Location);
        }
        //overrideds= methods
        protected override double Slope
        {
            get
            {
                return (Route[1].Y - Route[0].Y) * 1.00 / (Route[1].X - Route[0].X) * 1.00;
            }
        }
        protected override float Angle
        {
            get
            { //rad to degree
                int plus;
                if (Route[0].X > Route[1].X)
                    plus = 180;
                else plus = 0;
                return plus + (float)((180 / Math.PI) * Math.Atan(Slope));
            }
        }
        protected override Bitmap RotatedImage(Image image)
        {
            Bitmap b = new Bitmap(image.Width, image.Height);
            b.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            Matrix matrix = new Matrix();
            if (Route[1].X < Route[0].X)
                matrix.RotateAt(180 - Angle, new Point(image.Width / 2, image.Height / 2), MatrixOrder.Append);
            else matrix.RotateAt(Angle, new Point(image.Width / 2, image.Height / 2), MatrixOrder.Append);

            Graphics g = Graphics.FromImage(b);
            g.Transform = matrix;
            g.DrawImage(image, new Point(0, 0));
            if (Route[1].X < Route[0].X)
                b.RotateFlip(RotateFlipType.RotateNoneFlipX);
            return b;
        }
        public override void Move(Image image)
        {
            //move plane one step
            int x = pictureBox.Location.X + ((Route[0].X > Route[1].X) ? -1 : 1);
            int y = (int)(Route[0].Y - 14 + Slope * (x - Route[0].X + 14)); // equation of straight line two points
            pictureBox.Location = new Point(x, y);
            //rotate plane image
            Bitmap f = RotatedImage(image);
            //draw rotated plane on current form frame
            Graphics k = Graphics.FromImage(form.frame);
            k.DrawImage(f, new Rectangle(pictureBox.Location, new Size(25, 25)));

            if (Route.Count != 2)
            {
                double distance = Math.Sqrt(Math.Pow((Route[1].X - 14) - pictureBox.Location.X, 2) + Math.Pow((Route[1].Y - 14) - pictureBox.Location.Y, 2));
                if (distance <= 7)
                    Route.Remove(Route[0]);
            }
        }

        public override void port_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.ToString(), "Sea-Trip Info");
        }

        public override string ToString()
        {
            string s = "From: {0}\nTo: {1}\nDate: {2}\nShip Model: {3}\nStats: Sailing {4}km / h in distance of {5}km";
            return string.Format(s, currentTripInfo.From, currentTripInfo.To,DateTime.Now, currentTripInfo.VechileType, currentTripInfo.Speed, currentTripInfo.Distance.ToString("0.00"));
        }
    }
}
