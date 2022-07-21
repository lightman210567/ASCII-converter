using System;

namespace lightman210567.ASCIIConverter
{
    public class TextConverter
    {
        // converts lower case characters into ASCII numbers
        public static int LowerCharacterConvert(char letter)
        {
            int ASCII;

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
                    throw new Exception("An error has occured.");
            };

            return ASCII;

        }
    }
}