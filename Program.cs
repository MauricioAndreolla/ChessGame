using ChessGame.GameChess;
using ChessGame.TabuleiroChess;

namespace ChessGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            try
            {
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Branca), new Posicao(4, 5));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(5, 5));

                Tela.ImprimirTabuleiro(tabuleiro);


            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
