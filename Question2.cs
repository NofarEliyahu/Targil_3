using System;

namespace ConsoleApp62
{
    class Aircraft
    {
        protected string flightNumber;
        protected int altitude;

        public Aircraft(string flightNumber, int altitude)
        {
            this.flightNumber = flightNumber;
            this.altitude = altitude;
        }

        public virtual void PrintStatus()
        {
            Console.WriteLine("Flight number: " + flightNumber);
            Console.WriteLine("Altitude: " + altitude);
        }
    }

    class PassengerPlane : Aircraft
    {
        private int passengersCount;

        public PassengerPlane(string flightNumber, int altitude, int passengersCount)
            : base(flightNumber, altitude)
        {
            this.passengersCount = passengersCount;
        }

        public override void PrintStatus()
        {
            Console.WriteLine("Passenger Plane");
            Console.WriteLine("Flight number: " + flightNumber);
            Console.WriteLine("Altitude: " + altitude);
            Console.WriteLine("Passengers count: " + passengersCount);
        }
    }

    class FighterJet : Aircraft
    {
        private bool missilesLoaded;

        public FighterJet(string flightNumber, int altitude, bool missilesLoaded)
            : base(flightNumber, altitude)
        {
            this.missilesLoaded = missilesLoaded;
        }

        public override void PrintStatus()
        {
            Console.WriteLine("Fighter Jet");
            Console.WriteLine("Flight number: " + flightNumber);
            Console.WriteLine("Altitude: " + altitude);
            Console.WriteLine("Missiles loaded: " + missilesLoaded);
        }

        public void FireMissile()
        {
            Console.WriteLine("Fired Missile!");
            missilesLoaded = false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Aircraft[] arr = new Aircraft[4];

            arr[0] = new PassengerPlane("LY101", 30000, 180);
            arr[1] = new PassengerPlane("LY202", 28000, 150);
            arr[2] = new FighterJet("F16", 40000, true);
            arr[3] = new FighterJet("F35", 45000, true);

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].PrintStatus();

                if (arr[i] is FighterJet)
                {
                    FighterJet f = (FighterJet)arr[i];
                    f.FireMissile();
                }

                Console.WriteLine();
            }
        }
    }
}
