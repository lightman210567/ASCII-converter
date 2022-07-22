using System;

namespace lightman210567.ASCIIConverter
{
    public class TextConverter
    {
        // the method for converting a upper case character to ASCII
        public static int UpperCharacterConvert(char letter)
        {
            int ASCII;

            // identifies what letter was entered and sets the ASCII value accordingly
            switch (letter)
            {
                case 'A':
                    ASCII = 65;
                    break;
                case 'B':
                    ASCII = 66;
                    break;
                case 'C':
                    ASCII = 67;
                    break;
                case 'D':
                    ASCII = 68;
                    break;
                case 'E':
                    ASCII = 69;
                    break;
                case 'F':
                    ASCII = 70;
                    break;
                case 'G':
                    ASCII = 71;
                    break;
                case 'H':
                    ASCII = 72;
                    break;
                case 'I':
                    ASCII = 73;
                    break;
                case 'J':
                    ASCII = 74;
                    break;
                case 'K':
                    ASCII = 75;
                    break;
                case 'L':
                    ASCII = 76;
                    break;
                case 'M':
                    ASCII = 77;
                    break;
                case 'N':
                    ASCII = 78;
                    break;
                case 'O':
                    ASCII = 79;
                    break;
                case 'P':
                    ASCII = 80;
                    break;
                case 'Q':
                    ASCII = 81;
                    break;
                case 'R':
                    ASCII = 82;
                    break;
                case 'S':
                    ASCII = 83;
                    break;
                case 'T':
                    ASCII = 84;
                    break;
                case 'U':
                    ASCII = 85;
                    break;
                case 'V':
                    ASCII = 86;
                    break;
                case 'W':
                    ASCII = 87;
                    break;
                case 'X':
                    ASCII = 88;
                    break;
                case 'Y':
                    ASCII = 89;
                    break;
                case 'Z':
                    ASCII = 90;
                    break;
                default:
                    ASCII = 00; // sets the ASCII value to 00. 00 is ASCII for NUL
                    throw new Exception("An error has occured"); // throws an exception if none of the about cases are met.
            };

            return ASCII;
        }

        // the method for converting lower case characters to ASCII
        public static int LowerCharacterConvert(char letter)
        {
            int ASCII;

            // identifies what letter was inputted and sets the ASCII value accordingly
            switch (letter)
            {
                case 'a':
                    ASCII = 97;
                    break;
                case 'b':
                    ASCII = 98;
                    break;
                case 'c':
                    ASCII = 99;
                    break;
                case 'd':
                    ASCII = 100;
                    break;
                case 'e':
                    ASCII = 101;
                    break;
                case 'f':
                    ASCII = 102;
                    break;
                case 'g':
                    ASCII = 103;
                    break;
                case 'h':
                    ASCII = 104;
                    break;
                case 'i':
                    ASCII = 105;
                    break;
                case 'j':
                    ASCII = 106;
                    break;
                case 'k':
                    ASCII = 107;
                    break;
                case 'l':
                    ASCII = 108;
                    break;
                case 'm':
                    ASCII = 109;
                    break;
                case 'n':
                    ASCII = 110;
                    break;
                case 'o':
                    ASCII = 111;
                    break;
                case 'p':
                    ASCII = 112;
                    break;
                case 'q':
                    ASCII = 113;
                    break;
                case 'r':
                    ASCII = 114;
                    break;
                case 's':
                    ASCII = 115;
                    break;
                case 't':
                    ASCII = 116;
                    break;
                case 'u':
                    ASCII = 117;
                    break;
                case 'v':
                    ASCII = 118;
                    break;
                case 'w':
                    ASCII = 119;
                    break;
                case 'x':
                    ASCII = 120;
                    break;
                case 'y':
                    ASCII = 121;
                    break;
                case 'z':
                    ASCII = 122;
                    break;
                default:
                    ASCII = 00; // sets the ASCII value to 00. 00 is ASCII for NUL
                    throw new Exception("An error has occured."); // Throws an exception if none of the above cases are met
            };

            return ASCII; // returns the ASCII value

        }
    }
}