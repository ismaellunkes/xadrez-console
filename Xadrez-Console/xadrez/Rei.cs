using Xadrez_Console.tabuleiro;

namespace Xadrez_Console.xadrez
{
    class Rei : Peca
    {
        public Rei (Tabuleiro tab, Cor cor)
            :base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
