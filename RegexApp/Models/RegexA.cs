using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace RegexApp.Models
{
    public class RegexA
    {

        public static string? FindRegexInText(string text, string pattern)
        {
            string result = "";
            Regex rex = new Regex(pattern);
            MatchCollection y = rex.Matches(text);
            foreach (Match x in y)
            {
                result += (x.Value + "\n");
            }
            return result;
        }
    }
}