using System;
using System.Text;

namespace Removeoutterbrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string s = "(()())";
            string r = RemoveOuterParentheses(s);

        }
        static string RemoveOuterParentheses(string S)
        {
            StringBuilder st = new StringBuilder();
            int count = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                {
                    if (count != 0) { st.Append(S[i]); }
                    count++;
                }
                else
                {
                    count--;
                    if (count != 0) { st.Append(S[i]); }
                }
            }

            return st.ToString();
        }
    }
}
