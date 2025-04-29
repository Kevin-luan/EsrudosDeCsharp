using System;

class Program
{

    static void Main()
    {


        int[] num = new int[3] { 1, 32, 3 };
        Console.WriteLine("Repetição usando o for ");

        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine(num[i]);
        }
        Console.WriteLine("Repetição usando o Foreach");
        foreach(int i in num){
            Console.WriteLine(i);
        }
    }
}