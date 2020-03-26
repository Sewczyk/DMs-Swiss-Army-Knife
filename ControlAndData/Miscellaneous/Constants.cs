using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CipherLib.Miscellaneous
{
    public static class Constants
    {
        public static string CaesarCipherName { get; } = "Szyfr Cezara";
        public static string NihilistCipherName { get; } = "Szyfr Nihilistów";
        public static string BinaryTranslation { get; } = "Translacja Binarnie";
        public static string PlayfairCipherName { get; } = "Szyfr Playfair'a";
        public static string FutharkTranslation { get; } = "Translacja do Futhark";
        public static string AlphabetWithPolishLetters { get; } = "AaĄąBbCcĆćDdEeĘęFfGgHhIiJjKkLlŁłMmNnŃńOoÓóPpQqRrSsŚśTtUuVvWwXxYyZzŹźŻż";
        private static string PolishToLatinLetterConverted { get; } = "AaAaBbCcCcDdEeEeFfGgHhIiJjKkLlLlMmNnNnOoOoPpQqRrSsSsTtUuVvWwXxYyZzZzZz";
        public static Dictionary<char, char>PolishToLatinLettersDictionary()
        {
            Dictionary<char,char>outputDictionary = new Dictionary<char, char>();
            for (int i = 0; i < AlphabetWithPolishLetters.Length; i++)
            {
                outputDictionary.Add(AlphabetWithPolishLetters[i], PolishToLatinLetterConverted[i]);
            }
            return outputDictionary;
        }
    }
}
