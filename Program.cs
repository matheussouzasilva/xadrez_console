using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8,8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 1));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 3));

                Tela.ImprimirTabuleiro(tab);

                Console.ReadLine();
            }
            catch(TabuleiroException ex)
            { 
                System.Console.WriteLine("Erro: " + ex.Message);                
            }

        }
    }
}