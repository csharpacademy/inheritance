using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Inheritance ###");
            Console.WriteLine();

            var driveNode = new DriveNode();
            var dpiNode = new DpiDriveNode();
            var dsiNode = new DsiDriveNode();

            driveNode.Connect();
            dpiNode.Connect();
            dsiNode.Connect();

            // overridden methods are not called
            Display(driveNode);
            Display(dpiNode);
            Display(dsiNode);

            DisplayDpiNode(dpiNode);

            // Implicit inheritance
            ///DisplayImplicitInheritance();

            Console.ReadKey();
        }

        static void Display(DriveNode node)
        {
            Console.WriteLine(node.GetFamilyName());
            Console.WriteLine(node.Configure());
            Console.WriteLine($"Drive online: {node.IsOnline}");
            Console.WriteLine();
        }

        static void DisplayDpiNode(DpiDriveNode dpiNode)
        {
            Console.WriteLine(dpiNode.GetFamilyName());
            Console.WriteLine(dpiNode.Configure());
            Console.WriteLine($"Drive online: {dpiNode.IsOnline}");
            Console.WriteLine();
        }

        static void DisplayImplicitInheritance()
        {
            Console.WriteLine("Classes base types");
            Console.WriteLine($"Base type of {nameof(DpiDriveNode)} class is {typeof(DpiDriveNode).BaseType.Name}");
            Console.WriteLine($"Base type of {nameof(DriveNode)} class is {typeof(DriveNode).BaseType.Name}");
            Console.WriteLine($"Base type of {nameof(String)} class is {typeof(String).BaseType.Name}");
            Console.WriteLine($"Base type of {nameof(Point)} structure is {typeof(Point).BaseType.Name}");
            Console.WriteLine($"Base type of {nameof(Int32)} is {typeof(Int32).BaseType.Name}");
            Console.WriteLine($"Base type of {nameof(ValueType)} is {typeof(ValueType).BaseType.Name}");
            Console.WriteLine($"Base type of {nameof(Object)} is {typeof(Object).BaseType.Name}");
        }
    }

    struct Point
    {
        private int x;
        private int y;
    }
}
