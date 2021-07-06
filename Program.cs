using System;
using System.Text;

namespace MarsExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int result = marsExploration(s);
        }

        private static int marsExploration(string s)
        {
            var repeatCount = s.Length / 3;
            var difCount = 0;
            var originalMessage = string.Empty;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < repeatCount; i++)
            {
                sb.Append("SOS");
            }

            originalMessage = sb.ToString();

            for (int i = 0; i < s.Length; i++)
            {
                if(originalMessage[i] != s[i])
                {
                    difCount++;
                }
            }

            return difCount;
        }
    }
}
