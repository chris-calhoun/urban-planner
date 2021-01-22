using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Building 2807
            Building TwoEightZeroSeven = new Building("2807 22nd Ave. S.");
            TwoEightZeroSeven.Width = 20;
            TwoEightZeroSeven.Depth = 30;
            TwoEightZeroSeven.Stories = 5;
            TwoEightZeroSeven.Construct();
            TwoEightZeroSeven.Purchase("Barack Obama");
            TwoEightZeroSeven.PrintInfo();

            // Building 113
            Building OneOneThree = new Building("1234 Alpha Ct.");
            OneOneThree.Width = 20;
            OneOneThree.Depth = 20;
            OneOneThree.Stories = 2;
            OneOneThree.Construct();
            OneOneThree.Purchase("Todd Calhoun");
            OneOneThree.PrintInfo();

            // Building 5678
            Building FiveSixSevenEight = new Building("5678 Murphy St.");
            FiveSixSevenEight.Width = 25;
            FiveSixSevenEight.Depth = 25;
            FiveSixSevenEight.Stories = 3;
            FiveSixSevenEight.Construct();
            FiveSixSevenEight.Purchase("Derrick Henry");
            FiveSixSevenEight.PrintInfo();
        }
    }
}
