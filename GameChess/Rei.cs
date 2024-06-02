using ChessGame.TabuleiroChess;

namespace ChessGame.GameChess
{
    public class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
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

            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);

            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                posicoes[pos.Linha, pos.Coluna] = true;
            }

            #endregion

            #region Nordeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);

            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                posicoes[pos.Linha, pos.Coluna] = true;
            }
            #endregion

            #region Direita
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);

            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                posicoes[pos.Linha, pos.Coluna] = true;
            }
            #endregion

            #region Sudeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);

            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                posicoes[pos.Linha, pos.Coluna] = true;
            }
            #endregion

            #region Abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);

            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                posicoes[pos.Linha, pos.Coluna] = true;
            }
            #endregion

            #region Sudoeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);

            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                posicoes[pos.Linha, pos.Coluna] = true;
            }
            #endregion

            #region Esquerda
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);

            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                posicoes[pos.Linha, pos.Coluna] = true;
            }
            #endregion

            #region Noroeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);

            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                posicoes[pos.Linha, pos.Coluna] = true;
            }
            #endregion

            return posicoes;
        }

        public override string ToString()
        {
            return "R";
        }

    }
}
