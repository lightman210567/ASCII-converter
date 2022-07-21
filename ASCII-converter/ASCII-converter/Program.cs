using System;

namespace lightman210567.AsciiConverter
{
    public class Converter
    {
        public static int Convert(char letter)
        {
            int ASCII;

            switch (letter)
            {
                case 'a':
                    ASCII = 65;
                    break;
                case 'b':
                    ASCII = 66;
                    break;
                case 'c':
                    ASCII = 67;
                    break;
                case 'd':
                    ASCII = 68;
                    break;
                case 'e':
                    ASCII = 69;
                    break;
                case 'f':
                    ASCII = 70;
                    break;
                case 'g':
                    ASCII = 71;
                    break;
                case 'h':
                    ASCII = 72;
                    break;
                case 'i':
                    ASCII = 73;
                    break;
                case 'j':
                    ASCII = 74;
                    break;
                case 'k':
                    ASCII = 75;
                    break;
                case 'l':
                    ASCII = 76;
                    break;
                case 'm':
                    ASCII = 77;
                    break;
                case 'n':
                    ASCII = 78;
                    break;
                case 'o':
                    ASCII = 79;
                    break;
                case 'p':
                    ASCII = 80;
                    break;
                case 'q':
                    ASCII = 81;
                    break;
                case 'r':
                    ASCII = 82;
                    break;
                case 's':
                    ASCII = 83;
                    break;
                case 't':
                    ASCII = 84;
                    break;
                case 'u':
                    ASCII = 85;
                    break;
                case 'v':
                    ASCII = 86;
                    break;
                case 'w':
                    ASCII = 87;
                    break;
                case 'x':
                    ASCII = 88;
                    break;
                case 'y':
                    ASCII = 89;
                    break;
                case 'z':
                    ASCII = 90;
                    break;
                default:
                    throw new Exception("An error has occured.");
            };

            return ASCII;

        }
    }
}