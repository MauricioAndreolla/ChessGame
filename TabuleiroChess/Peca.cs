namespace ChessGame.TabuleiroChess
{
    public abstract class Peca
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
            QtdeMovimentos++;
        }

        public void DecrementarMovimentos()
        {
            QtdeMovimentos--;
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] matriz = MovimentosPossiveis();

            for (int i = 0; i < Tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < Tabuleiro.Colunas; j++)
                {
                    if (matriz[i,j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
       
    }
}
