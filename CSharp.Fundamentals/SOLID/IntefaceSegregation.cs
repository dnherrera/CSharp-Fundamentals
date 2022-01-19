using System;

/// <summary>
/// Multiple Smaller Interfaces
/// </summary>
namespace CSharp.Fundamentals.SOLID
{
    public interface IPrinterTasks
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
    }
    interface IFaxTasks
    {
        void Fax(string content);
    }
    interface IPrintDuplexTasks
    {
        void PrintDuplex(string content);
    }
}

namespace CSharp.Fundamentals.SOLID
{
    /// <summary>
    /// This class implemented only the necessary intefaces
    /// </summary>
    /// <seealso cref="CSharp.Fundamentals.SOLID.IPrinterTasks" />
    /// <seealso cref="CSharp.Fundamentals.SOLID.IFaxTasks" />
    /// <seealso cref="CSharp.Fundamentals.SOLID.IPrintDuplexTasks" />
    public class HPLaserJetPrinter : IPrinterTasks, IFaxTasks,
                                     IPrintDuplexTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
        public void Fax(string FaxContent)
        {
            Console.WriteLine("Fax content");
        }
        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine("Print Duplex content");
        }
    }
}

/// <summary>
/// This class iherits only methods its needed for this function
/// </summary>
namespace CSharp.Fundamentals.SOLID
{
    class LiquidInkjetPrinter : IPrinterTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
    }
}