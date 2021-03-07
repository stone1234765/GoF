using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.IteratorPattern.SecondWay
{
    class WeekEnumerator : IEnumerator
    {
        private string[] Days;
        private int position = -1;
        public WeekEnumerator(string[] days)
        {
            Days = days;
        }

        public string Current 
        { 
            get
            {
                if (position == -1 || position >= Days.Length)
                {
                    throw new InvalidOperationException();
                }
                return Days[position];
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (position < Days.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
