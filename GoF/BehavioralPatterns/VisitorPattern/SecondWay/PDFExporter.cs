using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.VisitorPattern.SecondWay
{
    class PDFExporter : IVisitor
    {
        public void Visit(Report report)
        {
            Console.WriteLine($"Export report with title: {report.Title} to PDF");
        }

        public void Visit(SpreadSheet spreadSheet)
        {
            Console.WriteLine($"Export spreadSheet with title: {spreadSheet.Title} to PDF");
        }
    }
}
