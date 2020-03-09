using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBike = new Zero();

            myBike.MainColor = "Black";
            myBike.MaxOccupancy = 2;

            var myTesla = new Tesla();
            myTesla.MainColor = "Midnight Silver";
            myTesla.MaxOccupancy = 6;

            var myRam = new Ram();
            myRam.MainColor = "Raging Red";

            var myCessna = new Cessna();
            myCessna.MainColor = "White";

            myBike.Drive();
            myBike.Turn("down for what");
            myBike.Stop();
            myTesla.Drive();
            myTesla.Turn("left");
            myTesla.Stop();
            myRam.Drive();
            myRam.Turn("right");
            myRam.Stop();
            myCessna.Drive();
            myCessna.Turn("up");
            myCessna.Stop();

        }
    }
}
