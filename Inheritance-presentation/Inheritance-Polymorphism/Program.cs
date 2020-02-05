using System;

namespace InheritanceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### InheritanceAndPolymorphism ###");
            Console.WriteLine();

            DriveNode driveNode = new DriveNode();
            DpiDriveNode dpiNode = new DpiDriveNode();
            DsiDriveNode dsiNode = new DsiDriveNode();

            driveNode.Connect();
            dpiNode.Connect();
            dsiNode.Connect();

            Display(driveNode);
            Display(dpiNode);
            Display(dsiNode);

            Console.ReadKey();
        }

        static void Display(DriveNode node)
        {
            Console.WriteLine(node.GetFamilyName());
            Console.WriteLine(node.Configure());
            Console.WriteLine($"Drive online: {node.IsOnline}");
            Console.WriteLine();
        }
    }
}
