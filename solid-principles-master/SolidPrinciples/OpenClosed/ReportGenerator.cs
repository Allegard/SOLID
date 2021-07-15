using Microsoft.AspNetCore.Mvc.RazorPages;
using SolidPrinciples.OpenClosed;
using SolidPrinciples.SR;
using System.Reflection.Metadata;

namespace SolidPrinciples.OpenClosed
{
    public abstract class ReportGenerator
    {
        public string ReportType { get; set; }

        public abstract void GenerateReport(Person person);
        //{
        //    if (ReportType == "CRS")
        //    {
        //        // Report generation with person data in Crystal Report.
                
        //    }
            
        //    if (ReportType == "PDF")
        //    {
        //        // Report generation with person data in PDF.
        //    }
        //}
    }
}