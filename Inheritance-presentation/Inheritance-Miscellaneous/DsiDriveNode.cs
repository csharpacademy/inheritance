using System;

namespace Inheritance_Miscellaneous
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
