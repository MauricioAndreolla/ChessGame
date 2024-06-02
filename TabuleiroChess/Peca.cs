namespace ChessGame.TabuleiroChess
{
    public class Peca
    {
        public Posicao? Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdeMovimentos { get; protected set; } = 0;

        public Tabuleiro Tabuleiro { get; set; } = null!;

        public Peca(Tabuleiro tabuleiro, Cor cor) {
            Posicao = null;
            Tabuleiro = tabuleiro;
            Cor = cor;
            QtdeMovimentos = 0;
        }

        public void IncrementarMovimentos()
        {
            QtdeMovimentos ++;
        }

    }
}
