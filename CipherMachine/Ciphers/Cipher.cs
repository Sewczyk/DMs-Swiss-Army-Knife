using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CipherMachine.Ciphers
{
    public abstract class Cipher
    {
        private string name { get; }
        public Cipher(string _name)
        {
            name = _name;
        }
        abstract public void Initialize();
        abstract public void Run();

    }
}
