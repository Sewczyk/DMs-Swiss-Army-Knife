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
            Shift = _shift;
            prepareData();
        }

        public void RunLogic(string _input)
        {

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
