using System;
using System.Security.Cryptography;
using System.Text;

namespace SPE7
{
    class Program
    {
        // This variable is needed to increase performance for long passwords.
        private static string latestHash = "";
        static void Main(string[] args)
        {
            Console.Clear();
            int desiredPasswordLength = 100000;

            Intro();
            Console.Write("Type the word to encrypt it: ");
            string password = Console.ReadLine();

            string codifiedPassword = ComputeHashForString(password);
            while (codifiedPassword.Length < desiredPasswordLength)
            {
                codifiedPassword += ComputeHashForString(latestHash);
            }
            codifiedPassword = codifiedPassword.Substring(0, desiredPasswordLength);

            int passwordLenght = codifiedPassword.Length;
            Console.Write("This is your encrypted password: ");
            Console.WriteLine(codifiedPassword);
            Console.WriteLine($"The password has {passwordLenght} characters.");
        }

        private static string ComputeHashForString(string stringToHash)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                var hash = mySHA256.ComputeHash(Encoding.UTF8.GetBytes(stringToHash));
                latestHash = Convert.ToBase64String(hash);
                return latestHash;
            }
        }

        private static void Intro()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("      Super Passoword Encoder 7");
            Console.WriteLine("======================================");
            Console.WriteLine();
        }
    }
}
