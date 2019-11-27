using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ControlAndData.Miscellaneous.DataContainer;

namespace ControlAndData.Ciphers
{
    public class NihilistCipher : Cipher
    {

        public string Keyword { get; set; }

        public override string Name { get; }

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
            return Name + " | " + Keyword;
        }

        public NihilistCipher(string _name, string _keyword)
        {
            Name = _name;
            Keyword = _keyword;
        }


    }
}
