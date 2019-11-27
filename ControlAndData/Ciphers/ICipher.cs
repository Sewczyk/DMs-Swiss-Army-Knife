using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlAndData.Ciphers
{
    interface ICipher
    {
        string Name { get; }
        void PrepareData();
        void RunLogic();
        string OutputToListBox(); // wyjście w formacie "Nazwa szyfru | zastosowany klucz"
        
    }
}
