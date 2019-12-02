using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ControlAndData.Miscellaneous.Constants;

namespace ControlAndData.Ciphers
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


        public void RunLogic()
        {
            throw new NotImplementedException();
        }

        public string OutputToListBox()
        {
            return $"{Name} | {Keyword}";
        }

    }
}
