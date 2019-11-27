using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlAndData.Miscellaneous
{
    public static class DataContainer
    {
        public static string CaesarCipherName = "Szyfr Cezara";
        public static string NihilistCipherName = "Szyfr Nihilistów";
        public static string BinaryTranslation = "Translacja Binarnie";
        public static string PlayfairCipherName = "Szyfr Playfair'a";
        public static string FutharkTranslation = "Translacja do Futhark";
        private static string AlphabetWithPolishLetters = "AĄBCĆDEĘFGHIJKLŁMNŃOÓPRSŚTUVWXYZŹŻaąbcćdeęfghijklłmnńoóprsśtuvwxyzźż";
        public static Dictionary<char, int> LettersToNumbers { get; private set; }
        public static Dictionary<int,char> NumbersToLetters { get; private set; }

        private static void InitializeDictionaries()
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
