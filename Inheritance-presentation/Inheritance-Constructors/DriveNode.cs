using System;

namespace Inheritance_Constructors
{
    class DriveNode
    {
        private string name;
        public DriveNode(string name)
        {
            Console.WriteLine($"Constructor of {nameof(DriveNode)}");
            Console.WriteLine($"Passed {name}");
            this.name = name;
        }

        protected string FamilyName;
        protected bool isOnline;

        public bool IsOnline => isOnline;

        public string GetFamilyName()
        {
            return FamilyName;
        }

        public void Connect()
        {
            isOnline = true;
            SetFamilyName();
        }

        public virtual string Configure()
        {
            return "Configuring PowerFlex";
        }

        protected virtual void SetFamilyName()
        {
            FamilyName = "PowerFlex";
        }
    }
}
