using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlAndData.Ciphers
{
    interface ICipher
    {
        string Name { get; }
        void RunLogic();
    }
}
