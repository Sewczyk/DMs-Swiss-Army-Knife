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
        List<ICipher> CipheringOrder { get; set; }
        private Constants Constants = new Constants();
        public Controller()
        {
            AllCiphers = new List<string>();
            CipheringOrder = new List<ICipher>();
            foreach (string obj in Constants.ListOfCiphers)
            {
                AllCiphers.Add(obj);
            }
        }

        private void InitializeCipherNames()
        {
            
        }
        
    }
}
