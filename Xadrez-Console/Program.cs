using System;
using Xadrez_Console.tabuleiro;
using Xadrez_Console.xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  try
              {
                  Tabuleiro tabuleiro = new Tabuleiro(8, 8);
                  tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                  tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
                  tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(1, 3));
                  tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(2, 4));

                  Tela.imprimirTabuleiro(tabuleiro);

              }
              catch (TabuleiroException e)
              {
                  Console.WriteLine(e.Message);
              }*/

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            pos.toPosicao();

            Console.Write(pos);

            Console.ReadLine();
        }
    }
}
