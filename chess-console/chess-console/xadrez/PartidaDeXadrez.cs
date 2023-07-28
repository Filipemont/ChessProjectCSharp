using tabuleiro;

namespace xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }
        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }
        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimento();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicaoxadrez ('c',1).toPosicao());
            tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicaoxadrez('c', 2).toPosicao());
            tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicaoxadrez('d', 2).toPosicao());
            tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicaoxadrez('e', 1).toPosicao());
            tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicaoxadrez('e', 2).toPosicao());
            tab.colocarPeca(new Rei(Cor.Branca, tab), new Posicaoxadrez('d', 1).toPosicao());


            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicaoxadrez('c', 7).toPosicao());
            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicaoxadrez('c', 8).toPosicao());
            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicaoxadrez('d', 7).toPosicao());
            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicaoxadrez('e', 8).toPosicao());
            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicaoxadrez('e', 7).toPosicao());
            tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicaoxadrez('d', 8).toPosicao());
        }
    }
}
