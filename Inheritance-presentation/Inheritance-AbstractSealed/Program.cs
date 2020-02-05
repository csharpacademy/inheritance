using System;

namespace Inheritance_AbstractSealed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Inheritance_AbstractSealed ###");
            Console.WriteLine();

            // Abstract instance - does not compile
            //var driveNode = new DriveNodeAbstract();
            var dpiNode = new DpiDriveNode();

            dpiNode.Connect();
            Display(dpiNode);
            
            // Sealed instance
            DisplaySealed();
            
            Console.ReadKey();
        }

        static void Display(DriveNodeAbstract node)
        {
            Console.WriteLine(node.GetFamilyName());
            Console.WriteLine(node.Configure());
            Console.WriteLine($"Drive online: {node.IsOnline}");
            Console.WriteLine();
        }

        static void DisplaySealed()
        {
            var node = new DriveNodeSealed();
            node.Connect();
            Console.WriteLine(node.GetFamilyName());
            Console.WriteLine(node.Configure());
            Console.WriteLine($"Drive online: {node.IsOnline}");
        }
    }
}
