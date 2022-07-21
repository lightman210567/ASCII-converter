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
                case 'd':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(100, ASCII);
                    break;
                case 'e':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(101, ASCII);
                    break;
                case 'f':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(102, ASCII);
                    break;
                case 'g':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(103, ASCII);
                    break;
                case 'h':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(104, ASCII);
                    break;
                case 'i':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(105, ASCII);
                    break;
                case 'j':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(106, ASCII);
                    break;
                case 'k':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(107, ASCII);
                    break;
                case 'l':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(108, ASCII);
                    break;
                case 'm':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(109, ASCII);
                    break;
                case 'n':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(110, ASCII);
                    break;
                case 'o':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(111, ASCII);
                    break;
                case 'p':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(112, ASCII);
                    break;
                case 'q':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(113, ASCII);
                    break;
                case 'r':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(114, ASCII);
                    break;
                case 's':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(115, ASCII);
                    break;
                case 't':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(116, ASCII);
                    break;
                case 'u':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(117, ASCII);
                    break;
                case 'v':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(118, ASCII);
                    break;
                case 'w':
                    ASCII = TextConverter.LowerCharacterConvert(letter);
                    Assert.AreEqual(119, ASCII);
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
