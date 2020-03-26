using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlAndData.Ciphers;

namespace CipherLibUnitTests
{
    
    [TestClass]
    public class BinaryConversionUnitTests
    {
        [TestMethod]
        [DataRow ("testmessage", "0111010001100101011100110111010001101101011001010111001101110011011000010110011101100101")]
        [DataRow("B", "01000010")]
        [DataRow("test,message", "011101000110010101110011011101000010110001101101011001010111001101110011011000010110011101100101")]
        [DataRow("łóżko żółć", "1010000101111001110111110001101011011011110010000010111110011110011101000010100000111")]
        public void BinaryConversionLogicTest(string _input, string _expectedOutput)
        {
            BinaryConversion binaryConversion = new BinaryConversion();
            string outputString = binaryConversion.RunLogic(_input);
            Assert.AreEqual(_expectedOutput, outputString);
        }
    }
}
