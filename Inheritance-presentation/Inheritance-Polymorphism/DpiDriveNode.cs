
namespace InheritanceAndPolymorphism
{
    class DpiDriveNode : DriveNode
    {
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
