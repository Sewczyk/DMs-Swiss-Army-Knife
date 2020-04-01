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
        [DataRow ("testmessage", "001110100 001100101 001110011 001110100 001101101 001100101 001110011 001110011 001100001 001100111 001100101")]
        [DataRow("B", "001000010")]
        [DataRow("test,message", "001110100 001100101 001110011 001110100 000101100 001101101 001100101 001110011 001110011 001100001 001100111 001100101")]
        [DataRow("łóżko żółć", "101000010 011110011 101111100 001101011 001101111 000100000 101111100 011110011 101000010 100000111")]
        public void BinaryConversionLogicTest(string _input, string _expectedOutput)
        {
            BinaryConversion binaryConversion = new BinaryConversion();
            string outputString = binaryConversion.RunLogic(_input);
            Assert.AreEqual(_expectedOutput, outputString);
        }
    }
}
