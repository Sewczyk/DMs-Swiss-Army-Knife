using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlAndData.Ciphers
{
    class NihilistCipher : Cipher, ICipher
    {
        public string keyword { get; set; }

        public NihilistCipher()
        {
            //nonParam
        }

        public NihilistCipher(string _name, string keyword)
        {

        }

        public void PrepareData()
        {
            
        }

        public void RunLogic()
        {
            //do Stuff
        }
    }
}
