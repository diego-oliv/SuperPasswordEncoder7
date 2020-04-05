using System;
using System.Collections.Generic;

namespace SPE7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string password = "";
            string codifiedPassword = "";

            Intro();
            System.Console.Write("Type the word to encrypt it: ");
            password = Console.ReadLine().ToLower();

            List<String> passwordChars = new List<string>();
            char[] passwordArray = password.ToCharArray();
            for(int i=0; i < passwordArray.Length; i++)
            {
                switch(passwordArray[i])
                {
                    case 'a':
                    string charA = "U8tHtVi8Gk9";
                    passwordChars.Add(charA);
                    break;

                    case 'b':
                    string charB = "xmRSC5aHC$@";
                    passwordChars.Add(charB);
                    break;

                    case 'c':
                    string charC = "rQ8jGSd%vRT";
                    passwordChars.Add(charC);
                    break;

                    case 'd':
                    string charD = "Vjv0$Xwta";
                    passwordChars.Add(charD);
                    break;

                    case 'e':
                    string charE = "9JCsln";
                    passwordChars.Add(charE);
                    break;

                    case 'f':
                    string charF = "yoWWVib570g";
                    passwordChars.Add(charF);
                    break;

                    case 'g':
                    string charG = "XwtaTbCeq";
                    passwordChars.Add(charG);
                    break;

                    case 'h':
                    string charH = "f@M2HuUW";
                    passwordChars.Add(charH);
                    break;

                    case 'i':
                    string charI = "NfBNfsSjp3Qu@";
                    passwordChars.Add(charI);
                    break;

                    case 'j':
                    string charJ = "FxRwldWapXG#";
                    passwordChars.Add(charJ);
                    break;

                    case 'k':
                    string charK = "qS$aTMTldkY";
                    passwordChars.Add(charK);
                    break;

                    case 'l':
                    string charL = "MaIdLkT50C3R";
                    passwordChars.Add(charL);
                    break;

                    case 'm':
                    string charM = "HG%$iO0wiiwoQ%%b";
                    passwordChars.Add(charM);
                    break;

                    case 'n':
                    string charN = "5b9T7bKxs";
                    passwordChars.Add(charN);
                    break;

                    case 'o':
                    string charO = "sO0nu";
                    passwordChars.Add(charO);
                    break;

                    case 'p':
                    string charP = "umIXbCZ80";
                    passwordChars.Add(charP);
                    break;

                    case 'q':
                    string charQ = "Ztx7ljuJ";
                    passwordChars.Add(charQ);
                    break;

                    case 'r':
                    string charR = "s#mDl3bl%";
                    passwordChars.Add(charR);
                    break;

                    case 's':
                    string charS = "2FOP%XN1Jw";
                    passwordChars.Add(charS);
                    break;

                    case 't':
                    string charT = "UPJPZ#J0l";
                    passwordChars.Add(charT);
                    break;

                    case 'u':
                    string charU = "cDLrZDoiAcv";
                    passwordChars.Add(charU);
                    break;

                    case 'v':
                    string charV = "KZnwpn2yZ9mdl@UeW";
                    passwordChars.Add(charV);
                    break;

                    case 'w':
                    string charW = "sfq%1bhCuKp%";
                    passwordChars.Add(charW);
                    break;

                    case 'x':
                    string charX = "%aMhEG2kI2";
                    passwordChars.Add(charX);
                    break;

                    case 'y':
                    string charY = "baw7G%k6ddX5";
                    passwordChars.Add(charY);
                    break;

                    case 'z':
                    string charZ = "@DhFjTC%sm0cISa";
                    passwordChars.Add(charZ);
                    break;

                    case '0':
                    string char0 = "eNZ4ZnUH02h";
                    passwordChars.Add(char0);
                    break;

                    case '1':
                    string char1 = "nmbcwHgF38%p";
                    passwordChars.Add(char1);
                    break;

                    case '2':
                    string char2 = "mRJP9bbgOQT";
                    passwordChars.Add(char2);
                    break;

                    case '3':
                    string char3 = "Kko4LgQpwBpF";
                    passwordChars.Add(char3);
                    break;

                    case '4':
                    string char4 = "hWkxl";
                    passwordChars.Add(char4);
                    break;

                    case '5':
                    string char5 = "tKO8Ot8RW";
                    passwordChars.Add(char5);
                    break;

                    case '6':
                    string char6 = "Ui966BPBBbyd";
                    passwordChars.Add(char6);
                    break;

                    case '7':
                    string char7 = "fmsp0jDU$IEF4iPI";
                    passwordChars.Add(char7);
                    break;

                    case '8':
                    string char8 = "$5h0v7HKbHkA";
                    passwordChars.Add(char8);
                    break;

                    case '9':
                    string char9 = "Aq$cEV%5D6o";
                    passwordChars.Add(char9);
                    break;

                    case '!':
                    string specialChar1 = "sc1";
                    passwordChars.Add(specialChar1);
                    break;

                    case '@':
                    string specialChar2 = "sc2";
                    passwordChars.Add(specialChar2);
                    break;

                    case '#':
                    string specialChar3 = "sc3";
                    passwordChars.Add(specialChar3);
                    break;

                    case '$':
                    string specialChar4 = "sc4";
                    passwordChars.Add(specialChar4);
                    break;

                    case '%':
                    string specialChar5 = "";
                    passwordChars.Add(specialChar5);
                    break;

                    case '&':
                    string specialChar6 = "";
                    passwordChars.Add(specialChar6);
                    break;
                }
            }

            foreach(string passwordChar in passwordChars)
            {
                codifiedPassword += passwordChar;
            }
            int passwordLenght = codifiedPassword.Length;
            System.Console.Write("This is your encrypted password: ");
            System.Console.WriteLine(codifiedPassword);
            System.Console.WriteLine($"The password has {passwordLenght} characters.");
        }
        private static void Intro()
        {
            System.Console.WriteLine("======================================");
            System.Console.WriteLine("      Super Passoword Encoder 7");
            System.Console.WriteLine("======================================");
            System.Console.WriteLine();
        }
    }
}
