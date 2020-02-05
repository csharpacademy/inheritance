using System;

namespace Inheritance_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Inheritance_Constructors ###");
            Console.WriteLine();
            // parameterless constructor
            //var dpiNode = new DpiDriveNode();

            // constructors order
            var dpiNode = new DpiDriveNode("lalala");
            
            Console.ReadKey();
        }
    }
}
