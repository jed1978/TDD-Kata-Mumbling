using System;
using System.Linq;

namespace Mumbling
{
    public class Accuml
    {
        public string Accum(string s)
        {
            if (s.Length > 1)
            {
                var accumCharArray = s.ToCharArray();
                var accumStringArray = new[]
                {
                    accumCharArray[0].ToString().ToUpper(),
                    accumCharArray[1].ToString().ToUpper() + accumCharArray[1].ToString().ToLower()
                };
                return String.Join("-", accumStringArray);
            }

            return s.ToUpper();
        }
    }
}