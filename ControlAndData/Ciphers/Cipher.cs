using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlAndData.Ciphers
{
    public abstract class Cipher
    {
        public string Name { get; private set; }
        public Cipher()
        {

        }
        public Cipher(string _name)
        {
            Name = _name;
        }
    }
}
