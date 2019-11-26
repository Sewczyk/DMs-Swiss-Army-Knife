using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ControlAndData.Ciphers
{
    class CaesarCipher : ICipher
    {
        public string Name { get; private set; }
        private int Shift;
        public CaesarCipher()
        {
            //do stuff;
        }

        public CaesarCipher(int _shift)
        {
            Shift = _shift;
        }

        public void RunLogic()
        {
            //do Stuff
        }
    }
}
