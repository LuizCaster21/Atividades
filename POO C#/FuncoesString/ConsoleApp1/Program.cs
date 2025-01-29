using System;

namespace FuncStrings
{
    class Program
    {
        public static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABCD abc DEFG   ";
            
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);

            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
        }
    }
}