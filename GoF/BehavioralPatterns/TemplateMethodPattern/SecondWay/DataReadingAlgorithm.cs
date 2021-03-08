using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.TemplateMethodPattern.SecondWay
{
    abstract class DataReadingAlgorithm
    {
        public abstract void OpenResource();
        public virtual void ExtractData()
        {
            Console.WriteLine("Extracting data..");
        }
        public virtual void ParseData()
        {
            Console.WriteLine("Parsing data..");
        }
        public virtual void ProcessData()
        {
            Console.WriteLine("Processing data..");
        }
        public abstract void CloseResource();

        public void ReadData()
        {
            OpenResource();
            ExtractData();
            ParseData();
            ProcessData();
            CloseResource();
            Console.WriteLine();
        }

    }
}
