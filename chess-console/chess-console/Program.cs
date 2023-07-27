using tabuleiro;
using xadrez;


namespace chess_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Posicao P;

                //P = new Posicao(3,4);
                // Console.WriteLine("Posicao: "+P);

                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
                tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 9));

                Tela.imprimirTabuleiro(tab);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}