using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine()); 
        int T = int.Parse(Console.ReadLine());
        int A = int.Parse(Console.ReadLine());

        Console.WriteLine("Сколько тык-дыгов можно сделать без корма: "); 
        Console.WriteLine(N);
        Console.WriteLine("Сколько корма нужно съесть после: ");
        Console.WriteLine(T);
        Console.WriteLine("Сколько тык-дыгов ты хочешь сделать: ");
        Console.WriteLine(A);
        Console.WriteLine("Тебе потребуется " + ( A / N * T ) + " грамм корма, чтобы сделать " + A + " тык-дыгов.");


    }
}
