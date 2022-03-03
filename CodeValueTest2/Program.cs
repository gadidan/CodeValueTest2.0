using System;

namespace CodeValueTest2
{
    class Program
    {
        static void Main(string[] args)
        {

            //GenerateKey();
            //Console.WriteLine(generatedKeyValues);            
            //Console.WriteLine(generatedKeyValues.Length);
            Console.WriteLine(generatedKeyValues);
            Console.WriteLine();
            Console.WriteLine(KeysValue);
            Console.WriteLine();
            //MTBWZSKIUNCPYJHXLREVGABFOQ
            //ABCBEFGHIJKLMNOPQRSTUVWXYZ
            var val = "ABC";
            var dec = "MTB";
            Console.WriteLine(PrintDecription(val, dec));
            val = "XYZ";
            dec = "FOQ";
            Console.WriteLine(PrintDecription(val, dec));

            val = "ACE";
            dec = "MBW";
            Console.WriteLine(PrintDecription(val,dec));

            val = "ACE";
            dec = "MBZ";
            Console.WriteLine(PrintDecription(val, dec));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            var enc = "MTB";
            val = "ABC";
            Console.WriteLine(PrintEncription(enc, val));
            enc = "FOQ";
            val = "XYZ";
            Console.WriteLine(PrintEncription(enc, val));
            enc = "MBW";
            val = "ACE";
            Console.WriteLine(PrintEncription(enc, val));
            enc = "MBZ";
            val = "ACE";
            Console.WriteLine(PrintEncription(enc, val));


            Console.ReadKey();
        }

        private static string PrintEncription(string enc, string val)
        {
            return $"checking for '{enc}' encryption to '{val}': { CheckEncription(enc, val)}";
        }

        private static object CheckEncription(string enc, string val)
        {
            var codeValueCipher = new CodeValueCipher();
            return (codeValueCipher.Encrypt(enc, generatedKeyValues) == val);
        }

        private static string PrintDecription(string val, string dec)
        {
            return $"checking for '{val}' decryption to '{dec}': { CheckDecription(val, dec)}";            
        }

        private static bool CheckDecription(string val, string enc)
        {
            var codeValueCipher = new CodeValueCipher();
            return (codeValueCipher.Decrypt(val, generatedKeyValues) == enc);
        }

        public static int[] Keys = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
        public static string generatedKeyValues = "MTBWZSKIUNCPYJHXLREVGABFOQ";

        public static string KeysValue = "ABCBEFGHIJKLMNOPQRSTUVWXYZ";
        public static void GenerateKey()
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

            generatedKeyValues = new string(chrArr);
        }
    }
}
