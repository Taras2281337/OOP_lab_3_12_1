using System;

namespace OOP_lab_3_12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] ch = Console.ReadLine().ToCharArray();

            for (int i = 0; i < ch.Length / 2; ++i)
            {
                char tempChar = ch[i];
                ch[i] = ch[ch.Length - 1 - i];
                ch[ch.Length - 1 - i] = tempChar;
            }

            string str = new string(ch);

            Console.WriteLine("\n{0}", str);

            string[] elements = str.Split(new char[] { '\n', '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);

            int k = 0;

            foreach (string element in elements)
            {
                int k1 = 0;

                foreach (char c in element)
                {
                    if ((c >= (char)48) && (c <= (char)57)) ++k1;
                }

                if (k1 == element.Length) ++k;
            }

            Console.WriteLine("Kiлькiсть чисел у текстi: {0}", k);
        }
    }
}
