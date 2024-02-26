using System;

class Program
{
    static void Main()
    {
        Console.WriteLine();
        int N = int.Parse(Console.ReadLine());

        int result = 0;

        Console.WriteLine();

        for (int i = 0; i < N; i++)
        {
            char ch = char.ToLower(Console.ReadLine()[0]); 

            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    result += GetValue(ch);
                    break;
                default:
                    
                    break;
            }
        }

        Console.WriteLine(result);
    }

    static int GetValue(char ch)
    {
        
        switch (ch)
        {
            case 'a': return 1;
            case 'e': return 2;
            case 'i': return 3;
            case 'o': return 4;
            case 'u': return 5;
            default: return 0; 
        }
    }
}