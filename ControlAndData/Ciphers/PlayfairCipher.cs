using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CipherLib.Ciphers;
using static CipherLib.Miscellaneous.Constants;

namespace ControlAndData.Ciphers
{
    public class PlayfairCipher : ICipher
    {
        public string Name { get; private set; }
        public string Keyword { get; private set; }
        private string TranscribedKeyword;
        private char[,] CipheringTable = new char[5,5];
        private Dictionary<char, char> toPolishLetters = PolishToLatinLettersDictionary();
        private string lettersPool = "ABCDEFGHIJKLMNOPRSTUVWXYZ";
        public PlayfairCipher(string _Keyword)
        {
            Name = PlayfairCipherName;
            Keyword = _Keyword;
            prepareData(_Keyword);
        }
        public string OutputToListBox()
        {
            throw new NotImplementedException();
        }

        public string RunLogic(string input)
        {
            throw new NotImplementedException();
        }

        private void prepareData(string _keyword)
        {
            string finalString, parsingString;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _keyword.Length; i++)
            {
                sb.Append(toPolishLetters[_keyword[i]]);
            }
            TranscribedKeyword = sb.ToString();
            parsingString = TranscribedKeyword + lettersPool;
            finalString = parsingString.ToUpper();
            finalString = new string(finalString.Distinct().ToArray());
            short CipheringTableRow = 0;
            for (int i = 0; i < finalString.Length; i++)
            {
                CipheringTable[CipheringTableRow, i % 5] = finalString[i];
                if (i%5 == 4)
                    CipheringTableRow++;
            }
        }
    }
}
