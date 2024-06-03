using ChessGame.TabuleiroChess;

namespace ChessGame.GameChess
{
    public class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override string ToString()
        {
            return "C";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tabuleiro.Peca(pos);
            return p == null || p.Cor != this.Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] posicoes = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            #region Acima

            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 2);

            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                posicoes[pos.Linha, pos.Coluna] = true;

            }

            pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna - 1);

            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                posicoes[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna + 1);

            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                posicoes[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 2);

            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                posicoes[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 2);

            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                posicoes[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna + 1);

            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                posicoes[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna - 1);

            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                posicoes[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 2);

            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                posicoes[pos.Linha, pos.Coluna] = true;
            }

            #endregion
            return posicoes;
        }
    }
}