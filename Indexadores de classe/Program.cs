﻿using System;
using System.Runtime.CompilerServices;

class Progeam
{


    static void Main()
    {
        Console.WriteLine("Olar mundo");
        Carro c1 = new Carro();
        
        Console.WriteLine("A velocidade maxima é: "+c1[4]);
    }
}

class Carro
{
    private int[] velMax = new int[5]{80,120,160,540,300};

    public int this[int i]{
        get
        {
            return velMax[i];
        }set
        {
            if (value < 0)
            {
                velMax[i] = 0;
            }
            else if (value > 300)
            {
                velMax[i] = 300;
            }
            else
            {
                velMax[i] = value;
            }
        }
    }

    public Carro()
    {
    

    }
}