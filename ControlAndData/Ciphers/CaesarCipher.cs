using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ControlAndData.Ciphers
{
    public class CaesarCipher : ICipher
    {
        public int Shift { get; private set; }

        public string Name { get; }

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
            throw new NotImplementedException();
        }

        public string OutputToListBox()
        {
            return $"{Name} | {Shift.ToString()}";
        }
    }
}
