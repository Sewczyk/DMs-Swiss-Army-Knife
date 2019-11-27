using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ControlAndData.Ciphers
{
    public class CaesarCipher : Cipher, ICipher
    {
        public int Shift { get; private set; }
        public CaesarCipher()
        {
            //do stuff;
        }

        public CaesarCipher(string _name, int _shift)
        {
            Shift = _shift;
        }

        public void RunLogic()
        {
            //do Stuff
        }

        public void PrepareData()
        {
            throw new NotImplementedException();
        }
    }
}
