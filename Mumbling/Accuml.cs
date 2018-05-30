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


            if (s.Length == 2)
            {
                accumList.Add(ToUpper(accumCharArray[0]));
                accumList.Add(ToUpper(accumCharArray[1]) + ToLower(accumCharArray[1]));
                accum = string.Join("-", accumList);
            }
            else
            {
                accumList.Add(ToUpper(accumCharArray[0]));
                accumList.Add(ToUpper(accumCharArray[1]) + ToLower(accumCharArray[1]));
                accumList.Add(ToUpper(accumCharArray[2]) + ToLower(accumCharArray[2]) + ToLower(accumCharArray[2]));

                accum = string.Join("-", accumList);
            }

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