using System;
using System.Collections.Generic;
using System.Linq;

namespace Mumbling
{
    public class Accuml
    {
        public string Accum(string s)
        {
            if (s.Length <= 1)
            {
                return s.ToUpper();
            }

            char[] accumCharArray = s.ToCharArray();

            List<string> accumList = new List<string>();

            string accum;

            for (int i = 0; i < s.Length; i++)
            {
                accumList.Add(ToUpper(accumCharArray[i]) + new String(accumCharArray[i], i).ToLower());
            }
            accum = string.Join("-", accumList);

            return accum;
        }

        private static string ToLower(char accumChar)
        {
            return accumChar.ToString().ToLower();
        }

        private static string ToUpper(char accumChar)
        {
            return accumChar.ToString().ToUpper();
        }
    }
}