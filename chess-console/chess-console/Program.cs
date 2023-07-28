using System.Xml;
using tabuleiro;
using xadrez;


namespace chess_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicaoxadrez pos = new Posicaoxadrez('c', 7);
            Console.WriteLine(pos.toPosicao());
        }
    }
}