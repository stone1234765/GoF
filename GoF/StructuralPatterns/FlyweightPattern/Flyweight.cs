using GoF.StructuralPatterns.FlyweightPattern.FirstWay;
using GoF.StructuralPatterns.FlyweightPattern.SecondWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.FlyweightPattern
{
    class Flyweight
    {
        public void Run()
        {

            Console.WriteLine("Flyweight");
            //First way
            Console.WriteLine("First way");
            var rand = new Random();
            var bacteriaTypes = new BacteriaType[] { BacteriaType.bacilli, BacteriaType.cocci, BacteriaType.spirilla };
            for (int i = 0; i < 100; i++)
            {
                var sprite = BacteriaSpriteFactory.MakeBacteriaSprite(bacteriaTypes[rand.Next(0, 3)]);
                var point = CreateRandomString(5, 100, "abcdefghijklmnopqrstuvwxyz  ", rand);
                var newBacteria = new Bacteria(point, rand.NextDouble(), sprite);
                newBacteria.Drow();
            }

            //Second way
            Console.WriteLine("Second way");
            var autoFactory = new AutoFactory();
            var models = new string[] { "BMV", "Mers", "Audi" };
            for (int i = 0; i < 100; i++)
            {
                var auto = autoFactory.MakeAuto(models[rand.Next(0, 3)]);
                Console.WriteLine($"Auto with model {auto.Model} and hash {auto.GetHashCode()}");
            }

            Console.WriteLine();
        }
        private string CreateRandomString(int minLength, int maxLenght, string chars, Random random)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < random.Next(minLength, maxLenght); i++)
            {
                stringBuilder.Append(chars[random.Next(0, chars.Length)]);
            }
            return stringBuilder.ToString();
        }
    }
}
