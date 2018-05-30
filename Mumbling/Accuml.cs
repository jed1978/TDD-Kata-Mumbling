using System;
using System.Linq;

namespace Mumbling
{
    public class Accuml
    {
        public string Accum(string s)
        {
            if (s.Length <= 1) return s.ToUpper();
            var accumCharArray = s.ToCharArray();
            var accumStringArray = new[]
            {
                ToUpper(accumCharArray[0]),
                ToUpper(accumCharArray[1]) + ToLower(accumCharArray[1])
            };
            return string.Join("-", accumStringArray);

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