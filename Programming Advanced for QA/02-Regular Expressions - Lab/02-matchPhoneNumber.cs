using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        
        string text = Console.ReadLine();

        
        string pattern = @"\+359( |-)2\1\d{3}( |-)\d{4}\b";

        
        MatchCollection matches = Regex.Matches(text, pattern);

        
        foreach (Match match in matches)
        {
            Console.Write(match.Value);
            if (match != matches[matches.Count - 1])
            {
                Console.Write(", ");
            }
        }
    }
}
