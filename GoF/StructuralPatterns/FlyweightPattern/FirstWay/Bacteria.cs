using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.FlyweightPattern.FirstWay
{
    class Bacteria
    {
        public string Point { get; set; }
        public double Size { get; set; }
        public BacteriaSprite Sprite { get; set; }

        public Bacteria(string point, double size, BacteriaSprite sprite)
        {
            Point = point;
            Size = size;
            Sprite = sprite;
        }

        public void Drow()
        {
            Sprite.Drow(Point);
        }
    }
}
