using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlAndData.Ciphers
{
    public abstract class Cipher : ICipher
    {
        public Cipher()
        {

        }

        public abstract string Name { get; }
        public abstract string OutputToListBox();
        public abstract void RunLogic();
    }
}
