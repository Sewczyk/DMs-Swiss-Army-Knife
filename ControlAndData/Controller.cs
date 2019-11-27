using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControlAndData.Ciphers;
using ControlAndData.Miscellaneous;
using static ControlAndData.Miscellaneous.DataContainer;

namespace ControlAndData
{
    public class Controller
    {
        public bool HasCipheringOrderChanged { get; set; }

        public List<string> AllCiphers { get; private set; }
        public List<Cipher> CipheringOrder { get; private set; }
        public Controller()
        {
            HasCipheringOrderChanged = false;
            AllCiphers = new List<string>();
            CipheringOrder = new List<Cipher>();
            CaesarCipher caesarCipher = new CaesarCipher();
            InitializeListOfCiphers();
        }


        public void AddNewNihilistPlayfairInstanceToCipheringOrder(string _name, string _keyword)
        {
            CipheringOrder.Add(new NihilistCipher(_name, _keyword));
            HasCipheringOrderChanged = true;

        }
        
        public void ScanCipheringOrder()
        {
            Console.WriteLine("Big One");
        }
        private void InitializeListOfCiphers()
        {
            AllCiphers = new List<string>
            {
                CaesarCipherName,
                NihilistCipherName,
                BinaryTranslation,
                PlayfairCipherName,
                FutharkTranslation
            };
        }

        
    }
}
