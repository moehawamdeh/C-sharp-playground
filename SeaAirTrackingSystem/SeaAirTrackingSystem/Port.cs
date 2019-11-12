using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SeaAirTrackingSystem
{
    class Port
    {
        public readonly string Name;
        public readonly Point Location;
        public int X
        {
            get
            {
                return Location.X;
            }
        }
        public int Y
        {
            get
            {
                return Location.Y;
            }
        }
        public readonly int MaxTrips;
        public List<Trip> Outgoing, Incoming;
        public int TripsCount
        {
            get
            {
                return Incoming.Count+Outgoing.Count;
            }
        }
        public Port(string name,int max,Point location)
        {
            Outgoing = new List<Trip>();
            Incoming = new List<Trip>();
            Name = name;
            MaxTrips = max;
            Location = location;
        }
        public void RemoveTrip(Trip trip)
        {
            if (this == trip.From)
                Outgoing.Remove(trip);
            else if (this == trip.To)
                Incoming.Remove(trip);
        }
        public bool AddTrip(Trip trip)
        {
            if (TripsCount >= MaxTrips)
                return false;
            if (this == trip.From)
                Outgoing.Add(trip);
            else if (this == trip.To)
                Incoming.Add(trip);
            return true;
        }
        public bool AddTrip(TransitFlight trip)
        {
            if (TripsCount >= MaxTrips-trip.tripsInfo.Count)
                return false;
            if (this == trip.From)
                Outgoing.Add(trip);
            else if (this == trip.To)
                Incoming.Add(trip);
            return true;
        }
        public override string ToString()
        {
            return this.Name;
        }
    }

    
    }
