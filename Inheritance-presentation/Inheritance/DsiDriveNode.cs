using System;

namespace Inheritance
{
    class DsiDriveNode : DriveNode
    {
        protected void SetFamilyName()
        {
            FamilyName = "PF525";
        }

        public string Configure()
        {
            return "Configuring PF525";
        }
    }
}
