using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CipherLib.Ciphers
{
    public interface ICipher
    {
        string Name { get; }
        void RunLogic(string input);
        string OutputToListBox(); // wyjście w formacie "Nazwa szyfru | zastosowany klucz"
        
    }
}
