using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner
{
    class Building
    {
        // Private Fields
        private string _designer = "Chris Calhoun";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        // Public Properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public int Volume 
        {
            get
            {
                return (int)(Width * Depth * (3 * Stories));
            }
        }

        // Constructor
        public Building(string address)
        {
            _address = address;
        }

        // Methods
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string owner)
        {
            _owner = owner;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{_address}---------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space.\n");
        }

    }
}
