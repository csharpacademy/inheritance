using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Miscellaneous
{
    class Event
    {
        private event EventHandler<CustomEventArgs> handler;
    }

    internal class CustomEventArgs : EventArgs
    {
    }
}
