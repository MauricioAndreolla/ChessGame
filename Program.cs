using ChessGame.GameChess;
using ChessGame.TabuleiroChess;

namespace ChessGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            
            tabuleiro.ColocarPeca(new Torre(tabuleiro ,Cor.Preta), new Posicao{ Coluna = 0, Linha = 0 });
            tabuleiro.ColocarPeca(new Torre(tabuleiro ,Cor.Preta), new Posicao{ Coluna = 7, Linha = 0 });

            Tela.ImprimirTabuleiro(tabuleiro);

            Console.ReadLine();

        }
    }
}
