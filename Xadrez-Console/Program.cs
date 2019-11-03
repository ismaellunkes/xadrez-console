using System;
using Xadrez_Console.tabuleiro;
using Xadrez_Console.xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partidaDeXadrez = new PartidaDeXadrez();
                while (!partidaDeXadrez.Terminada)
                {
                    try
                    {

                        Console.Clear();
                        Tela.imprimirTabuleiro(partidaDeXadrez.Tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + partidaDeXadrez.Turno);
                        Console.WriteLine("Aguardando jogada: " + partidaDeXadrez.JogadorAtual);


                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partidaDeXadrez.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partidaDeXadrez.Tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partidaDeXadrez.Tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partidaDeXadrez.validarPosicaoDeDestino(origem, destino);

                        partidaDeXadrez.executaMovimento(origem, destino);

                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }

                }

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
