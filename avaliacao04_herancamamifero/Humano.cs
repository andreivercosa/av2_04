using System;
namespace avaliacao04_herancamamifero
{
    public class Humano : Mamifero
    {
        public void racional()
        {
            Console.WriteLine("Pensando racionalmente");
        }

        public void fala()
        {
            Console.WriteLine("Falando");
        }
        public Humano()
        {
        }
    }
}
