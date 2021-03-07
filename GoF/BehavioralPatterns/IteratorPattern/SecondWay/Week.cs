using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.IteratorPattern.SecondWay
{
    class Week : IEnumerable
    {
        private string[] Days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        //public WeekEnumerator GetEnumerator()
        //{
        //    return new WeekEnumerator(Days);
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return (IEnumerator)GetEnumerator();
        //}
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Days.Length; i++)
            {
                yield return Days[i];
            }
        }
    }
}
