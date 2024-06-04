using ChessGame.TabuleiroChess;

namespace ChessGame.GameChess
{
    public class Rei : Peca
    {
        private readonly PartidaDeXadrez _partida;

        public Rei(Tabuleiro tabuleiro, Cor cor, PartidaDeXadrez partida) : base(tabuleiro, cor)
        {
            _partida = partida;
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

            #region JogadaEspecial Roque Pequeno e Maior
            if (QtdeMovimentos == 0 && !_partida.Xeque)
            {
                Posicao posicaoTorre = new Posicao(Posicao.Linha, Posicao.Coluna + 3);

                if (TesteTorreParaRoque(posicaoTorre))
                {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);

                    if (Tabuleiro.Peca(p1) == null && Tabuleiro.Peca(p2) == null)
                    {
                        posicoes[Posicao.Linha, Posicao.Coluna + 2] = true;
                    }
                }

                Posicao posicaoTorre2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);

                if (TesteTorreParaRoque(posicaoTorre2))
                {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                    Posicao p3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);

                    if (Tabuleiro.Peca(p1) == null && Tabuleiro.Peca(p2) == null && Tabuleiro.Peca(p3) == null)
                    {
                        posicoes[Posicao.Linha, Posicao.Coluna - 2] = true;
                    }
                }

            }

            #endregion



            return posicoes;
        }

        private bool TesteTorreParaRoque(Posicao posicao)
        {
            Peca p = Tabuleiro.Peca(posicao);
            return p != null && p is Torre && p.Cor == Cor && p.QtdeMovimentos == 0;

        }

        public override string ToString()
        {
            return "R";
        }

    }
}
