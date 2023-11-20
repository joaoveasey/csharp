using System.Diagnostics;

class Program
{
    static void Main()
    {
        if(int.TryParse("455.5", out int x))
        {
            Console.WriteLine("Success!");
        }
        else
        {
            Console.WriteLine("Error...");
        }
        
    }
}
