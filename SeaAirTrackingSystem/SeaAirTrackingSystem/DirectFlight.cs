using System.Linq;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace SeaAirTrackingSystem
{
    class DirectFlight : Trip
    {
        //members
        public static string[] planes = { "ABC Motors", "Acro Sport", "Abraham jet", "AASI Jetcruzer", "Aero" };
        //ctor
        public DirectFlight(List<Port> airports)
        {
            //generate info
            this.currentTripInfo = GenerateInfo(airports);
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
        //overridess
        protected override TripInfo GenerateInfo(List<Port> airports)
        {
            Random rand = new Random();
            int f = rand.Next(0, 18);
            int t = rand.Next(0, 18);
            while (t == f)
                t = rand.Next(0, 18); // to insure different airports
            this.From = airports[f];
            this.To = airports[t];
            return new TripInfo()
            {
                From = this.From,
                To = this.To,
                StartDate = DateTime.Now,
                VechileType = planes[rand.Next(0, planes.Count())],
                Distance = Math.Sqrt(Math.Pow((From.Y - To.Y), 2) + Math.Pow((From.X - To.X), 2)),
                Speed = rand.Next(500, 900),
                TripType = "Direct Flight"
            };
        }
        public override void port_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.ToString(), "Flight Info");
        }
        public override string ToString()
        {
            string s = "From: {0}\nTo: {1}\nDate: {2}\nPlane Type: {3}\nStats: flying {4}km / h in distance of {5}km";
            return string.Format(s, currentTripInfo.From, currentTripInfo.To,DateTime.Now, currentTripInfo.VechileType, currentTripInfo.Speed, currentTripInfo.Distance.ToString("0.00"));
        }
        public override void Move(Image image)
        {
            //move plane one step
            int x = pictureBox.Location.X + ((From.X > To.X) ? -1 : 1);
            int y = (int)(From.Y - 14 + Slope * (x - From.X + 14)); // equation of straight line two points
            pictureBox.Location = new Point(x, y);
            //rotate plane image
            Bitmap f = RotatedImage(image);
            //draw rotated plane on current form frame
            Graphics k = Graphics.FromImage(form.frame);
            k.DrawImage(f, new Rectangle(pictureBox.Location, new Size(25, 25)));
        }
    }
    class TransitFlight : DirectFlight
    {
        //members ,, ctor
        public List<TripInfo> tripsInfo;
        public TransitFlight(List<Port> airports) : base(airports)
        {
        }
        //custom method
        private bool isLastFlight()
        {
            if (currentTripInfo == tripsInfo[tripsInfo.Count - 1])
                return true;
            return false;
        }
        //overrides
        protected override TripInfo GenerateInfo(List<Port> airports)
        {
            tripsInfo = new List<TripInfo>(); // initialize list
            Random rand = new Random();
            List<int> pickedAirports = new List<int>(8);
            //generate all transit trips
            for (int i = 0; i < rand.Next(2, 5); i++)
            {
                int T, F; //airpports
                if (i == 0)
                    F = rand.Next(0, 18);
                else F = pickedAirports[pickedAirports.Count - 1];
                pickedAirports.Add(F);
                T = rand.Next(0, 18);
                while (pickedAirports.Contains(T))
                    T = rand.Next(0, 18);
                pickedAirports.Add(T);

                tripsInfo.Add(new TripInfo()
                {
                    From = airports[F],
                    To = airports[T],
                    StartDate = DateTime.Now,
                    VechileType = planes[rand.Next(0, planes.Count())],
                    Distance = Math.Sqrt(Math.Pow((airports[F].Y - airports[T].Y), 2) + Math.Pow((airports[F].X - airports[T].X), 2)),
                    Speed = rand.Next(500, 900),
                    TripType = "Transit Flight"
                });
            }
            //set current trip to first one
            this.From = tripsInfo[0].From;
            this.To = tripsInfo[0].To;
            return tripsInfo[0];
        }
        public override string ToString()
        {
            string s = "Transit Flight\n" + tripsInfo[0].From.Name;// ab bc cd df

            foreach (TripInfo i in tripsInfo)
            {
                s += " >> " + i.To;
            }
            s += "\nCurrent Trip info:\n";
            s += "From: {0}\nTo: {1}\nDate: {2}\nPlane Type: {3}\nStats: flying {4}km / h in distance of {5}km";
            return string.Format(s, currentTripInfo.From, currentTripInfo.To, DateTime.Now, currentTripInfo.VechileType, currentTripInfo.Speed, currentTripInfo.Distance.ToString("0.00"));
        }
        public override void Move(Image image)
        {
            base.Move(image); // no diffrence
            //move to next trip if finished the current
            if (!isLastFlight())
                if (base.Arrived() == true)
                {
                    //update trip on airports
                    currentTripInfo.From.RemoveTrip(this);
                    currentTripInfo.To.RemoveTrip(this);
                    currentTripInfo = tripsInfo[tripsInfo.IndexOf(currentTripInfo) + 1];
                    From = currentTripInfo.From;
                    To = currentTripInfo.To;
                    currentTripInfo.From.AddTrip(this);
                    currentTripInfo.To.AddTrip(this);

                }
        }
        public override bool Arrived()
        {
            //Measure distance between last airport and plane
            if (isLastFlight())
            {
                double distance = Math.Sqrt(Math.Pow((currentTripInfo.To.X - 14) - pictureBox.Location.X, 2) + Math.Pow((currentTripInfo.To.Y - 14) - pictureBox.Location.Y, 2));
                if (distance <= 5)
                    return true;
            }
            return false;
        }
    }
}
