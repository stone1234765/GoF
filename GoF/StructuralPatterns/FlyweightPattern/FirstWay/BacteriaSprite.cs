using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.FlyweightPattern.FirstWay
{
    class BacteriaSprite
    {
        public string Color { get; set; }
        public Guid ImageId { get; set; }
        public BacteriaType Type { get; set; }
        public BacteriaSprite(string color, Guid imageId, BacteriaType type)
        {
            Color = color;
            ImageId = imageId;
            Type = type;
        }

        public void Drow(string point)
        {
            var hash = GetHashCode();
            Console.WriteLine($"Drow new bacteria of type: {Type} and hash: {hash} and point: {point}");
        }
    }
}
