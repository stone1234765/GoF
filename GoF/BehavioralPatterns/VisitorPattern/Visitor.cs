using GoF.BehavioralPatterns.VisitorPattern.FirstWay;
using GoF.BehavioralPatterns.VisitorPattern.SecondWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.VisitorPattern
{
    class Visitor
    {
        public void Run()
        {
            Console.WriteLine("Visitor");
            //First way
            Console.WriteLine("First way");
            var visitor = new AutoVisitor();
            var tesla = new Tesla();
            var mers = new Mers();
            var audi = new Audi();
            var bmv = new BMW();
            tesla.Accept(visitor);
            mers.Accept(visitor);
            audi.Accept(visitor);
            bmv.Accept(visitor);

            //Second way
            Console.WriteLine("Second way");
            var report1 = new Report("report1", new string[0], new string[0], new int[0]);
            var report2 = new Report("report2", new string[0], new string[0], new int[0]);
            var report3 = new Report("report3", new string[0], new string[0], new int[0]);
            var report4 = new Report("report4", new string[0], new string[0], new int[0]);

            var spreadSheet1 = new SpreadSheet("spreadSheet1", new string[0]);
            var spreadSheet2 = new SpreadSheet("spreadSheet2", new string[0]);
            var spreadSheet3 = new SpreadSheet("spreadSheet3", new string[0]);

            var htmlExporter = new HTMLExporter();
            var pdfExporter = new PDFExporter();

            var docs = new IVisitable[] { report1, report2, report3, report4, spreadSheet1, spreadSheet2, spreadSheet3 };
            foreach (var doc in docs)
            {
                doc.Accept(htmlExporter);
            }
            Console.WriteLine();
            foreach (var doc in docs)
            {
                doc.Accept(pdfExporter);
            }


            Console.WriteLine();
        }
    }
}
