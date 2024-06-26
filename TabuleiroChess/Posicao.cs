﻿namespace ChessGame.TabuleiroChess
{
    public class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public Posicao() { }

        public override string ToString()
        {
            return $"{Linha}, {Coluna}"  ;
        }

        public void DefinirValores(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

    }
}
