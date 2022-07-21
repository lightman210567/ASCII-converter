using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lightman210567.ASCIIConverter;

namespace ASCIIConverter.Tests
{
    [TestClass]
    public class CharacterConversionTests
    {
        [TestMethod]
        [DataRow('A')]
        [DataRow('B')]
        [DataRow('C')]
        [DataRow('D')]
        [DataRow('E')]
        [DataRow('F')]
        [DataRow('G')]
        [DataRow('H')]
        [DataRow('I')]
        [DataRow('J')]
        [DataRow('K')]
        [DataRow('L')]
        [DataRow('M')]
        [DataRow('N')]
        [DataRow('O')]
        [DataRow('P')]
        [DataRow('Q')]
        [DataRow('R')]
        [DataRow('S')]
        [DataRow('T')]
        [DataRow('U')]
        [DataRow('V')]
        [DataRow('W')]
        [DataRow('X')]
        [DataRow('Y')]
        [DataRow('Z')]
        public void UpperCaseConversion(char letter)
        {
            int ASCII;

            switch (letter)
            {
                case 'A':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(65, ASCII);
                    break;
                case 'B':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(66, ASCII);
                    break;
                case 'C':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(67, ASCII);
                    break;
                case 'D':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(68, ASCII);
                    break;
                case 'E':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(69, ASCII);
                    break;
                case 'F':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(70, ASCII);
                    break;
                case 'G':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(71, ASCII);
                    break;
                case 'H':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(72, ASCII);
                    break;
                case 'I':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(73, ASCII);
                    break;
                case 'J':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(74, ASCII);
                    break;
                case 'K':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(75, ASCII);
                    break;
                case 'L':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(76, ASCII);
                    break;
                case 'M':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(77, ASCII);
                    break;
                case 'N':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(78, ASCII);
                    break;
                case 'O':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(79, ASCII);
                    break;
                case 'P':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(80, ASCII);
                    break;
                case 'Q':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(81, ASCII);
                    break;
                case 'R':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(82, ASCII);
                    break;
                case 'S':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(83, ASCII);
                    break;
                case 'T':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(84, ASCII);
                    break;
                case 'U':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(85, ASCII);
                    break;
                case 'V':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(86, ASCII);
                    break;
                case 'W':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(87, ASCII);
                    break;
                case 'X':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(88, ASCII);
                    break;
                case 'Y':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(89, ASCII);
                    break;
                case 'Z':
                    ASCII = TextConverter.UpperCharacterConvert(letter);
                    Assert.AreEqual(90, ASCII);
                    break;
            };
        }

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
