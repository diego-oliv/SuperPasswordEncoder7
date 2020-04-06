using System;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace SPE7
{
    class Program
    {
        // This variable is needed to increase performance for long passwords.
        private static string latestHash = "";
        static void Main(string[] args)
        {
            Console.Clear();
            //creating variables
            int desiredPasswordLength = 0;
            string password = "";
            string encryptedPassword = "";

            Intro();
            Console.Write("Type the desired password lenght: ");
            desiredPasswordLength = int.Parse(Console.ReadLine());

            while (password.Length < desiredPasswordLength)
            {
                List<string> characters = new List<string>();
                var randomChar = CreateRandomChar(); 
                characters.Add(randomChar);
                foreach(var character in characters)
                {
                    password += randomChar;
                }
                // password += ComputeHashForString(latestHash);
            }
            encryptedPassword = ComputeHashForString(password);
            Console.WriteLine($"This is your password: {password}.");
        }
        private static void Intro()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("      Super Passoword Encoder 7");
            Console.WriteLine("======================================");
            Console.WriteLine();
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
        private static string CreateRandomChar()
        {
        var chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789!@#$%";
            Random random = new Random();
            string randomCharPicked = new string(
                Enumerable.Repeat(chars, 1)
                            .Select(s => s[random.Next(s.Length)])
                            .ToArray());
        return randomCharPicked;
        }
    }
}
