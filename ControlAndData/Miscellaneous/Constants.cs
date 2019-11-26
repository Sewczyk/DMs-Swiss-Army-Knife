using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlAndData.Miscellaneous
{
    public class Constants
    {
        public static string CaesarCipherName { get; private set; }
        public static string NihilistCipherName { get; private set; }
        public static string BinaryCipherName { get; private set; }
        public static string PlayfairCipherName { get; private set; }
        static string AlphabetWithPolishLetters;
        public static Dictionary<char, int> LettersToNumbers { get; private set; }
        public static Dictionary<int,char> NumbersToLetters { get; private set; }
        public Constants()
        {

            CaesarCipherName = "Szyfr Cezara";
            NihilistCipherName = "Szyfr Nihilistów";
            BinaryCipherName = "Binarnie";
            PlayfairCipherName = "Szyfr Playfair'a";
            AlphabetWithPolishLetters = "AĄBCĆDEĘFGHIJKLŁMNŃOÓPRSŚTUVWXYZŹŻaąbcćdeęfghijklłmnńoóprsśtuvwxyzźż";
            InitializeDictionaries();
            
        }

        private void InitializeDictionaries()
        {
            LettersToNumbers = new Dictionary<char, int>();
            NumbersToLetters = new Dictionary<int, char>();
            for(int i = 0; i < AlphabetWithPolishLetters.Length; i++)
            {
                LettersToNumbers.Add(AlphabetWithPolishLetters[i], i);
                NumbersToLetters.Add(i, AlphabetWithPolishLetters[i]);
            }
        }
    }
}
