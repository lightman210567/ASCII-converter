using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lightman210567.ASCIIConverter;

namespace ASCIIConverter.Tests
{
    [TestClass]
    public class CharacterConversionTests
    {
        [TestMethod]
        [DataRow('a')]
        [DataRow('b')]
        [DataRow('c')]
        [DataRow('x')]
        [DataRow('y')]
        [DataRow('z')]
        public static void LowerCaseConversion(char letter)
        {
            switch (letter)
            {
                case 'a':
                    break;
                case 'b':
                    break;
                case 'c':
                    break;
                case 'x':
                    break;
                case 'y':
                    break;
                case 'z':
                    break;
            }
        }
    }
}
