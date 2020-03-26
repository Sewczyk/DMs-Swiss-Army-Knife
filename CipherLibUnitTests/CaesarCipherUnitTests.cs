using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CipherLib.Ciphers;
using static CipherLib.Miscellaneous.Constants;

namespace CipherLibUnitTests
{
    /// <summary>
    /// Summary description for CaesarCipherUnitTests
    /// </summary>
    [TestClass]
    public class CaesarCipherUnitTests
    {
        [TestMethod]
        [DataRow(1,"dupa","evqą")]
        [DataRow(7, "dupa", "jżvę")]
        [DataRow(36, "dupa", "evqą")]
        [DataRow(-1, "dupa", "ćtóż")] // fails in weird way, rest is ok, needs bulletproofing
        [DataRow(1, "dupa dupa", "evqą evqą")]
        public void CaesarCipherLogicTest(int shift,string input, string expectedOutput)
        {
            
            CaesarCipher cCipher = new CaesarCipher(shift);
            string outputString = cCipher.RunLogic(input);

            Assert.AreEqual(expectedOutput, outputString);
        }
        
        [TestMethod]
        [DataRow(4)]
        [DataRow(1)]
        [DataRow(-3)]
        public void CaesarCipherConstructorUnitTest(int shift)
        {
            CaesarCipher testCipher = new CaesarCipher(shift);
            Assert.AreEqual(testCipher.Name, CaesarCipherName);
        }
    }
}
