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
            StringBuilder sb = new StringBuilder();
            foreach(char c in s)
            {
                if(rnd.Next(0,2) == 1)
                    sb.Append(Char.ToUpper(c));
                else
                    sb.Append(Char.ToLower(c));
            }
            return sb.ToString();
        }
    }
}