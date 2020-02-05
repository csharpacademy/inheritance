
namespace Inheritance_Miscellaneous
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
