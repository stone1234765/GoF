using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.FlyweightPattern.FirstWay
{
    class BacteriaSpriteFactory
    {
        static private Dictionary<BacteriaType, BacteriaSprite> Sprites = new Dictionary<BacteriaType, BacteriaSprite>();

        static public BacteriaSprite MakeBacteriaSprite(BacteriaType type)
        {
            BacteriaSprite sprite;
            Sprites.TryGetValue(type, out sprite);
            if (sprite != null)
            {
                return sprite;
            }
            else
            {
                switch (type)
                {
                    case BacteriaType.cocci:
                        sprite = new BacteriaSprite("black", Guid.NewGuid(), type);
                        break;
                    case BacteriaType.bacilli:
                        sprite = new BacteriaSprite("green", Guid.NewGuid(), type);
                        break;
                    case BacteriaType.spirilla:
                        sprite = new BacteriaSprite("red", Guid.NewGuid(), type);
                        break;
                    default:
                        break;
                }
                Sprites[type] = sprite;
                return sprite;
            }
        }
    }
}
