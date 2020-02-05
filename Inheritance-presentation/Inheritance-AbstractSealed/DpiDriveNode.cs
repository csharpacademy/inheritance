using System;

namespace Inheritance_AbstractSealed
{
    class DpiDriveNode : DriveNodeAbstract
    {
        private bool isVirtual;
        public override bool IsVirtual
        {
            get { return isVirtual; }
            set { isVirtual = value; }
        }

        public DpiDriveNode()
        {
            Console.WriteLine($"Constructor of {nameof(DpiDriveNode)}");
        }

        protected override void SetFamilyName()
        {
            FamilyName = "PF755T";
        }

        public override string Configure()
        {
            isVirtual = true;
            return "Configuring PF755T";
        }
    }
}
