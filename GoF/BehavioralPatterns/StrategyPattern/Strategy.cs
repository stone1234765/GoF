using GoF.BehavioralPatterns.StrategyPattern.FirstWay;
using GoF.BehavioralPatterns.StrategyPattern.SecondWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StrategyPattern
{
    class Strategy
    {
        public void Run()
        {
            Console.WriteLine("Strategy");
            //First way
            Console.WriteLine("First way");
            var autoCart = new AutoCart(5000);
            var baseDiscount = new BaseDiscount();
            var platinumDiscount = new PlatinumDiscount();
            var premiumDiscount = new PremiumDiscount();

            autoCart.Discount = baseDiscount;
            autoCart.ShowDiscount();
            autoCart.Discount = platinumDiscount;
            autoCart.ShowDiscount();
            autoCart.Discount = premiumDiscount;
            autoCart.ShowDiscount();


            //Second way
            Console.WriteLine("Second way");
            var filter = new Filter();
            var image = new Image();
            var sepiaFilter = new SepiaFilter();
            var bwFilter = new BWFilter();
            var distortionFilter = new DistortionFilter();
            filter.FilterStrategy = sepiaFilter;
            filter.ApplyFilter(image);
            filter.FilterStrategy = bwFilter;
            filter.ApplyFilter(image);
            filter.FilterStrategy = distortionFilter;
            filter.ApplyFilter(image);

            Console.WriteLine();
        }
    }
}
