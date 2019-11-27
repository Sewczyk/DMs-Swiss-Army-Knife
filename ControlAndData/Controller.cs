using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControlAndData.Ciphers;
using ControlAndData.Miscellaneous;

namespace ControlAndData
{
    public class Controller
    {
        public List<string> AllCiphers { get; private set; }
        public List<Cipher> CipheringOrder { get; private set; }
        public DataContainer Constants { get; }
        public Controller()
        {
            Constants = new DataContainer();
            AllCiphers = new List<string>();
            CipheringOrder = new List<Cipher>();
            CaesarCipher caesarCipher = new CaesarCipher();
            foreach (string obj in Constants.ListOfCiphers)
            {
                AllCiphers.Add(obj);
            }
        }


        public void CreateNihilistCipherInstance(string _name, string _keyword)
        {
            CipheringOrder.Add(new NihilistCipher(_name, _keyword));
            
        }
        
        public void scanCipheringOrder()
        {
            Console.WriteLine("Big One");
        }
    }
}
