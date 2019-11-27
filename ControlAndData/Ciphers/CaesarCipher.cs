using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ControlAndData.Ciphers
{
    public class CaesarCipher : Cipher
    {
        public int Shift { get; private set; }

        public override string Name => throw new NotImplementedException();

        public CaesarCipher()
        {
            //do stuff;
        }

        public CaesarCipher(string _name, int _shift)
        {
            Shift = _shift;
        }

        public override void PrepareData()
        {
            throw new NotImplementedException();
        }

        public override void RunLogic()
        {
            throw new NotImplementedException();
        }

        public override string OutputToListBox()
        {
            return Name + "," + Shift.ToString();
        }
    }
}
