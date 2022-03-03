using System;
using System.Collections.Generic;
using System.Text;

namespace CodeValueTest2
{
    public class CodeValueCipher
    {
        public int[] Keys = new int[26];
        public string generatedKeyValues { get; set; }

        public string KeysValue = "ABCBEFGHIJKLMNOPQRSTUVWXYZ";

        public CodeValueCipher()
        {
            GenerateKey();
        }

        public string Decrypt(string message, string key)
        {
            var chrArr = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                var ind = KeysValue.IndexOf(message[i]);
                //chrArr[i] = generatedKeyValues[ind];
                chrArr[i] = key[ind];
            }

            return new string(chrArr);
        }

        public string Encrypt(string message, string key)
        {
            var chrArr = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                //var ind = generatedKeyValues.IndexOf(message[i]);
                var ind = key.IndexOf(message[i]);                
                chrArr[i] = KeysValue[ind];
            }

            return new string(chrArr); 
        }

        public void GenerateKey()
        {
            Random rnd = new Random();
            var chrArr = new char[26];
            for (int i = 0; i < Keys.Length; i++)
            {
                var ind1 = rnd.Next(26);
                var ind2 = rnd.Next(26);

                var temp = Keys[ind1];
                Keys[ind1] = Keys[ind2];
                Keys[ind2] = temp;
            }

            for (int i = 0; i < Keys.Length; i++)
            {
                chrArr[i] = KeysValue[Keys[i]];
            }

            generatedKeyValues = chrArr.ToString();
        }
    }
}
