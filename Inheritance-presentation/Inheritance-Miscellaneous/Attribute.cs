using System;

namespace Inheritance_Miscellaneous
{
    class CustomAttribute : Attribute
    {
        public CustomAttribute()
        {
        }
    }

    [Custom]
    class DecoratedClass
    {
    }
}
