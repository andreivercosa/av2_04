using System;

namespace avaliacao04_herancamamifero
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano humano = new Humano();
            Cachorro cachorro = new Cachorro();
            Baleia baleia = new Baleia();

            Console.WriteLine("Humano:");
            humano.mama();
            humano.respira();
            humano.fala();
            humano.racional();

            Console.WriteLine("\nCachorro:");
            cachorro.mama();
            cachorro.respira();
            cachorro.mama();
            cachorro.fareja();

            Console.WriteLine("\nBaleia:");
            baleia.mama();
            baleia.respira();
            baleia.nada();
            baleia.sonar();

        }
    }
}
