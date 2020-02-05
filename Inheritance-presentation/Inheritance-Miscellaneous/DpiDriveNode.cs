
namespace Inheritance_Miscellaneous
{
    class DpiDriveNode : DriveNode
    {
        protected void SetFamilyName()
        {
            FamilyName = "PF755T";
        }

        public string Configure()
        {
            return "Configuring PF755T";
        }
    }
}
