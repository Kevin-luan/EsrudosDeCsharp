//Metodos são um conjuntos de intuçãos que pode ser chamado a qualquer momento do nosso programa 

using System;

class Program
{

    static void Main()
    {

        Saldacao();
   
        Soma(15, 2);

        int v1, v2,r;
        Console.WriteLine("Digite o primeiro numero");
        v1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero");
        v2 = Convert.ToInt32(Console.ReadLine());

        Soma2(v1, v2);
        r=soma3(v1,v2);
        Console.WriteLine("Retornando o valor do metodo:"+ r);



    }

    static void Saldacao()
    {
        Console.WriteLine("Bom dia");
    }

    // Metodo para somar dois valores
    static void Soma(int n1, int n2)
    {

        int res = n1 + n2;
        Console.WriteLine(res);

    }
    // MEtodo para somar dois valres que sairam do teclado
    static void Soma2(int n1, int n2)
    {

        int res = n1 + n2;
        Console.WriteLine(res);

    }

    // Metodos com retorno 
    static int soma3(int n1, int n2)
    {
        int res = n1 + n2;
        return res;

    }

}

