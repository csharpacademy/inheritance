
using System;

namespace Inheritance_Miscellaneous
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Casting
            
            Console.WriteLine("### Inheritance_Miscellaneous ###");
            Console.WriteLine();
            DriveNode driveNode = new DpiDriveNode();
            driveNode.Connect();
            Display(driveNode);

            Console.ReadKey();
        }

        static void Display(DriveNode node)
        {
            Console.WriteLine(node.GetFamilyName());
            Console.WriteLine(node.Configure());
            Console.WriteLine($"Drive online: {node.IsOnline}");
            Console.WriteLine();
            // use as for casting instead of (DpiDriveNode)node
            var dpiNode = node as DpiDriveNode;
            Console.WriteLine(dpiNode.GetFamilyName());
            Console.WriteLine(dpiNode.Configure());
            Console.WriteLine($"Drive online: {dpiNode.IsOnline}");
            Console.WriteLine();
        }
    }
}
