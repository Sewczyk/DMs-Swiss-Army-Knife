using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static CipherLib.Miscellaneous.Constants;


namespace CipherLib.Ciphers
{
    public class CaesarCipher 
    {
        public int Shift { get; private set; }

        private Dictionary<char, int> LettersToNumbers;
        private Dictionary<int, char> NumbersToLetters;

        public string Name { get; }

        public CaesarCipher(int _shift)
        {
            Name = CaesarCipherName;
            Shift = _shift;
            prepareData();
        }

        public string RunLogic(string _input)
        {
            //string outputMessage;
            int letterIntValue;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _input.Length; i++)
            {
                letterIntValue = LettersToNumbers[_input[i]];
                letterIntValue += Shift%(LettersToNumbers.Count/2);
                sb.Append(NumbersToLetters[letterIntValue]);
            }
            //_input = sb.ToString();
            return sb.ToString();
        }

        public string OutputToListBox()
        {
            return $"{Name} | {Shift.ToString()}";
        }

        private void prepareData()
        {
            LettersToNumbers = new Dictionary<char, int>();
            NumbersToLetters = new Dictionary<int, char>();
            for (int i = 0; i < AlphabetWithPolishLetters.Length; i++)
            {
                LettersToNumbers.Add(AlphabetWithPolishLetters[i], i);
                NumbersToLetters.Add(i, AlphabetWithPolishLetters[i]);
            }
        }
    }
}
