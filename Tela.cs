﻿using ChessGame.GameChess;
using ChessGame.TabuleiroChess;

namespace ChessGame
{
    public class Tela
    {

        public static void ImprimirPartida(PartidaDeXadrez partida)
        {
            ImprimirTabuleiro(partida.Tabuleiro);

            Console.WriteLine();
            ImprimirPecasCapturadas(partida);


            Console.WriteLine();
            Console.WriteLine($"Turno: {partida.Turno}");

            if (!partida.Terminada)
            {
                Console.WriteLine($"Aguardando jogada: {partida.JogadorAtual}");

                if (partida.Xeque)
                {
                    Console.WriteLine("XEQUE");
                }
            } else
            {
                Console.WriteLine("XequeMate");
                Console.WriteLine("Vencedor " + partida.JogadorAtual);
            }


        }

        public static void ImprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Peças capturadas: ");
            Console.Write("Brancas: ");
            ImprimirConjunto(partida.PecasCapturadas(Cor.Branca));

            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;


            Console.Write("Pretas: ");
            ImprimirConjunto(partida.PecasCapturadas(Cor.Preta));

            Console.ForegroundColor = aux;
        }

        public static void ImprimirConjunto(HashSet<Peca> pecas)
        {
            Console.Write("[");
            foreach (Peca x in pecas)
            {
                Console.Write($"{x} ");
            }

            Console.Write("]");
            Console.WriteLine();
        }

        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    ImprimirPeca(tabuleiro.Peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirTabuleiro(Tabuleiro tabuleiro, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoNovo = ConsoleColor.DarkGray;




            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (posicoesPossiveis[i, j] == true)
                    {
                        Console.BackgroundColor = fundoNovo;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    ImprimirPeca(tabuleiro.Peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }


        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.Cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);

        }
    }
}
