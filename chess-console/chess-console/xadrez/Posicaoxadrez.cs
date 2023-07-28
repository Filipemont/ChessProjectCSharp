using tabuleiro;

namespace xadrez
{
    internal class Posicaoxadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public Posicaoxadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }
        public override string ToString()
        {
            return  "" + coluna + linha;
        }
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }
    }
}
