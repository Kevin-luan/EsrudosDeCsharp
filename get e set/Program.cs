using System;
using System.Runtime.CompilerServices;

class Progeam
{


    static void Main()
    {
        Console.WriteLine("Olar mundo");
        Carro c1 = new Carro();
        c1.vm = 200;
        Console.WriteLine("A velocidade maxima é: "+c1.vm);
    }
}

class Carro
{
    private int velMax;

    public int vm{
        get
        {
            return velMax;
        }set
        {
            if (value < 0)
            {
                velMax = 0;
            }
            else if (value > 300)
            {
                velMax = 300;
            }
            else
            {
                velMax = value;
            }
        }
    }

    public Carro()
    {
        velMax = 120;

    }
}