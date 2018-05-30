using System;
using System.Collections.Generic;
using System.Linq;

namespace Mumbling
{
    public class Accuml
    {
        public string Accum(string s)
        {
            return string.Join("-",
                s.Select((t, i) => ToUpper(s.ToCharArray()[i]) + ToLower(s.ToCharArray()[i], i)).ToList());
        }

        private static string ToLower(char accumChar, int repeat)
        {
            return new string(char.ToLower(accumChar), repeat);
        }

        private static string ToUpper(char accumChar)
        {
            return accumChar.ToString().ToUpper();
        }
    }
}