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
        [DataRow('d')]
        [DataRow('e')]
        [DataRow('f')]
        [DataRow('g')]
        [DataRow('h')]
        [DataRow('i')]
        [DataRow('j')]
        [DataRow('k')]
        [DataRow('l')]
        [DataRow('m')]
        [DataRow('n')]
        [DataRow('o')]
        [DataRow('p')]
        [DataRow('q')]
        [DataRow('r')]
        [DataRow('s')]
        [DataRow('t')]
        [DataRow('u')]
        [DataRow('v')]
        [DataRow('w')]
        [DataRow('x')]
        [DataRow('y')]
        [DataRow('z')]
        public void LowerCaseConversion(char letter)
        {
            int ASCII;

            switch (letter)
            {
                case 'a':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(97, ASCII);
                    break;
                case 'b':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(98, ASCII);
                    break;
                case 'c':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(99, ASCII);
                    break;
                case 'x':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(120, ASCII);
                    break;
                case 'y':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(121, ASCII);
                    break;
                case 'z':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(122, ASCII);
                    break;
            }
        }
    }
}
