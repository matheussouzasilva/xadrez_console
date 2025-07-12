using System;
using System.Runtime.Intrinsics.Arm;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);
            System.Console.WriteLine("Posicao" + P);
            Console.ReadLine();
        }
    }
}