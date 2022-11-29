using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtendString
{
    public static class StringExtensions
    {
        private static Random rnd;
        static StringExtensions()
        {
            rnd = new Random();
        }
        public static string ToRandomCase (this string s)
        {
            var aux = new StringBuilder();
            foreach(char c in s)
            {
                if(rnd.Next(0,2) == 1)
                    aux.Append(Char.ToUpper(c));
                else
                    aux.Append(Char.ToLower(c));
            }
            return aux.ToString();
        }
    }
}