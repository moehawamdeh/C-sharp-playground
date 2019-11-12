using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SeaAirTrackingSystem
{
    public partial class Form1 : Form
    {
        public Bitmap frame;
        List<Port> Airports = new List<Port>();
        List<Port> SeaPorts = new List<Port>();
        List<Trip> Flights = new List<Trip>();
        List<Trip> SeaTrips = new List<Trip>();
        Port selected = null;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Trip.form = this;
            InitializePorts();
            frame = new Bitmap(Properties.Resources.mapWithKeys);
            GenerateBar.Value = 0;
            MoveBar.Value = 0;
            GenerateBarSea.Value = 0;
            //generateTimer.Start();
            //generateTimerSea.Start();
            //moveTimer.Start();
        }
        private void InitializePorts()
        {
            //linking airport to its picture box
            string[] airportsNames = { "Great Wall international(China)", "Japan Emperor Airport", "Indian Station", "Russia International", "Lands of Turkey", "Britain's Inter.(UK)", "Queen Alia Airport(Jordan)", "France ports", "Canda wideland", "USA International", "Denmarkian", "Cairo Inter.(Egypt)", "Iceland ports", "Spain la casa", "Congo AirStrikes", "Brazil p", "SouthAfrica dome", "Urguay fly land" };
            string[] countries = { "China", "Japan", "India", "Russia", "Turkey", "UK", "Jordan", "France", "Canda", "USA", "Denmark", "Egypt", "Iceland", "Spain", "Congo", "Brazil", "SouthAfrica", "Urguay" };
            string[] seaportsNames = { "Captain", "NewYork", "ZeeBurge", "Santos", "Aires", "Paradise", "CapeTown", "Salalah", "Jawahar", "Tanjang", "Sydney" };
            for (int i = 0; i < 18; i++)
            {
                PictureBox p = (PictureBox)this.Controls[countries[i]];
                int x = p.Location.X + p.Width / 2 + i * 0;
                int y = p.Location.Y + p.Height / 2;
                Port a = new Port(airportsNames[i], rand.Next(6, 10), new Point(x, y));
                Airports.Add(a);
                portsCombo.Items.Add(airportsNames[i]);
            }
           for(int i=0;i<11;i++)
            {
                PictureBox p = (PictureBox)this.Controls[seaportsNames[i]];
                int x = p.Location.X + p.Width / 2 + i * 0;
                int y = p.Location.Y + p.Height / 2;
                Port a = new Port(seaportsNames[i]+ " Sea-port", rand.Next(2, 5), new Point(x, y));
                SeaPorts.Add(a);
                portsCombo.Items.Add(seaportsNames[i] + " Sea-port");
            }
            List<Point> america = new List<Point>() { SeaPorts[0].Location,SeaPorts[1].Location,SeaPorts[2].Location,SeaPorts[3].Location};
            List<Point> africa = new List<Point>() { SeaPorts[4].Location, SeaPorts[5].Location, SeaPorts[6].Location };
            List<Point> asia = new List<Point>() { SeaPorts[7].Location, SeaPorts[8].Location, SeaPorts[9].Location,SeaPorts[10].Location };
            Point asiaP = this.Controls["AsiaPoint"].Location;
            Point africaP = this.Controls["AfricaPoint"].Location;
            Point americaP = this.Controls["AmericaPoint"].Location;
            SeaTrip.Continents = new ContinentPoints(asia, africa, america, asiaP, africaP, americaP);


        }
        private void port_Select(object sender, EventArgs e)
        {
            Port port =
           Airports.Find(delegate (Port a)
           {
               if (sender is PictureBox)
                   return a.Name.Contains(((PictureBox)sender).Name);
               else //its a combo box
                   return a.Name == ((ComboBox)sender).SelectedItem.ToString();
           });
            if (port == null)
                port = SeaPorts.Find(delegate (Port a)
                {
                    if (sender is PictureBox)
                        return a.Name.Contains(((PictureBox)sender).Name);
                    else //its a combo box
                        return a.Name == ((ComboBox)sender).SelectedItem.ToString();
                });
            portsCombo.SelectedItem = port.Name;
            if (port != null)
                selected = port;
            updateInfo(selected);
        }
        private void updateInfo(Port port)
        {
            if (port != null)
            {
                infoMax.Text = port.MaxTrips.ToString();
                infoIncoming.Text = port.Incoming.Count().ToString();
                infoOutgoing.Text = port.Outgoing.Count().ToString();
                listBox1.Items.Clear();
                if (Airports.Contains(port))
                {
                    foreach (Trip f in port.Incoming)
                        listBox1.Items.Add(((f is TransitFlight) ? "Transit From " : "Direct From ") + f.From.Name);
                    foreach (Trip f in port.Outgoing)
                        listBox1.Items.Add(((f is TransitFlight) ? "Transit To " : "Direct To ") + f.To.Name);
                }
                else
                {
                    foreach (Trip t in port.Incoming)
                        listBox1.Items.Add("Coming From " + t.From);
                    foreach (Trip t in port.Outgoing)
                        listBox1.Items.Add("Going To " + t.To);
                }
            }
        }
        private void Bar_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = (TrackBar)sender;
            Timer timer;
            if (bar == GenerateBarSea)
                timer = generateTimerSea;
            else if (bar == GenerateBar)
                timer = generateTimer;
            else timer = moveTimer;
            if (bar.Value == 0)
                timer.Stop();
            else
            {
                if (timer.Enabled == false)
                    timer.Start();

                timer.Interval = (timer == moveTimer ? 1000 : 3000) / bar.Value;
            }
        }
        
        private void generateTimer_Tick(object sender, EventArgs e)
        {
            Trip trip;
            if ((Timer)sender == generateTimerSea)
                trip = new SeaTrip(SeaPorts);
            else
            {
                if (rand.Next(0, 2) == 0) // transit or direct
                    trip = new DirectFlight(Airports);
                else trip = new TransitFlight(Airports);
            }
            bool valid = trip.From.AddTrip(trip) && trip.To.AddTrip(trip);
            // valid if both airports capacity is not reached yet
            if (valid)
            {
                trip.Visible = true;
                if ((Timer)sender == generateTimerSea)
                    SeaTrips.Add(trip);
                else Flights.Add(trip);
                updateInfo(selected);
            }
            else trip.Delete();
        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
           
            frame = new Bitmap(Properties.Resources.mapWithKeys);
            List<Trip> ToRemove = new List<Trip>();
            foreach (Trip f in Flights.Concat(SeaTrips))
            {
                if (f.Arrived())
                {
                    ToRemove.Add(f);
                    f.Delete();
                    updateInfo(selected);
                }
                else
                {
                    if (!(f is TransitFlight))
                    {
                        if (selected != null)
                        {
                            if (selected.Incoming.Contains(f) || selected.Outgoing.Contains(f))
                            {
                                if (f is DirectFlight)
                                    f.Move(Properties.Resources.selectedDirect);
                                else f.Move(Properties.Resources.SelectedShip);
                            }
                            else
                            {
                                if (f is DirectFlight)
                                    f.Move(Properties.Resources.direct);
                                else f.Move(Properties.Resources.ship);
                            }
                        }
                        else
                        {
                            if (f is DirectFlight)
                                f.Move(Properties.Resources.direct);
                            else f.Move(Properties.Resources.ship);
                        }
                    }
                    else 
                    {
                        if (selected != null)
                        {
                            if (selected.Incoming.Contains(f) || selected.Outgoing.Contains(f))
                                f.Move(Properties.Resources.selectedTransit);
                            else f.Move(Properties.Resources.transit);
                        }
                        else f.Move(Properties.Resources.transit);
                    }
                    Rectangle changedArea = new Rectangle(0,0,label1.Location.X,this.Height);
                    this.Invalidate(changedArea);
                }
            }
            this.BackgroundImage = frame;
            foreach (Trip f in ToRemove)
            {
                if (f is SeaTrip)
                    SeaTrips.Remove(f);
                else Flights.Remove(f);
            }
        }
       
        private void Reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
