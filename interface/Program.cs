using System;

public interface Veiculo
{
    void ligar();
    void desligar();
    void info();



}
public interface Combate
{
    void desparar();
}


class Carro : Veiculo, Combate
{

    public bool ligado;
    public int municao;
    public void desparar()
    {
        this.municao = 10;
    }
    public Carro()
    {

    }

    public void ligar()
    {
        this.ligado = true;
    }
    public void desligar()
    {
        this.ligado = false;
    }

    public void info()
    {

    }
}
class Program
{
    static void Main()
    {
        Carro c1 = new Carro();
        

            }
}