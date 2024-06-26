﻿using ChessGame.TabuleiroChess;

namespace ChessGame.GameChess
{
    public class Peao : Peca
    {
        private readonly PartidaDeXadrez _partida;

        public Peao(Tabuleiro tabuleiro, Cor cor, PartidaDeXadrez partida) : base(tabuleiro, cor)
        {
            _partida = partida;
        }


        public override string ToString()
        {
            return "P";
        }

        private bool ExisteInimigo(Posicao pos)
        {
            Peca p = Tabuleiro.Peca(pos);
            return p != null && p.Cor != Cor;
        }

        private bool Livre(Posicao pos)
        {
            return Tabuleiro.Peca(pos) == null;
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

            if (Cor == Cor.Branca)
            {
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(pos) && Livre(pos))
                {
                    posicoes[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna);

                if (Tabuleiro.PosicaoValida(pos) && Livre(pos) && QtdeMovimentos == 0)
                {
                    posicoes[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);

                if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    posicoes[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);

                if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    posicoes[pos.Linha, pos.Coluna] = true;
                }

                #region Jogada Especial En Passant
                if (Posicao.Linha == 3)
                {
                    Posicao esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);

                    if (Tabuleiro.PosicaoValida(esquerda) && ExisteInimigo(esquerda) && Tabuleiro.Peca(esquerda) == _partida.VulneravelEnPassant)
                    {
                        posicoes[esquerda.Linha - 1 , esquerda.Coluna] = true;
                    }

                    Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);

                    if (Tabuleiro.PosicaoValida(direita) && ExisteInimigo(direita) && Tabuleiro.Peca(direita) == _partida.VulneravelEnPassant)
                    {
                        posicoes[direita.Linha - 1, direita.Coluna] = true;
                    }


                }
                #endregion

            }
            else
            {
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(pos) && Livre(pos))
                {
                    posicoes[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna);

                if (Tabuleiro.PosicaoValida(pos) && Livre(pos) && QtdeMovimentos == 0)
                {
                    posicoes[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);

                if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    posicoes[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);

                if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    posicoes[pos.Linha, pos.Coluna] = true;
                }


                #region Jogada Especial En Passant
                if (Posicao.Linha == 4)
                {
                    Posicao esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);

                    if (Tabuleiro.PosicaoValida(esquerda) && ExisteInimigo(esquerda) && Tabuleiro.Peca(esquerda) == _partida.VulneravelEnPassant)
                    {
                        posicoes[esquerda.Linha + 1, esquerda.Coluna] = true;
                    }

                    Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);

                    if (Tabuleiro.PosicaoValida(direita) && ExisteInimigo(direita) && Tabuleiro.Peca(direita) == _partida.VulneravelEnPassant)
                    {
                        posicoes[direita.Linha + 1, direita.Coluna] = true;
                    }
                    #endregion

                }
            }
            return posicoes;
        }
    }
}
