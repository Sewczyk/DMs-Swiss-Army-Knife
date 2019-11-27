using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlAndData.Miscellaneous
{
    public class DataContainer
    {
        public string CaesarCipherName { get; private set; }
        public string NihilistCipherName { get; private set; }
        public string BinaryTranslation { get; private set; }
        public string PlayfairCipherName { get; private set; }
        public string FutharkTranslation { get; private set; }
        static string AlphabetWithPolishLetters;
        public static Dictionary<char, int> LettersToNumbers { get; private set; }
        public static Dictionary<int,char> NumbersToLetters { get; private set; }
        public List<string> ListOfCiphers { get; private set; }
        
        public DataContainer()
        {

            CaesarCipherName = "Szyfr Cezara";
            NihilistCipherName = "Szyfr Nihilistów";
            BinaryTranslation = "Translacja Binarnie";
            PlayfairCipherName = "Szyfr Playfair'a";
            AlphabetWithPolishLetters = "AĄBCĆDEĘFGHIJKLŁMNŃOÓPRSŚTUVWXYZŹŻaąbcćdeęfghijklłmnńoóprsśtuvwxyzźż";
            FutharkTranslation = "Translacja do Futhark";
            InitializeDictionaries();
            InitializeListOfCiphers();

            
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

        private void InitializeListOfCiphers()
        {
            ListOfCiphers = new List<string>();
            ListOfCiphers.Add(CaesarCipherName);
            ListOfCiphers.Add(NihilistCipherName);
            ListOfCiphers.Add(BinaryTranslation);
            ListOfCiphers.Add(PlayfairCipherName);
            ListOfCiphers.Add(FutharkTranslation);
        }
    }
}
