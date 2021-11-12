using System;
using System.Linq;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            char[] characters = str.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }
    }
}
