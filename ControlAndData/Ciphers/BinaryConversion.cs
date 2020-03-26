using CipherLib.Ciphers;
using CipherLib.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace ControlAndData.Ciphers
{
    public class BinaryConversion : ICipher
    {
        public string Name { get; }
        private Dictionary<char,char>conversionDictionary;
        public BinaryConversion()
        {
            Name = Constants.BinaryTranslation;
            conversionDictionary = Constants.PolishToLatinLettersDictionary();
        }

        public string OutputToListBox()
        {
            return $"{Name}";
        }

        public string RunLogic(string input)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < input.Length; i++)
            {
                sb.Append(Convert.ToString((int)input[i], 2).PadLeft(8, '0'));
            }
            input = sb.ToString();
            return input;
        }

    }
}
