using System;

namespace Trim__._4._3
{
    static class MyString
    {
        public static string TrimStart(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    s = s.Substring(i);
                    break;
                }
            }

            return s;
        }

        public static string TrimEnd(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    s = s.Substring(0, i + 1);
                    break;
                }
            }

            return s;
        }
        public static string Trim(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    s = s.Substring(0, i + 1);
                    break;
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    s = s.Substring(i);
                    break;
                }
            }
            return s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string str = "  Code Academy";
            str = MyString.TrimStart(str);
            Console.WriteLine(str);

            string str2 = "CodeAcademy  ";
            str2 = MyString.TrimEnd(str2);
            Console.WriteLine(str2);

            string str3 = "    Code   Academy   ";
            str3 = MyString.Trim(str3);
            Console.WriteLine(str3);
        }
    }
}
