using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CipherLib.Ciphers;
using CipherLib.Miscellaneous;
using static CipherLib.Miscellaneous.Constants;

namespace CipherLib
{
    public class CipherDataContainer
    {
        public bool HasCipheringOrderChanged { get; set; }

        public List<string> AvilableCiphers { get; private set; }
        public List<ICipher> CipheringOrder { get; set; }
        public CipherDataContainer()
        {
            HasCipheringOrderChanged = false;
            AvilableCiphers = new List<string>();
            CipheringOrder = new List<ICipher>();
            InitializeListOfCiphers();
        }


        public void AddNihilistInstance(string _name, string _keyword)
        {
            CipheringOrder.Add(new NihilistCipher(_name, _keyword));
            HasCipheringOrderChanged = true;

        }
        
        private void InitializeListOfCiphers()
        {
            AvilableCiphers = new List<string>
            {
                CaesarCipherName,
                NihilistCipherName,
                BinaryTranslation,
                PlayfairCipherName,
            };
        }

        
    }
}
