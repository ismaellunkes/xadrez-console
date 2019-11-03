using Xadrez_Console.tabuleiro;

namespace Xadrez_Console.xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor)
            : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = Tabuleiro.peca(pos);
            return p == null || p.Cor != this.Cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //ne
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //direita
            pos.definirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //se
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //abaixo
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //so
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //esquerda
            pos.definirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //no
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;

        }
    }
}
