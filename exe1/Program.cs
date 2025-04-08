using System;

class Program
{

    static void Main()
    {
        Personagem p1 = new Personagem();
        Console.WriteLine(p1.nome);
        Console.WriteLine(p1.vida);
        Heroi h1 = new Heroi();
        Console.WriteLine(h1.nome);
        Console.WriteLine(h1.vida);
        Vilao v1 = new Vilao();
        Console.WriteLine(v1.nome);
        Console.WriteLine(v1.vida);

    }

}


public class Personagem
{
    public int vida;
    public string nome;

    public Personagem()
    {
        vida = 100;
        nome = "teste";

    }
}

public class Heroi : Personagem
{
    public Heroi()
    {
        nome = "Kevin";
        vida = 200;
    }
}

public class Vilao : Heroi
{
    public Vilao()
    {
        nome = "Tanos";
        vida = 100;
    }
}