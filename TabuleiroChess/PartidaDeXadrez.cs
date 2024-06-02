using ChessGame.GameChess;

namespace ChessGame.TabuleiroChess
{
    public class PartidaDeXadrez
    {
        public Tabuleiro? Tabuleiro { get; private set; }
        private int? Turno;
        private Cor? JogadorAtual;
        public bool Terminada { get; set; }

        public PartidaDeXadrez()
        {
            Tabuleiro = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca peca = Tabuleiro.RetirarPeca(origem);
            peca.IncrementarMovimentos();
            Peca capturada = Tabuleiro.RetirarPeca(destino);

            Tabuleiro.ColocarPeca(peca, destino);

        }

        private void ColocarPecas()
        {
                Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('c', 1).ToPosicao());
                Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('c', 2).ToPosicao());
                Tabuleiro.ColocarPeca(new Rei(Tabuleiro, Cor.Preta), new PosicaoXadrez('e', 2).ToPosicao());
        }

    }
}
