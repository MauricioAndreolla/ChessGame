namespace ChessGame.TabuleiroChess
{
    public class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public override string ToString()
        {
            return $"{Linha}, {Coluna}"  ;
        }

    }
}
