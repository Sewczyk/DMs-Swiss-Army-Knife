using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static CipherLib.Miscellaneous.Constants;

namespace CipherLib.Miscellaneous
{
    public static class Transformations
    {
        public static Dictionary<char, char> PolishToEnglishAlphabet()
        {
            Dictionary<char, char> output = new Dictionary<char, char>();
            for (int i = 0; i < AlphabetWithPolishLetters.Length; i++)
            {
                if ((int)AlphabetWithPolishLetters[i] > 128)
                    output.Add(AlphabetWithPolishLetters[i], AlphabetWithPolishLetters[i - 1]);
                else
                    output.Add(AlphabetWithPolishLetters[i], AlphabetWithPolishLetters[i]);

            }
            return output;
        }
    }
}
