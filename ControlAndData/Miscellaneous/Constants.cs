using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlAndData.Miscellaneous
{
    public class Constants
    {
        public static string caesarCipherName { get; private set; }
        public static string nihilistCipherName { get; private set; }
        public static string binaryCipherName { get; private set; }
        public static string playfairCipherName { get; private set; }
        public static double stalaPi = 3.14;

        public Constants()
        {
            caesarCipherName = "Szyfr Cezara";
            nihilistCipherName = "Szyfr Nihilistów";
            binaryCipherName = "Binarnie";
            playfairCipherName = "Szyfr Playfair'a";
        }

    }
}
