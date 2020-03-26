using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static CipherLib.Miscellaneous.Constants;


namespace CipherLib.Ciphers
{
    public class CaesarCipher : ICipher
    {
        public int Shift { get; private set; }

        private Dictionary<char, int> LettersToNumbers;
        private Dictionary<int, char> NumbersToLetters;

        public string Name { get; }

        public CaesarCipher(int _shift)
        {
            Name = CaesarCipherName;
            Shift = _shift*2;
            PrepareData();
        }

        public string RunLogic(string _input)
        {
            //string outputMessage;
            int letterIntValue;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _input.Length; i++)
            {
                try 
                {
                    letterIntValue = LettersToNumbers[_input[i]];
                    if (Shift < 0)
                        Shift = NumbersToLetters.Count + Shift;
                    letterIntValue += Shift;
                    letterIntValue %= NumbersToLetters.Count;
                    sb.Append(NumbersToLetters[letterIntValue]);
            }
                catch(KeyNotFoundException)
                {
                    sb.Append(_input[i]);
                }
            }
            _input = sb.ToString();
            return _input;
        }

        public string OutputToListBox()
        {
            return $"{Name} | {Shift}";
        }

        private void PrepareData()
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
