using System;

namespace Inheritance_AbstractSealed
{
    abstract class DriveNodeAbstract
    {
        protected string FamilyName;
        private bool isOnline;

        public bool IsOnline => isOnline;
        public abstract bool IsVirtual { get; set; }

        protected DriveNodeAbstract()
        {
            Console.WriteLine($"Constructor of {nameof(DriveNodeAbstract)}");
        }

        public string GetFamilyName()
        {
            return FamilyName;
        }

        public void Connect()
        {
            isOnline = true;
            SetFamilyName();
        }

        public abstract string Configure();

        protected abstract void SetFamilyName();
    }

    sealed class DriveNodeSealed
    {
        private string FamilyName;
        private bool isOnline;

        public bool IsOnline => isOnline;

        public DriveNodeSealed()
        {
            Console.WriteLine($"Constructor of {nameof(DriveNodeSealed)}");
        }

        public string GetFamilyName()
        {
            return FamilyName;
        }

        public void Connect()
        {
            isOnline = true;
            SetFamilyName();
        }

        public string Configure()
        {
            return "Configuring PowerFlex";

        }

        protected void SetFamilyName()
        {
            FamilyName = "PowerFlex";
        }
    }
}
