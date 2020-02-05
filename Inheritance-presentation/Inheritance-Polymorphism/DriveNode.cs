
namespace InheritanceAndPolymorphism
{
    class DriveNode
    {
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
