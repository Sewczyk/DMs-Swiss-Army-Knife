using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static CipherLib.Miscellaneous.Constants;

namespace CipherLib.Ciphers
{
    public class NihilistCipher : ICipher
    {
        public string Keyword { get; set; }

        public string Name { get; private set; }


        public NihilistCipher(string _keyword)
        {
            Name = NihilistCipherName;
            Keyword = _keyword;
        }


        public string RunLogic(string _input)
        {
            return null;
        }

        public string OutputToListBox()
        {
            return $"{Name} | {Keyword}";
        }

    }
}
