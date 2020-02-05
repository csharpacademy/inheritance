
namespace InheritanceAndPolymorphism
{
    class DsiDriveNode : DriveNode
    {
        protected override void SetFamilyName()
        {
            FamilyName = "PF525";
        }

        public override string Configure()
        {
            return "Configuring PF525";
        }
    }
}
