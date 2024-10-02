namespace Panagram;

class Program
{
    static void Main(string[] args)
    {
        //string str = "abcdefghijklmnopqrstuvwxyz";
        //Console.WriteLine($"Is {str} a pangram? "+ IsPangram(str));
    }

    public static bool IsPangram(string str)
    {
        for (int i = 0; i < 26; i++)
        {
            char c = Convert.ToChar(i + 97); 
            if(!str.Contains(c)) return false;
        }
        return true;
    }

    
}
