using System;

class Progrma
{


    static void Main()
    {
        int divid, divis, resul, res;


        Console.WriteLine("Dirite o dividendo");
        divid = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Divisor");
         divis = int.Parse(Console.ReadLine());
         resul=Divide(divid,divis,out res);

         Console.WriteLine("Dividendo/Divisor= "+ resul +"  o resto da divisão é:"+ res );
         Console.WriteLine(res);

    }

    static int Divide(int divisor, int dividendo, out int resto)
    {

        int resultado;
        resultado = divisor / dividendo;
        resto = divisor % dividendo;
        return resultado;

    }

}