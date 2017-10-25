using System;
public class TryCatch
{
    static void Main(string[] args)
    {
        int a = 0;
        int b = 10;
        try
        {
            b /= a;
            Console.WriteLine(a);
        }
        catch {
            Console.WriteLine("Attemp to devide zero")
        }
    }
}
