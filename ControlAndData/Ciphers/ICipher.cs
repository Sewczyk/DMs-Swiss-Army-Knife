using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlAndData.Ciphers
{
    public interface ICipher
    {
        string Name { get; }
        void RunLogic();
        string OutputToListBox(); // wyjście w formacie "Nazwa szyfru | zastosowany klucz"
        
    }
}
