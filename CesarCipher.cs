﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecryptAndEncrypt
{
    static class CesarCipher
    { 
        public static string decrypt(string text, int key)
        {
            key = 26 - key;
            string output = string.Empty;

            foreach (char ch in text)
                output += cipher(ch, key);

            return output;

        }

        public static string encrypt(string text, int key)
        {
            string output = string.Empty;

            foreach (char ch in text)
                output += cipher(ch, key);

            return output;
        }

        private static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }

    }
}
