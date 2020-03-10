using System;

namespace diggersandfliers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var myAnt = new Ant()
            {
                Name = "My Ant",
                Color = "Red"
            };

            var myCopperhead = new Copperhead()
            {
                Name = "Snek",
                Color = "Mysterious"
            };

            var myWorm = new Earthworm()
            {
                Name = "Wormy",
                Color = "Pink"
            };

            var myFinch = new Finch()
            {
                Name = "Birdy",
                Color = "Bird Color"
            };

            var myFish = new Fish()
            {
                Name = "Fishy",
                Color = "Briny deep"
            };

            var myGerbil = new Gerbil()
            {
                Name = "Hamtaro",
                Color = "Who Cares"
            };

            var myMouse = new Mouse()
            {
                Name = "Jerry",
                Color = "White"
            };

            var myParakeet = new Parakeet()
            {
                Name = "The Fruit Loops One",
                Color = "Blue"
            };

            var myRattlesnake = new Rattlesnake()
            {
                Name = "Rattle",
                Color = "Snake"
            };

            var myTerrapin = new Terrapin()
            {
                Name = "Franklin",
                Color = "Green"
            };

            var SwimmersContainer = new SwimmersContainer();
            SwimmersContainer.AddSwimmers(myTerrapin);
            SwimmersContainer.AddSwimmers(myFish);

            var WalkersContainer = new WalkersContainer();
            WalkersContainer.AddWalker(myAnt);
            WalkersContainer.AddWalker(myCopperhead);
            WalkersContainer.AddWalker(myGerbil);
            WalkersContainer.AddWalker(myMouse);
            WalkersContainer.AddWalker(myRattlesnake);
            WalkersContainer.AddWalker(myTerrapin);

            var DiggersContainer = new DiggersContainer();
            DiggersContainer.AddDigger(myAnt);
            DiggersContainer.AddDigger(myWorm);

        }
    }
}
