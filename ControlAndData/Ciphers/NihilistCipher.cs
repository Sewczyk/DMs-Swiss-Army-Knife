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

        public string Name { get;}


        public NihilistCipher(string _name, string _keyword)
        {
            Name = _name;
            Keyword = _keyword;
        }


        public void RunLogic(string _input)
        {
            throw new NotImplementedException();
        }

        public string OutputToListBox()
        {
            return $"{Name} | {Keyword}";
        }

    }
}
