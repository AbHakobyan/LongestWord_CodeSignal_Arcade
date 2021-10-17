using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LongestWord_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "To be or not to be";
            string st = longestWord(s);
            Console.WriteLine(st);
        }

        static string longestWord(string text)
        {
            return Regex.Split(text, @"[^a-zA-Z]+").OrderByDescending(_ => _.Length).First();
        }
    }
}
