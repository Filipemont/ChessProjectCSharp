using tabuleiro;


namespace chess_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3,4);
            Console.WriteLine("Posicao: "+P);
        }
    }
}