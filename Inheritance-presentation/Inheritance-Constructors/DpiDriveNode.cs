using System;

namespace Inheritance_Constructors
{
    class DpiDriveNode : DriveNode
    {
        public DpiDriveNode(string name) : base(name)
        {
            Console.WriteLine($"Constructor of {nameof(DpiDriveNode)}");
            Console.WriteLine($"Passed {name}");
        }

        public DpiDriveNode(string name, int count) : base(name)
        {
            Console.WriteLine($"Constructor of {nameof(DpiDriveNode)}");
            Console.WriteLine($"Passed {name}");
        }
        protected override void SetFamilyName()
        {
            FamilyName = "PF755T";
        }

        public override string Configure()
        {
            return "Configuring PF755T";
        }
    }
}
